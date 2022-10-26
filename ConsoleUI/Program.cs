// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

IProductDal productDal = new InMemoryProductDal();
var pm = new ProductManager(productDal);
List<Product> products = pm.GetAll();
foreach (var product in products)
{
    Console.WriteLine(product.ProductName);
}

