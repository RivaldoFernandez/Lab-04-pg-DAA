using Lab_04_Roman_Qquelcca.Models;
using Lab_04_Roman_Qquelcca.Repositories.Unit;
using Microsoft.AspNetCore.Mvc;

namespace Lab_04_Roman_Qquelcca.Controllers;

[ApiController]
[Route("api/qquelcca/[controller]")]
public class OrdenController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;

    public OrdenController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public IActionResult GetAll() => Ok(_unitOfWork.Ordenes.GetAll());

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var orden = _unitOfWork.Ordenes.GetById(id);
        return orden == null ? NotFound() : Ok(orden);
    }

    [HttpPost]
    public IActionResult Create(Ordene orden)
    {
        _unitOfWork.Ordenes.Add(orden);
        _unitOfWork.SaveChanges();
        return Ok("Orden creada");
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Ordene orden)
    {
        var existente = _unitOfWork.Ordenes.GetById(id);
        if (existente == null) return NotFound();

        existente.ClienteId = orden.ClienteId;
        existente.Total = orden.Total;
        _unitOfWork.Ordenes.Update(existente);
        _unitOfWork.SaveChanges();
        return Ok("Orden actualizada");
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _unitOfWork.Ordenes.Delete(id);
        _unitOfWork.SaveChanges();
        return Ok("Orden eliminada");
    }
}