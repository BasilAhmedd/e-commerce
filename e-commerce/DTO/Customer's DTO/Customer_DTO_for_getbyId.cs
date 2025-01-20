using e_commerce.DTO.Order_s_DTO;
using e_commerce.DTO.ShoppingCart_s_DTO;
using e_commerce.Models;
using System.ComponentModel.DataAnnotations;

namespace e_commerce.DTO.Customer_s_DTO
{
    public class Customer_DTO_for_getbyId
    {
        [Required]
        public string? Name { get; set; }
        [Phone]
        public string? Contact { get; set; }
        [EmailAddress]
        public string? Email { get; set; }

        public IList<Orders_for_Customer_DTO>? Orders_for_Customer_DTO { get; set; }

        public ShoppingCart_DTO? ShoppingCartDTO { get; set; }
    }
}
