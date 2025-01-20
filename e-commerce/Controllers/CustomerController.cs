using e_commerce.DTO.Customer_s_DTO;
using e_commerce.Repo.CustomerRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace e_commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepo _customerRepo;

        public CustomerController(ICustomerRepo customerRepo)
        {
            _customerRepo = customerRepo;
        }

        [HttpPost]

        public IActionResult AddCustomer(Customer_DTO_for_POST dto)
        {
            if (ModelState.IsValid)
            {
                _customerRepo.AddCustomer(dto);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("All")]

        public IActionResult GetAllCustomers()
        {
            return Ok(_customerRepo.GetAllCustomers());
        }

        [HttpGet("{id}")]
        public IActionResult GetCustomerById(int id) {
            try
            {
                return Ok(_customerRepo.GetCustomerById(id));
            }
            catch (Exception ex) {
              return BadRequest(ex.Message);
            }
        }
    }
}
