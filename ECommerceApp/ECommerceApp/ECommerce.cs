namespace ECommerceApp
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        
    }

    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        
    }

    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        
    }

}