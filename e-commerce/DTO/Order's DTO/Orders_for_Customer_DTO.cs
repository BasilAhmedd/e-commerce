using e_commerce.DTO.Products_s_DTO;
using e_commerce.Models;
using System.ComponentModel.DataAnnotations;

namespace e_commerce.DTO.Order_s_DTO
{
    public class Orders_for_Customer_DTO
    {
        [Required]
        public int TotalPrice { get; set; }

        public IList<Product_for_order_DTO>? Product_for_order_DTO { get; set; }
    }
}
