namespace ProductApp.Models
{
    public class Prod
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; } = decimal.Zero;
    }
}
