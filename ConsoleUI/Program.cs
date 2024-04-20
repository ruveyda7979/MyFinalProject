// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;


//SOLID
//Open closed principle: Yaptığın yazılıma
//yeni bir özellik ekliyorsan mevcuttaki hiçbir koduna dokunamazsın.



//ProductTest();

CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
foreach(var category in categoryManager.GetAll())
{
    Console.WriteLine(category.CategoryName);
}

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());
    foreach (var product in productManager.GetAll())
    {
        Console.WriteLine(product.ProductName);
    }
}