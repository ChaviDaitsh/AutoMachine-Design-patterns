

namespace AutoMachine
{
    public class SelectionState : MachineState
    {
        private static SelectionState _instance;
        private SelectionState(StateManager stateManager)
        {
            StateManager= stateManager;
        }
        

        public static SelectionState GetInstance(StateManager stateManager)
        {
            if (_instance == null)
            {
                _instance = new SelectionState(stateManager);
            }
            return _instance;
        }
        public override void PerformCurrentStateActions(Machine machine)
        {
            ResetButtons(machine);
        }

        public override void ResetButtons(Machine machine)
        {
            machine.ProductsLabel.Show();
            List<string> productList = new List<string>();
            for (int i = 0; i < machine.Stock.StockDict.Count; i++)
            {
                if (machine.Stock.StockDict[(ProductType)i].Count > 0)
                {
                    productList.Add((ProductType)i + "  " + machine.Stock.StockDict[(ProductType)i][0].Price.ToString());
                }
                else
                {
                    productList.Add((ProductType)i + " out of stock  ");
                }

            }
            machine.ComboPoducts.DataSource = productList;
            machine.ComboPoducts.Show();
            machine.BagCheckBox.Show();
            machine.GiftWrapCheckBox.Show();
            machine.MoveToPaymentButton.Show();
            machine.BackButton.Hide();
            machine.PayNowButton.Hide();
            machine.InsertMoneyLabel.Hide();
            machine.MoneyReceivedUpDown.Hide();
            machine.ChangeLabel.Hide();
            machine.ProductsOutputLabel.Hide();
            
        }
    }
}
