

namespace AutoMachine
{
    public class SelectionState : MachineState
    {
        private SelectionState(StateManager stateManager)
        {
            StateManager= stateManager;
        }
        private static SelectionState _instance;

        public static SelectionState GetInstance(StateManager stateManager)
        {
            if (_instance == null)
            {
                _instance = new SelectionState(stateManager);
            }
            return _instance;
        }
        public override void PerformCurrentStateActions(Mechine form)
        {
            List<string> productList = new List<string>();
            for (int i = 0; i < StateManager.Stock.StockDict.Count; i++)
            {
                if (StateManager.Stock.StockDict[(ProductType)i].Count > 0)
                {
                    productList.Add((ProductType)i + "  " + StateManager.Stock.StockDict[(ProductType)i][0].Price.ToString());
                }

            }
            form.ComboPoducts.DataSource = productList;
            ResetButtons(form);
        }

        public override void ResetButtons(Mechine form)
        {
            form.ProductsLabel.Show();
            form.ComboPoducts.Show();
            form.BagCheckBox.Show();
            form.GiftWrapCheckBox.Show();
            form.MoveToPaymentButton.Show();
            form.BackButton.Hide();
            form.PayNowButton.Hide();
            form.InsertMoneyLabel.Hide();
            form.MoneyReceivedUpDown.Hide();
            form.ChangeLabel.Hide();
            form.ProductsOutputLabel.Hide();
            
        }
    }
}
