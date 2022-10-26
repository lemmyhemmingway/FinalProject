// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
// using DataAccess.Concrete.InMemory;
using Entities.Concrete;

// IProductDal productDal = new InMemoryProductDal();
IProductDal efProductDal = new EFProductDal();
var pm = new ProductManager(efProductDal);
List<Product> products = pm.GetAll();
foreach (var product in products)
{
    Console.WriteLine(product);
}

Console.WriteLine("*********************************************************************");
products = pm.GetAllByCategoryId(5);

foreach (var product in products)
{
    Console.WriteLine(product);
}

products = pm.GetAllByPrice(12, 44);


Console.WriteLine("*********************************************************************");
foreach (var product in products)
{
    Console.WriteLine(product);
}
