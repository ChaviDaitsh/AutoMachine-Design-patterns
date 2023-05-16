namespace AutoMachine
{
    internal class PaymentState : MachineState
    {
        private PaymentState(StateManager stateManager) 
        {
            StateManager= stateManager;
        }
        private static PaymentState _instance;

        public static PaymentState GetInstance(StateManager stateManager)
        {
            if (_instance == null)
            {
                _instance = new PaymentState(stateManager);
            }
            return _instance;
        }
        public override void PerformCurrentStateActions(Mechine mechine)
        {
            
            int finalPrice = StateManager.Stock.StockDict[StateManager.ProductType][0].Price;
            if(mechine.GiftWrapCheckBox.Checked)
            {
                finalPrice += 2;
            }
            if(mechine.MoneyReceivedUpDown.Value < finalPrice)
            {
                mechine.InsertMoneyLabel.Text = $"Not enough money please add {finalPrice - mechine.MoneyReceivedUpDown.Value}$";
            }
            else
            {
                mechine.ChangeLabel.Text = $"Change: {mechine.MoneyReceivedUpDown.Value - finalPrice}";
                StateManager.ChangeState(ProcessState.GetInstance(StateManager));
                StateManager.PerformCurrentStateActions(mechine);
            }


        }

        public override void ResetButtons(Mechine mechine)
        {
            mechine.ProductsLabel.Hide();
            mechine.ComboPoducts.Hide();
            mechine.BagCheckBox.Hide();
            mechine.GiftWrapCheckBox.Hide();
            mechine.MoveToPaymentButton.Hide();
            mechine.BackButton.Show();
            int finalPrice = StateManager.Stock.StockDict[StateManager.ProductType][0].Price;
            if (mechine.GiftWrapCheckBox.Checked)
            {
                finalPrice += 2;
            }
            mechine.InsertMoneyLabel.Text = $"Please insert {finalPrice}$";
            mechine.PayNowButton.Show();
            mechine.InsertMoneyLabel.Show();
            mechine.MoneyReceivedUpDown.Show();
            mechine.ChangeLabel.Show();
            mechine.ProductsOutputLabel.Hide();
        }
    }
}
