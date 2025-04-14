using Lab_04_Roman_Qquelcca.Models;
using Lab_04_Roman_Qquelcca.Repositories.Unit;
using Microsoft.AspNetCore.Mvc;

namespace Lab_04_Roman_Qquelcca.Controllers
{
    [ApiController]
    [Route("api/qquelcca/[controller]")]
    public class DetallesOrdenController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public DetallesOrdenController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/qquelcca/DetallesOrden
        [HttpGet]
        public async Task<IActionResult> ObtenerDetallesOrden()
        {
            var detalles = await _unitOfWork.DetallesOrden.GetAllAsync();
            return Ok(detalles);
        }

        // GET: api/qquelcca/DetallesOrden/5
        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerDetalleOrden(int id)
        {
            var detalle = await _unitOfWork.DetallesOrden.GetByIdAsync(id);
            if (detalle == null)
                return NotFound("Detalle de orden no encontrado");

            return Ok(detalle);
        }
    }
}