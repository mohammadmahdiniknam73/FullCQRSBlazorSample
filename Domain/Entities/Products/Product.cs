﻿using Domain.Entities.Catagorys;
using Domain.Entities.OrderDetails;

namespace Domain.Entities.Products
{
    public class Product
    {
        public Product(ProductId id, string name, string description, DateOnly productionDate, DateOnly? expiringDate, Money price, Sku sku)
        {
            Id = id;
            Name = name;
            Description = description;
            ProductionDate = productionDate;
            ExpiringDate = expiringDate;
            Price = price;
            Sku = sku;
        }

        public ProductId Id { get; private set; }
        public string Name { get; private set; } = string.Empty; 
        public string Description { get; private set; } = string.Empty;
        public DateOnly ProductionDate { get; private set; }
        public DateOnly? ExpiringDate { get; private set; }
        public Money Price { get; private set; }
        public Sku Sku { get; private set; }

        public ICollection<Catagory> Catagories { get; private set; }
        public OrderDetail OrderDetail { get; set; }
    }
}
