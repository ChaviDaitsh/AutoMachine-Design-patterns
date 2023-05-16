
namespace AutoMachine
{
    public class ChocolateMilk : Product
    {
       

        public string Description { get; set; }
        public ChocolateMilk(Product product) : base(product.Name, product.Price)
        {
        }
        public override string ToString()
        {
            return base.ToString() + Description;
        }
    }
}
