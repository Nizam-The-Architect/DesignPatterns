namespace Patterns.NullDesignPattern.Contracts.Interfaces
{
    public interface IProduct
    {
        int ProductId { get; set; }
        string ProductName { get; set; }
        double GetPrice();
        /// <summary>
        /// Property to see if the Product is Null or Not
        /// </summary>
        /// <returns></returns>
        bool IsNull { get; }
    }

}
