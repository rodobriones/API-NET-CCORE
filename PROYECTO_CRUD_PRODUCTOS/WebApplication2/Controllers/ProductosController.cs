using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductosCRUD.Server.Models;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly ProductosCRUDContext _context;

        public ProductosController(ProductosCRUDContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("crearProducto")]
        public async Task<IActionResult> CreateProduct(Producto producto)
        {
            //guardar el producto en la base de datos
            await _context.Productos.AddAsync(producto);
            await _context.SaveChangesAsync();

            //devolver un mensaje de exito
            return Ok();
        }


    }
}
