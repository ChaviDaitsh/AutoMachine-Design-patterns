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
        public override void PerformCurrentStateActions(Mechine form)
        {
            
            int finalPrice = StateManager.Stock.StockDict[StateManager.ProductType][0].Price;
            if(form.GiftWrapCheckBox.Checked)
            {
                finalPrice += 2;
            }
            if(form.MoneyReceivedUpDown.Value < finalPrice)
            {
                form.InsertMoneyLabel.Text = $"Not enough money please add {finalPrice - form.MoneyReceivedUpDown.Value}$";
            }
            else
            {
                form.ChangeLabel.Text = $"Change: {form.MoneyReceivedUpDown.Value - finalPrice}";
                StateManager.ChangeState(ProcessState.GetInstance(StateManager));
                StateManager.PerformCurrentStateActions(form);
            }


        }

        public override void ResetButtons(Mechine form)
        {
            form.ProductsLabel.Hide();
            form.ComboPoducts.Hide();
            form.BagCheckBox.Hide();
            form.GiftWrapCheckBox.Hide();
            form.MoveToPaymentButton.Hide();
            form.BackButton.Show();
            form.PayNowButton.Show();
            form.InsertMoneyLabel.Show();
            form.MoneyReceivedUpDown.Show();
            form.ChangeLabel.Show();
            form.ProductsOutputLabel.Hide();
        }
    }
}
