using System.Text.Json;
using System.Text.Json.Serialization;

namespace CafeNoir.Core
{
    [JsonSerializable(typeof(CoffeeShop.CoffeeShopDto))]
    internal partial class CoffeShopDtoSerializationContext : JsonSerializerContext { }

    public sealed class CoffeeShop
    {
        internal sealed class CoffeeShopDto
        {
            public List<Customer> Customers { get; set; } = new();
            public List<Product> Products { get; set; } = new();
            public List<ProductCategory> ProductCats { get; set; } = new();
            public List<Employee> Employess { get; set; } = new();

            public static CoffeeShopDto? TryReadFromFile(string path)
            {
                try
                {
                    using FileStream file = File.OpenRead(path);
                    return JsonSerializer.Deserialize(file, CoffeShopDtoSerializationContext.Default.CoffeeShopDto);
                }
                catch (FileNotFoundException)
                {
                    return null;
                }
            }

            public void WriteToFile(string path)
            {
                using FileStream file = File.Create(path);
                JsonSerializer.Serialize(file, this, CoffeShopDtoSerializationContext.Default.CoffeeShopDto);
            }
        }

        private readonly string? _dataPath;

        private CoffeeShopDto _dto;

        public List<Customer> Customers => _dto.Customers;
        public List<Product> Products => _dto.Products;
        public List<ProductCategory> ProductCats => _dto.ProductCats;
        public List<Employee> Employess => _dto.Employess;

        public Customer RetailCustomer { get; }

        private Customer GetOrCreateRetailCustomer()
        {
            const string retailCustomerCode = "001";
            const string retailCustomerDescription = "Retail Customer";

            Customer? retailCustomerMaybe =
                Customers
                .SingleOrDefault(x =>
                    x.Code.Equals(retailCustomerCode, StringComparison.Ordinal)
                    // The description does not have to be equal ordinally; it is just a descrpitive string.
                    || x.Description.Equals(retailCustomerDescription, StringComparison.InvariantCultureIgnoreCase));

            if (retailCustomerMaybe == null)
            {
                retailCustomerMaybe = new Customer(retailCustomerCode) { Description = retailCustomerDescription };
                Customers.Add(retailCustomerMaybe);
            }

            return retailCustomerMaybe;
        }

        public CoffeeShop(string? dataPath)
        {
            _dataPath = dataPath;
            CoffeeShopDto? dto = null;
            if (dataPath != null)
            {
                dto = CoffeeShopDto.TryReadFromFile(dataPath);
            }

            _dto = dto ?? new();

            RetailCustomer = GetOrCreateRetailCustomer();
        }

        public void SaveChanges()
        {
            // Check if it is not null and store it to a local.
            if (_dataPath is string dataPath)
            {
                _dto.WriteToFile(dataPath);
            }
        }
    }
}
