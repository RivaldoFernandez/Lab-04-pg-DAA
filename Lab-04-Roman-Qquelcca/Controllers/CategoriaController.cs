using Lab_04_Roman_Qquelcca.Models;
using Lab_04_Roman_Qquelcca.Repositories.Unit;
using Microsoft.AspNetCore.Mvc;

namespace Lab_04_Roman_Qquelcca.Controllers;

[ApiController]
[Route("api/qquelcca/[controller]")]
public class CategoriaController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;

    public CategoriaController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public IActionResult GetAll() => Ok(_unitOfWork.Categorias.GetAll());

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var item = _unitOfWork.Categorias.GetById(id);
        return item == null ? NotFound() : Ok(item);
    }

    [HttpPost]
    public IActionResult Create(Categoria categoria)
    {
        _unitOfWork.Categorias.Add(categoria);
        _unitOfWork.SaveChanges();
        return Ok("Categoría creada");
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Categoria categoria)
    {
        var existente = _unitOfWork.Categorias.GetById(id);
        if (existente == null) return NotFound();

        existente.Nombre = categoria.Nombre;
        _unitOfWork.Categorias.Update(existente);
        _unitOfWork.SaveChanges();
        return Ok("Categoría actualizada");
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _unitOfWork.Categorias.Delete(id);
        _unitOfWork.SaveChanges();
        return Ok("Categoría eliminada");
    }
}
