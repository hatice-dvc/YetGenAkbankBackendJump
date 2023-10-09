using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsApp.Entities
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Category(Guid ıd, string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }
    }
}
