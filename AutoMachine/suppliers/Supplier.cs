
namespace AutoMachine
{
    public abstract class Supplier
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public Supplier(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }

        public abstract void OrderAProduct(ProductType productType, int numToOrder);
      
    }
}
