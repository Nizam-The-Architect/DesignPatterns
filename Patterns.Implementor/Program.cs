// See https://aka.ms/new-console-template for more information
using Behavioral.Visitor;
using Creational.Builder;
using Structural.Bridge;
using Structural.Decorator;
using static Creational.Builder.Person;

print("Bridge pattern demo!");
print("Multiple Products are there, they could be Shipped with multiple ways ", ConsoleColor.Green);
print("Scenrio: multiple classes dependent on multiple classes to achieve something", ConsoleColor.Red);

PhysicalShipping physicalShipping = new PhysicalShipping();
Mobile mobile = new Mobile();

Console.WriteLine("Let's treat a Mobile");
ShipProduct shipProduct = new Mobile();
shipProduct.ShippingComponent = physicalShipping;
shipProduct.Ship();

Console.WriteLine("Let's treat an eBook now");
shipProduct = new Ebook();
shipProduct.ShippingComponent = new DigitalShipping();
shipProduct.Ship();
print("-------------------------------------------------------------------------------------------");
print("Map Rooms with Ammenties");
print("Map One star Room with complimentry bf Ammenty", ConsoleColor.DarkGreen);
MapRoomAndAmenities MapRoomAndAmenities = new OneStarRoom();
MapRoomAndAmenities.BridgeRoomsWithAmenities = new ComplimentryBreakfastAmmentiy();
MapRoomAndAmenities.AssignAmmenity();
print("Map Two star Room with complimentry Swimming pool Ammenty", ConsoleColor.DarkGreen);
MapRoomAndAmenities = new TwoStarRoom();
MapRoomAndAmenities.BridgeRoomsWithAmenities = new SwimmingPoolAmmentiy();
MapRoomAndAmenities.AssignAmmenity();
print("-------------------------------------------------------------------------------------------");
print("Builder design pattern example");
PersonBuilder PersonBuilder = new PersonBuilder();
Person person =
PersonBuilder
    .SetName("Nizam")
    .SetAge(32)
    .SetAge(30)
    .SetId(786)
    .Build();
print($"Name of person is {person.Name} and his Age is {person.Age} while his Id is {person.Id}", ConsoleColor.Yellow);
print("-------------------------------------------------------------------------------------------");
print("Decorator design pattern example");
BasicPushNotificationSender basicPushNotification = new BasicPushNotificationSender();
EmailNotificationDecorator emailNotification = new EmailNotificationDecorator(basicPushNotification);
TextNotificationDecorator textNotification = new TextNotificationDecorator(emailNotification);
CallNotificationDecorator callNotification = new CallNotificationDecorator(textNotification);
print(callNotification.SendNotification(), ConsoleColor.Red);
print("-------------------------------------------------------------------------------------------");
print("Vistor design pattern example");
PersonalLoanVisitor personalLoanVisitor = new PersonalLoanVisitor();
PersonalLoanVerifier personalLoanVerifier = new PersonalLoanVerifier();
print(personalLoanVerifier.Accpet(personalLoanVisitor), ConsoleColor.DarkYellow);
print(personalLoanVerifier.VerifyLoan(), ConsoleColor.DarkYellow);

//print(personalLoanVisitor., ConsoleColor.DarkYellow);

//personalLoanVisitor.Visit(personalLoanVerifier);
print("-------------------------------------------------------------------------------------------");

void print(string message, ConsoleColor color = ConsoleColor.White)
{
    Console.ForegroundColor = color;
    Console.WriteLine(message);
    Console.ForegroundColor = ConsoleColor.White;
}
