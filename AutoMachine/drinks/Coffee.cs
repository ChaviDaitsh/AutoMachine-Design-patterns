
namespace AutoMachine
{
    public class Coffee:Product
    {
        
        public string Description { get; set; }
        public Coffee(Product product) : base(product.Name, product.Price)
        {

        }

        public override string ToString()
        {
            return base.ToString()+Description;
        }
    }
}
