using e_commerce.Models;
using System.ComponentModel.DataAnnotations;

namespace e_commerce.DTO.Products_s_DTO
{
    public class Products_DTO
    {
        [Required]
        public string? Name { get; set; }
        [MaxLength(100)]
        public string? Description { get; set; }
        [Required]
        public int? StockQuantity { get; set; }

        public int? OrderId { get; set; }
        public Order? Order { get; set; }
    }
}
