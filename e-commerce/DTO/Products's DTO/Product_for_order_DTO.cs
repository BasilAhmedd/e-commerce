using System.ComponentModel.DataAnnotations;

namespace e_commerce.DTO.Products_s_DTO
{
    public class Product_for_order_DTO
    {
        [Required]
        public string? Name { get; set; }
        [MaxLength(100)]
        public string? Description { get; set; }
        [Required]
        public int? StockQuantity { get; set; }
    }
}
