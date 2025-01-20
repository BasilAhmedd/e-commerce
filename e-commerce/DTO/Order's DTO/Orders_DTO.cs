using e_commerce.Models;
using System.ComponentModel.DataAnnotations;

namespace e_commerce.DTO.Order_s_DTO
{
    public class Orders_DTO
    {
        [Required]
        public int? TotalPrice { get; set; }

        public IList<Product>? Products { get; set; }

        public int? CustomerId { get; set; }
        public Customer? Customer { get; set; }
    }
}
