

namespace AutoMachine
{
    public class IceChocolateMilk : Product
    {
        

        public string Description { get; set; }
        public IceChocolateMilk(Product product) : base(product.Name, product.Price)
        {
        }
        public override string ToString()
        {
            return base.ToString() + Description;
        }
    }
}
