using e_commerce.Models;
using System.ComponentModel.DataAnnotations;

namespace e_commerce.DTO.Customer_s_DTO
{
    public class Customer_DTO_for_POST
    {
        [Required]
        public string? Name { get; set; }
        [Phone]
        public string? Contact { get; set; }
        [EmailAddress]
        public string? Email { get; set; }

    }
}
