using Lab_04_Roman_Qquelcca.Models;
using Lab_04_Roman_Qquelcca.Repositories.Unit;
using Microsoft.AspNetCore.Mvc;
namespace Lab_04_Roman_Qquelcca.Controllers;

[ApiController]
[Route("api/qquelcca/[controller]")]
public class ClienteController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;

    public ClienteController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    // GET: api/Cliente
    [HttpGet]
    public IActionResult ObtenerClientes()
    {
        var clientes = _unitOfWork.Clientes.GetAll();
        return Ok(clientes);
    }

    // GET: api/Cliente/5
    [HttpGet("{id}")]
    public IActionResult ObtenerCliente(int id)
    {
        var cliente = _unitOfWork.Clientes.GetById(id);
        if (cliente == null)
            return NotFound("Cliente no encontrado");

        return Ok(cliente);
    }

    // POST: api/Cliente
    [HttpPost]
    public IActionResult CrearCliente([FromBody] Cliente cliente)
    {
        _unitOfWork.Clientes.Add(cliente);
        _unitOfWork.SaveChanges();
        return Ok("Cliente creado con éxito");
    }

    // PUT: api/Cliente/5
    [HttpPut("{id}")]
    public IActionResult ActualizarCliente(int id, [FromBody] Cliente clienteActualizado)
    {
        var cliente = _unitOfWork.Clientes.GetById(id);
        if (cliente == null)
            return NotFound("Cliente no encontrado");

        cliente.Nombre = clienteActualizado.Nombre;
        cliente.Correo = clienteActualizado.Correo;

        _unitOfWork.Clientes.Update(cliente);
        _unitOfWork.SaveChanges();

        return Ok("Cliente actualizado con éxito");
    }

    // DELETE: api/Cliente/5
    [HttpDelete("{id}")]
    public IActionResult EliminarCliente(int id)
    {
        var cliente = _unitOfWork.Clientes.GetById(id);
        if (cliente == null)
            return NotFound("Cliente no encontrado");

        _unitOfWork.Clientes.Delete(id);
        _unitOfWork.SaveChanges();

        return Ok("Cliente eliminado con éxito");
    }
}


