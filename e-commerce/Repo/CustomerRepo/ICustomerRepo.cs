using e_commerce.DTO.Customer_s_DTO;

namespace e_commerce.Repo.CustomerRepo
{
    public interface ICustomerRepo
    {
        public IEnumerable<Customer_DTO> GetAllCustomers();

        Customer_DTO_for_getbyId GetCustomerById(int id);

        void AddCustomer(Customer_DTO_for_POST dto);
    }
}
