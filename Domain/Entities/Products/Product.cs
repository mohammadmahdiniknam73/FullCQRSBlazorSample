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
        public ProductId Id { get; private set; }
        public string Name { get; private set; } = string.Empty; 
        public string Description { get; private set; } = string.Empty;
        public DateOnly ProductionDate { get; private set; }
        public DateOnly? ExpiringDate { get; private set; }
        public Money Price { get; private set; }
        public Sku Sku { get; private set; }

        public ICollection<Catagory> Catagories { get; private set; }

    }
}
