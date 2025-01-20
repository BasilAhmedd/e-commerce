namespace e_commerce.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int? TotalPrice { get; set; }

        public IList<Product>? Products { get; set; }

        public int? CustomerId { get; set; }
        public Customer? Customer { get; set; }
    }
}
