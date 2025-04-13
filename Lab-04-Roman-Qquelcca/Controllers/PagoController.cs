using Lab_04_Roman_Qquelcca.Models;
using Lab_04_Roman_Qquelcca.Repositories.Unit;
using Microsoft.AspNetCore.Mvc;

namespace Lab_04_Roman_Qquelcca.Controllers;

[ApiController]
[Route("api/qquelcca/[controller]")]
public class PagoController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;

    public PagoController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public IActionResult GetAll() => Ok(_unitOfWork.Pagos.GetAll());

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var pago = _unitOfWork.Pagos.GetById(id);
        return pago == null ? NotFound() : Ok(pago);
    }

    [HttpPost]
    public IActionResult Create(Pago pago)
    {
        _unitOfWork.Pagos.Add(pago);
        _unitOfWork.SaveChanges();
        return Ok("Pago creado");
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Pago pago)
    {
        var existente = _unitOfWork.Pagos.GetById(id);
        if (existente == null) return NotFound();

        existente.OrdenId = pago.OrdenId;
        existente.Monto = pago.Monto;
        existente.MetodoPago = pago.MetodoPago;
        _unitOfWork.Pagos.Update(existente);
        _unitOfWork.SaveChanges();
        return Ok("Pago actualizado");
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _unitOfWork.Pagos.Delete(id);
        _unitOfWork.SaveChanges();
        return Ok("Pago eliminado");
    }
}