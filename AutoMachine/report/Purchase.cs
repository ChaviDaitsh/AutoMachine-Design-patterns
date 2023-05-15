

namespace AutoMachine
{
    public class Purchase
    {
        public ProductType Product { get; set; }
        public DateTime DateTime { get; set; }
        public double Price { get; set; }
        public double MoneyReceived { get; set; }
        public double Change { get; set; }

        public string ToString()
        {
            return $"DateTime:  {DateTime}  |Product type: {Product}|   Price:  {Price}  |  Money received:  {MoneyReceived}  |  Change:  {Change}";
        }

    }
}
