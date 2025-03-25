namespace VentaProductos.Web.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public decimal Price { get; set; }
    }
}