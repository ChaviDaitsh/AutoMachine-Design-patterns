namespace AutoMachine
{
    internal class ProcessState : MachineState
    {
        private ProcessState(StateManager stateManager) 
        {
            StateManager = stateManager;
        }
        private static ProcessState _instance;

        public static ProcessState GetInstance(StateManager stateManager)
        {
            if (_instance == null)
            {
                _instance = new ProcessState(stateManager);
            }
            return _instance;
        }
        public override void PerformCurrentStateActions(Mechine mechine)
        {
            ResetButtons(mechine);
            Product product = StateManager.Stock.GetItem(StateManager.ProductType);
            DrinkMaker drinkMaker = new DrinkMaker();
                switch (StateManager.ProductType)
                {
                    case ProductType.Coffee:
                        Coffee coffee = new Coffee(product);   
                        CoffeeBuilder coffeeBuilder = new CoffeeBuilder(coffee);
                        drinkMaker.MakeCoffee(coffeeBuilder);
                        product = coffeeBuilder.GetResult();
                        break;
                    case ProductType.IceCoffee:
                        IceCoffee iceCoffee = new IceCoffee(product);
                        IceCoffeeBuilder icecoffeeBuilder = new IceCoffeeBuilder(iceCoffee);
                        drinkMaker.MakeIceCoffee(icecoffeeBuilder);
                        product = icecoffeeBuilder.GetResult();
                        break;
                    case ProductType.ChocolateMilk:
                        ChocolateMilk ChocolateMilk = new ChocolateMilk(product);
                        ChocolateMilkBuilder ChocolateMilkBuilder = new ChocolateMilkBuilder(ChocolateMilk);
                        drinkMaker.MakeChocolateMilk(ChocolateMilkBuilder);
                        product = ChocolateMilkBuilder.GetResult();
                        break;
                    case ProductType.IceChocolateMilk:
                        IceChocolateMilk iceChocolateMilk = new IceChocolateMilk(product);
                        IcedChocolateMilkBuilder icedChocolateMilkBuilder = new IcedChocolateMilkBuilder(iceChocolateMilk);
                        drinkMaker.MakeIcedChocolateMilk(icedChocolateMilkBuilder);
                        product = icedChocolateMilkBuilder.GetResult();
                        break;
                    default:
                        break;
                }
            if (mechine.GiftWrapCheckBox.Checked)
            {
                product = new ProductWithGiftWrap(product);
            }
            if (mechine.BagCheckBox.Checked)
            {
                product = new ProductWithBag(product); 
            }
            
            mechine.ProductsOutputLabel.Text = product.ToString();
            Addpurchase(mechine, product);
            mechine.BackButton.Show();
            
        }

        public override void ResetButtons(Mechine mechine)
        {
            mechine.ProductsLabel.Hide();
            mechine.ComboPoducts.Hide();
            mechine.BagCheckBox.Hide();
            mechine.GiftWrapCheckBox.Hide();
            mechine.MoveToPaymentButton.Hide();
            mechine.BackButton.Hide();
            mechine.PayNowButton.Hide();
            mechine.InsertMoneyLabel.Hide();
            mechine.MoneyReceivedUpDown.Hide();
            mechine.ChangeLabel.Show();
            mechine.ProductsOutputLabel.Show();
        }
        private void Addpurchase(Mechine mechine, Product product)
        {
            Purchase purchase = new Purchase(StateManager.ProductType, DateTime.Now, product.Price,
                ((int)(mechine.MoneyReceivedUpDown.Value)),
                ((int)mechine.MoneyReceivedUpDown.Value - product.Price));
            mechine.TodaysPurchase.AddPurchase(purchase);
        }
    }
}
