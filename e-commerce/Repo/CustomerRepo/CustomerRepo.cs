using e_commerce.Data;
using e_commerce.DTO.Customer_s_DTO;
using e_commerce.DTO.Order_s_DTO;
using e_commerce.DTO.Products_s_DTO;
using e_commerce.DTO.ShoppingCart_s_DTO;
using e_commerce.Models;
using Microsoft.EntityFrameworkCore;

namespace e_commerce.Repo.CustomerRepo
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly AppDbContext _context;
        
        public CustomerRepo (AppDbContext context)
        {
            _context = context;
        }
        public void AddCustomer(Customer_DTO_for_POST dto)
        {
            var customer = new Customer
            {
                Name = dto.Name,
                Contact = dto.Contact,
                Email = dto.Email,
            };
            _context.customers.Add(customer);
            _context.SaveChanges();
        }

        public IEnumerable<Customer_DTO> GetAllCustomers()
        {
            var customer = _context.customers.Include(x=>x.Orders).ThenInclude(x=>x.Products).Include(x=>x.ShoppingCart);
            return customer.Select(x => new Customer_DTO
            {
                Id = x.Id,
                ShoppingCartDTO = new ShoppingCart_DTO
                {
                    NumberOfItems = x.ShoppingCart.NumberOfItems
                },
                Contact = x.Contact,
                Email = x.Email,
                Name = x.Name,
                Order_for_Customer_DTO = x.Orders.Select(x => new Orders_for_Customer_DTO
                {
                    Product_for_order_DTO = x.Products.Select(x=> new Product_for_order_DTO
                    {
                        Description = x.Description,
                        Name = x.Name,
                       StockQuantity = x.StockQuantity
                    }).ToList(),
                    TotalPrice = x.TotalPrice,
                }).ToList()


            });
        }

        public Customer_DTO_for_getbyId GetCustomerById(int id)
        {
            var customer = _context.customers.Include(x => x.Orders).ThenInclude(x => x.Products).Include(x => x.ShoppingCart).FirstOrDefault(x=>x.Id==id);
            if (customer == null)
            {
                throw new KeyNotFoundException("Not Found");
            }
            return new Customer_DTO_for_getbyId
            {
                Contact = customer.Contact,
                Email = customer.Email,
                Name = customer.Name,
                ShoppingCartDTO = new ShoppingCart_DTO
                {
                    NumberOfItems = customer.ShoppingCart?.NumberOfItems
                },
                Orders_for_Customer_DTO = customer.Orders.Select(x => new Orders_for_Customer_DTO
                {
                    TotalPrice = x.TotalPrice,
                    Product_for_order_DTO = x.Products.Select(x => new Product_for_order_DTO
                    {
                        Description = x.Description,
                        Name = x.Name,
                        StockQuantity = x.StockQuantity,
                    }).ToList(),
                }).ToList(),
            };
        }
    }
}
