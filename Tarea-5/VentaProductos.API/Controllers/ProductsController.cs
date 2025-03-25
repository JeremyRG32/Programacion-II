using Microsoft.AspNetCore.Mvc;
using VentaProductos.API.DTOs;
using VentaProductos.Domain;
using VentaProductos.Persistence.Data;

namespace VentaProductos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly VentaProductosDbContext _context;
        public ProductsController(VentaProductosDbContext context)
        {
            _context = context;
        }

        [HttpGet("/GetAll")]
        public IActionResult GetAll()
        {
            var result = _context.Products.ToList();
            return Ok(new { result });
        }
        [HttpGet("/Get{id}")]
        public IActionResult Get(int id)
        {
            var result = _context.Products.Find(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(new { result });
        }
        [HttpDelete("/Delete{id}")]
        public IActionResult Delete(int id)
        {
            var result = _context.Products.Find(id);
            if (result == null)
            {
                return NotFound();
            }
            _context.Products.Remove(result);
            _context.SaveChanges();
            return Ok(new { success = true, message = "Deleted succesfully!" });
        }
        [HttpPost("/Create")]
        public IActionResult Create(ProductDto dto)
        {
            var product = new Product
            {
                Name = dto.Name,
                Price = dto.Price
            };
            _context.Products.Add(product);
            _context.SaveChanges();
            return Ok(new { success = true, message = "Created succesfully!" });
        }
        [HttpPut("/Update{id}")]
        public IActionResult Update(int id, ProductDto dto)
        {
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            product.Name = dto.Name;
            product.Price = dto.Price;

            _context.SaveChanges();
            return Ok(new { success = true, message = "Updated succesfully!" });
        }


    }
}
