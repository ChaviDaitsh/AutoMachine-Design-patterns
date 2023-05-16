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
        public override void PerformCurrentStateActions(Mechine form)
        {
            ResetButtons(form);
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
            if (form.GiftWrapCheckBox.Checked)
            {
                product = new ProductWithGiftWrap(product);
            }
            if (form.BagCheckBox.Checked)
            {
                product = new ProductWithBag(product); 
            }
            
            form.ProductsOutputLabel.Text = product.ToString();
            
        }

        public override void ResetButtons(Mechine form)
        {
            form.ProductsLabel.Hide();
            form.ComboPoducts.Hide();
            form.BagCheckBox.Hide();
            form.GiftWrapCheckBox.Hide();
            form.MoveToPaymentButton.Hide();
            form.BackButton.Hide();
            form.PayNowButton.Hide();
            form.InsertMoneyLabel.Hide();
            form.MoneyReceivedUpDown.Hide();
            form.ChangeLabel.Show();
            form.ProductsOutputLabel.Show();
        }
    }
}
