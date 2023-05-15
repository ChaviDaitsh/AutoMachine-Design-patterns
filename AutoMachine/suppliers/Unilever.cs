

namespace AutoMachine
{
    internal class Unilever : Supplier
    {
        public Unilever(string name, string phoneNumber) : base(name, phoneNumber)
        {
        }

        public override void OrderAProduct(ProductType productType, int numToOrder)
        {
            //Handles the order
        }
    }
}
