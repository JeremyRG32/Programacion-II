using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Globalization;
using System.Security.Principal;

namespace CRUD_ASP_MVC.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Brand { get; set; }

        [Required, StringLength(50)]
        public string Model { get; set; }

        [Range(1900, 2025, ErrorMessage = "Year must be between 1900 and 2025")]
        public int Year { get; set; }

        [StringLength(30)]
        public string Color { get; set; }

        [Required, StringLength(20)]
        public string LicensePlate { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }

        [DefaultValue(true)]
        public bool Available { get; set; }

    }
}
