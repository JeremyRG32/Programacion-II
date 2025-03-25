using Microsoft.AspNetCore.Mvc;
using VentaProductos.API.DTOs;
using VentaProductos.Domain;
using VentaProductos.Persistence.Data;

namespace VentaProductos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly VentaProductosDbContext _context;
        public CustomersController(VentaProductosDbContext context)
        {
            _context = context;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _context.Customers.ToList();
            return Ok(new { result });
        }
        [HttpGet("Get{id}")]
        public IActionResult Get(int id)
        {
            var result = _context.Customers.Find(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(new { result });
        }
        [HttpDelete("Delete{id}")]
        public IActionResult Delete(int id)
        {
            var result = _context.Customers.Find(id);
            if (result == null)
            {
                return NotFound();
            }
            _context.Customers.Remove(result);
            _context.SaveChanges();
            return Ok(new { success = true, message = "Deleted succesfully!" });
        }
        [HttpPost("Create")]
        public IActionResult Create(CustomerDto dto)
        {
            var customer = new Customer
            {
                Name = dto.Name,
                Email = dto.Email,
            };
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return Ok(new { success = true, message = "Created succesfully!" });
        }
        [HttpPut("Update{id}")]
        public IActionResult Update(int id, CustomerDto dto)
        {
            var customer = _context.Customers.Find(id);
            if (customer == null)
            {
                return NotFound();
            }
            customer.Name = dto.Name;
            customer.Email = dto.Email;

            _context.SaveChanges();
            return Ok(new { success = true, message = "Updated succesfully!" });
        }

    }
}
