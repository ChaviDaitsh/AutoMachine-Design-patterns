

namespace AutoMachine
{
    public class Purchase
    {
        public ProductType Product { get; set; }
        public DateTime DateTime { get; set; }
        public int Price { get; set; }
        public int MoneyReceived { get; set; }
        public int Change { get; set; }
        public Purchase(ProductType product, DateTime dateTime, int price, int moneyReceived, int change)
        {
            Product = product;
            DateTime = dateTime;
            Price = price;
            MoneyReceived = moneyReceived;
            Change = change;
        }

        public string ToString()
        {
            return $"DateTime:  {DateTime}  |Product type: {Product}|   Price:  {Price}  |  Money received:  {MoneyReceived}  |  Change:  {Change}";
        }

    }
}
