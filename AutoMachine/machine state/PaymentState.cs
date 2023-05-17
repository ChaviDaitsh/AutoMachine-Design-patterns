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
        public override void PerformCurrentStateActions(Machine machine)
        {
            
            int finalPrice = StateManager.Stock.StockDict[StateManager.ProductType][0].Price;
            if(machine.GiftWrapCheckBox.Checked)
            {
                finalPrice += 2;
            }
            if(machine.MoneyReceivedUpDown.Value < finalPrice)
            {
                machine.InsertMoneyLabel.Text = $"Not enough money please add {finalPrice - machine.MoneyReceivedUpDown.Value}$";
            }
            else
            {
                machine.ChangeLabel.Text = $"Change: {machine.MoneyReceivedUpDown.Value - finalPrice}";
                StateManager.ChangeState(ProcessState.GetInstance(StateManager));
                StateManager.PerformCurrentStateActions(machine);
            }


        }

        public override void ResetButtons(Machine machine)
        {
            machine.ProductsLabel.Hide();
            machine.ComboPoducts.Hide();
            machine.BagCheckBox.Hide();
            machine.GiftWrapCheckBox.Hide();
            machine.MoveToPaymentButton.Hide();
            machine.BackButton.Show();
            int finalPrice = StateManager.Stock.StockDict[StateManager.ProductType][0].Price;
            if (machine.GiftWrapCheckBox.Checked)
            {
                finalPrice += 2;
            }
            machine.InsertMoneyLabel.Text = $"Please insert {finalPrice}$";
            machine.PayNowButton.Show();
            machine.InsertMoneyLabel.Show();
            machine.MoneyReceivedUpDown.Show();
            machine.ChangeLabel.Show();
            machine.ProductsOutputLabel.Hide();
        }
    }
}
