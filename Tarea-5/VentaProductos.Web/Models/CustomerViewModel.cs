namespace VentaProductos.Web.Models
{
    public class CustomerViewModel
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
    }
}