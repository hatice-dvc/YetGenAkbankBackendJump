using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsApp.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public Product(string name, decimal price, int categoryId, Category category)
        {
            Id = Guid.NewGuid();
            this.Name = name;
            this.Price = price;
            this.CategoryId = categoryId;
            this.Category = category;
        }
    }
}
