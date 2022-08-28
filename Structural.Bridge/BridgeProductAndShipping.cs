namespace Structural.Bridge
{
    //Product => Mobile, eBook
    //Shipping => Physical, Digital
    public interface IBridgeShippingComponent
    {
        void Ship(string Product);
    }
    public abstract class ShipProduct
    {
        public IBridgeShippingComponent? ShippingComponent { get; set; }
        public abstract void Ship();
    }


    /// <summary>
    /// Product class => eBook
    /// </summary>
    public class Ebook : ShipProduct
    {
        public override void Ship()
        {
            ShippingComponent?.Ship("eBook");
        }
    }
    /// <summary>
    /// Product class => Mobile
    /// </summary>
    public class Mobile : ShipProduct
    {
        public override void Ship()
        {
            ShippingComponent?.Ship("Mobile");
        }
    }


    /// <summary>
    /// Shipping mechanism class => Physical shipping
    /// </summary>
    public class PhysicalShipping : IBridgeShippingComponent
    {
        public void Ship(string Product)
        {
            Console.WriteLine($"Ship {Product} Physically");
        }
    }
    /// <summary>
    /// Shipping mechanism class => Digital shipping
    /// </summary>
    public class DigitalShipping : IBridgeShippingComponent
    {
        public void Ship(string Product)
        {
            Console.WriteLine($"Ship {Product} Digitally");
        }
    }
}