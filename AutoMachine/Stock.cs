namespace AutoMachine
{
    public class Stock
    {
        private const int NUMTOORDER = 10;
        public Dictionary<ProductType, List<Product>> StockDict { get; set; }
        public Dictionary<ProductType, Supplier> StockSuppliers { get; set; }
        public Stock(Dictionary<ProductType, List<Product>> stockDict, Dictionary<ProductType, Supplier> stockSuppliers)
        {
            StockDict = stockDict;
            StockSuppliers = stockSuppliers;
        }

        public Product GetItem(ProductType productType)
        {
            Product product = null;
            if (StockDict.ContainsKey(productType))
            {
                if (StockDict[productType].Count > 0)
                {
                    product = StockDict[productType][0];
                    StockDict[productType].RemoveAt(0);
                }
                if (StockDict[productType].Count == 5)
                {
                    UpdateSupplier(productType, NUMTOORDER);
                }
            }
            return product;
        }

        private void UpdateSupplier(ProductType productType, int numToOrder)
        {
            StockSuppliers[productType].OrderAProduct(productType, numToOrder);
        }
    }
}
