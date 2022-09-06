using Patterns.NullDesignPattern.Contracts.Interfaces;
namespace Patterns.NullDesignPattern.Contracts.Models
{
    /// <summary>
    /// Class which implements Null design pattern
    /// </summary>
    public class NullProduct : IProduct
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public double GetPrice() => default;
        /// <summary>
        /// Always true for Null object
        /// </summary>
        public bool IsNull => true;
    }

}
