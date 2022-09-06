// See https://aka.ms/new-console-template for more information
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
    .BuildServiceProvider();

IProductRepository productRepository = serviceProvider.GetService<IProductRepository>();
var productId = 1;
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

