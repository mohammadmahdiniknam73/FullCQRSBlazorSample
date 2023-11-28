namespace Domain.Entities.Products
{
    public record Sku
    {
        private const int DefaultLngth = 15;
        private Sku(string value) => Value = value;

        public string Value { get; init; }
        public static Sku? Create(string value)
        {
            if (string.IsNullOrEmpty(value)) 
            {
                return null;
            }
            if(value.Length != DefaultLngth) 
            {
                return null;
            }

            return new Sku(value);
        }
    }
}
