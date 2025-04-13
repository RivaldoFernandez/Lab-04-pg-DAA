using Microsoft.AspNetCore.Mvc;
using Lab_04_Roman_Qquelcca.Models;
using Lab_04_Roman_Qquelcca.Repositories.Unit;


[ApiController]
[Route("api/[controller]")]
public class ClienteController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;

    public ClienteController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var clientes = await _unitOfWork.Clientes.GetAll();
        return Ok(clientes);
    }

    [HttpPost]
    public async Task<IActionResult> CrearCliente([FromBody] Cliente cliente)
    {
        await _unitOfWork.Clientes.Add(cliente);
        await _unitOfWork.SaveChangesAsync();
        return Ok(new { message = "Cliente creado con éxito" });
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> ActualizarCliente(int id, [FromBody] Cliente clienteActualizado)
    {
        var clienteExistente = await _unitOfWork.Clientes.GetById(id);

        if (clienteExistente == null)
            return NotFound(new { message = "Cliente no encontrado" });

        clienteExistente.Nombre = clienteActualizado.Nombre;
        clienteExistente.Correo = clienteActualizado.Correo;

        await _unitOfWork.Clientes.Update(clienteExistente);
        await _unitOfWork.SaveChangesAsync();

        return Ok(new { message = "Cliente actualizado con éxito" });
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> EliminarCliente(int id)
    {
        var cliente = await _unitOfWork.Clientes.GetById(id);
        if (cliente == null)
            return NotFound(new { message = "Cliente no encontrado" });

        await _unitOfWork.Clientes.Delete(id);
        await _unitOfWork.SaveChangesAsync();

        return Ok(new { message = "Cliente eliminado con éxito" });
    }
}

