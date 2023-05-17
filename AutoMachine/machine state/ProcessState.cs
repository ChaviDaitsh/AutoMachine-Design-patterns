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
        public override void PerformCurrentStateActions(Machine machine)
        {
            ResetButtons(machine);
            Product product = StateManager.Stock.GetItem(StateManager.ProductType);
            DrinkMaker drinkMaker = new DrinkMaker();
                switch (StateManager.ProductType)
                {
                    case ProductType.Coffee:
                        Coffee coffee = new Coffee(product);   
                        CoffeeBuilder coffeeBuilder = new CoffeeBuilder(coffee);
                        drinkMaker.MakeDrink(coffeeBuilder);
                        product = coffeeBuilder.GetResult();
                        break;
                    case ProductType.IceCoffee:
                        IceCoffee iceCoffee = new IceCoffee(product);
                        IceCoffeeBuilder icecoffeeBuilder = new IceCoffeeBuilder(iceCoffee);
                        drinkMaker.MakeDrink(icecoffeeBuilder);
                        product = icecoffeeBuilder.GetResult();
                        break;
                    case ProductType.ChocolateMilk:
                        ChocolateMilk ChocolateMilk = new ChocolateMilk(product);
                        ChocolateMilkBuilder ChocolateMilkBuilder = new ChocolateMilkBuilder(ChocolateMilk);
                        drinkMaker.MakeDrink(ChocolateMilkBuilder);
                        product = ChocolateMilkBuilder.GetResult();
                        break;
                    case ProductType.IceChocolateMilk:
                        IceChocolateMilk iceChocolateMilk = new IceChocolateMilk(product);
                        IcedChocolateMilkBuilder icedChocolateMilkBuilder = new IcedChocolateMilkBuilder(iceChocolateMilk);
                        drinkMaker.MakeDrink(icedChocolateMilkBuilder);
                        product = icedChocolateMilkBuilder.GetResult();
                        break;
                    default:
                        break;
                }
            if (machine.GiftWrapCheckBox.Checked)
            {
                product = new ProductWithGiftWrap(product);
            }
            if (machine.BagCheckBox.Checked)
            {
                product = new ProductWithBag(product); 
            }
            
            machine.ProductsOutputLabel.Text = product.ToString();
            Addpurchase(machine, product);
            machine.BackButton.Show();
            
        }

        public override void ResetButtons(Machine machine)
        {
            machine.ProductsLabel.Hide();
            machine.ComboPoducts.Hide();
            machine.BagCheckBox.Hide();
            machine.GiftWrapCheckBox.Hide();
            machine.MoveToPaymentButton.Hide();
            machine.BackButton.Hide();
            machine.PayNowButton.Hide();
            machine.InsertMoneyLabel.Hide();
            machine.MoneyReceivedUpDown.Hide();
            machine.ChangeLabel.Show();
            machine.ProductsOutputLabel.Show();
        }
        private void Addpurchase(Machine machine, Product product)
        {
            Purchase purchase = new Purchase(StateManager.ProductType, DateTime.Now, product.Price,
                ((int)(machine.MoneyReceivedUpDown.Value)),
                ((int)machine.MoneyReceivedUpDown.Value - product.Price));
            machine.TodaysPurchase.AddPurchase(purchase);
        }
    }
}
