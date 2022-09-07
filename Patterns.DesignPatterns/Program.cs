using Microsoft.Extensions.DependencyInjection;
using Patterns.NullDesignPattern.Contracts.Interfaces;
using Patterns.NullDesignPattern.DbContext;
using Patterns.NullDesignPattern.DbContext.Interfaces;
using Patterns.NullDesignPattern.Repositories;
using Patterns.NullDesignPattern.Repositories.Interfaces;

Console.WriteLine("Welcome to the world of Design Patterns!");

var serviceProvider = new ServiceCollection()
    .AddScoped<IContext, Context>()
    .AddScoped<IProductRepository, ProductRepository>()
    .AddScoped<IProductRepository_OldSchoolWay, ProductRepository_OldSchoolWay>()
    .BuildServiceProvider();
print("\n\rLet's start by seeing an example of old way of handling the nulls");
var productId = 1;
IProductRepository_OldSchoolWay oldproductRepository = serviceProvider.GetService<IProductRepository_OldSchoolWay>();
print($"Fetching a real product with id {productId} the old way");
IProduct? oldrealProduct = oldproductRepository.GetProductById(productId);
if (oldrealProduct == null)
    print("fetched Product is Null", ConsoleColor.DarkGreen);
else
    print("fetched Product is Not Null", ConsoleColor.DarkGreen);
//Below we've used ?. dereference tool to take care in case the product is null
print($"Real Product {oldrealProduct?.ProductName} has Price = {oldrealProduct?.GetPrice()}", ConsoleColor.DarkGreen);
print("-----------------------------------------------------------------------------");
print("Now we'll try to get a product which doesn't exists ");
print("Note: we need a null check here else we will run in exception");
productId = 10;
IProduct? oldnullProduct = oldproductRepository.GetProductById(productId);
print($"Fetching an invalid product with id {productId}");
if (oldnullProduct == null)
    print("fetched Product is Null", ConsoleColor.DarkGreen);
else
    print("fetched Product is Not Null", ConsoleColor.DarkGreen);
print($"Null Product has no name - {oldnullProduct?.ProductName} and Price = {oldnullProduct?.GetPrice()}", ConsoleColor.DarkGreen);
print("Now in case you forget doing the null check and write code without a null check or without ?. oldnullProduct.ProductName");
print("you'll end up in an error Object reference not set to an instance of an object.'");
//Just uncomment the below line and you'll face the exception.
//print($"Null Product has no name - {oldnullProduct.ProductName} and Price = {oldnullProduct.GetPrice()}", ConsoleColor.DarkGreen);

//reset the productId for further testing.
productId = 1;
print("\n\rBelow code make use of Null design pattern. Let's see the same example with Null design implemented code.");
IProductRepository productRepository = serviceProvider.GetService<IProductRepository>();
print($"\n\rFetching a real product with id {productId}");
IProduct realProduct = productRepository.GetProductById(productId);
print($"Is fetched Product Null = {realProduct.IsNull}", ConsoleColor.DarkGreen);
print($"Real Product {realProduct.ProductName} has Price = {realProduct.GetPrice()}", ConsoleColor.DarkGreen);
print("-----------------------------------------------------------------------------");
print("Now we'll try to get a product which doesn't exists ");
print("still we should NOT get an exception");
print("neither do we need a null check here");
productId = 10;
IProduct nullProduct = productRepository.GetProductById(productId);
print($"Fetching an invalid product with id {productId}");
print($"Is this Product Null = {nullProduct.IsNull}", ConsoleColor.DarkGreen);
print($"Null Product has no name - {nullProduct.ProductName} and Price = {nullProduct.GetPrice()}", ConsoleColor.DarkGreen);


void print(string message, ConsoleColor color = ConsoleColor.White)
{
    Console.ForegroundColor = color;
    Console.WriteLine(message);
    Console.ForegroundColor = ConsoleColor.White;
}

