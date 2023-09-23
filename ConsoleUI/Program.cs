// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;


void NewFunction()
{
    var pm = new ProductManager(new EfProductDal());

    var products = pm.GetByUnitPrice(10, 100);

// foreach (var p in products) Console.WriteLine($"{p.ProductName}");

    var om = new OrderManager(new EfOrderDal());
    var orders = om.GetAll();
    foreach (var o in orders)
    {
        Console.WriteLine($"{o.ShipperId}");
    }
}


var pm = new ProductManager(new EfProductDal());