using Lab_04_Roman_Qquelcca.Models;
using Lab_04_Roman_Qquelcca.Repositories.Unit;
using Microsoft.AspNetCore.Mvc;

namespace Lab_04_Roman_Qquelcca.Controllers;

[ApiController]
[Route("api/qquelcca/[controller]")]
public class ProductoController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;

    public ProductoController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public IActionResult GetAll() => Ok(_unitOfWork.Productos.GetAll());

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var producto = _unitOfWork.Productos.GetById(id);
        return producto == null ? NotFound() : Ok(producto);
    }

    [HttpPost]
    public IActionResult Create(Producto producto)
    {
        _unitOfWork.Productos.Add(producto);
        _unitOfWork.SaveChanges();
        return Ok("Producto creado");
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Producto producto)
    {
        var existente = _unitOfWork.Productos.GetById(id);
        if (existente == null) return NotFound();

        existente.Nombre = producto.Nombre;
        existente.Descripcion = producto.Descripcion;
        existente.Precio = producto.Precio;
        existente.Stock = producto.Stock;
        existente.CategoriaId = producto.CategoriaId;

        _unitOfWork.Productos.Update(existente);
        _unitOfWork.SaveChanges();
        return Ok("Producto actualizado");
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _unitOfWork.Productos.Delete(id);
        _unitOfWork.SaveChanges();
        return Ok("Producto eliminado");
    }
}