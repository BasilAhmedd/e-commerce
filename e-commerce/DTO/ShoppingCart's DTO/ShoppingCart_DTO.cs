using System.ComponentModel.DataAnnotations;

namespace e_commerce.DTO.ShoppingCart_s_DTO
{
    public class ShoppingCart_DTO
    {
        [Required]
        public int NumberOfItems { get; set; }
    }
}
