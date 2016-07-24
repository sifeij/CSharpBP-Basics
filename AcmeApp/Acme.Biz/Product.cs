using static System.Console;

namespace Acme.Biz
{
    /// <summary>
    /// Manages products carried in inventory.
    /// </summary>
    public class Product
    {
        public Product()
        {
            WriteLine("Product instance created");
        }

        public Product(int productId,
                       string productName,
                       string description)
            : this()
        {
            ProductId = productId;
            ProductName = productName;
            Description = description;

            WriteLine($"Product instance has a name: {ProductName}");
        }

        public string ProductName { get; set; }
        public string Description { get; set; }
        public int ProductId { get; set; }

        public string SayHello() => 
            $"Hello {ProductName} ({ProductId}): {Description}";
    }
}
