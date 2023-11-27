using Domain.Entities.Catagorys;
using Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Products
{
    public class Product
    {
        public ProductId Id { get; set; }
        public string Name { get; set; } = string.Empty; 
        public string Description { get; set; } = string.Empty;
        public DateOnly ProductionDate { get; set; }
        public DateOnly? ExpiringDate { get; set; }
        public Money Price { get; set; }
        public Sku Sku { get; set; }

        public ICollection<Catagory> Catagories { get; set; }

    }
}
