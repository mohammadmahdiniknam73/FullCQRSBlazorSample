using Domain.Entities.Products;

namespace Domain.Entities.Catagorys
{
    public class Catagory
    {
        public CatagoryId Id { get; private set; }
        public string Name { get; private set; } = string.Empty;

        public ICollection<Product> Products { get; private set; }
    }
}
