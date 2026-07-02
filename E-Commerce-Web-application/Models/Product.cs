namespace E_Commerce_Web_application.Models
{
    public class Product
    {

        public int Id { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public decimal Price { get;set; }
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
        public bool IsAvailable { get; set; }
        public int Traffic { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public ICollection<ProductImage> ProductImages { get; set; } = new List<ProductImage>();
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

    }
}
