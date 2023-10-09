using ProductsApp.Entities;
using ProductsApp.Persistance;
using System;

Console.WriteLine("Entity Framework - ProductsApp");

// Silme 

using (var context = new ProductsAppDbContext())
{
    var productId = Guid.Parse("Id");
    var product = context.Products.Find(productId);
    if (product != null)
    {
        context.Products.Remove(product);
        context.SaveChanges();
        Console.WriteLine("Ürün başarıyla silindi.");
    }
    else
    {
        Console.WriteLine("Ürün bulunamadı.");
    }
}

// Toplu ekleme

using (var context = new ProductsAppDbContext())
{
    var productsToAdd = new List<Product>
    {
        new Product { Name = "Ürün 1", Price = 100, CategoryId = 1 },
        new Product { Name = "Ürün 2", Price = 150, CategoryId = 1 },
        new Product { Name = "Ürün 3", Price = 200, CategoryId = 2 }
    };

    context.Products.AddRange(productsToAdd);
    context.SaveChanges();
    Console.WriteLine("Ürünler başarıyla eklendi.");
}

// Güncelleme

using (var context = new ProductsAppDbContext())
{
    var productId = Guid.Parse("Id");
    var product = context.Products.Find(productId);
    if (product != null)
    {
        product.Name = "Yeni Ürün Adı";
        product.Price = 250;
        context.SaveChanges();
        Console.WriteLine("Ürün başarıyla güncellendi.");
    }
    else
    {
        Console.WriteLine("Ürün bulunamadı.");
    }
}

