using Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Catagorys
{
    public class Catagory
    {
        public CatagoryId Id { get; private set; }
        public string Name { get; private set; } = string.Empty;

        public ICollection<Product> Products { get; private set; }
    }
}
