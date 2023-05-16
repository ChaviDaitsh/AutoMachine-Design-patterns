

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
        public override void PerformCurrentStateActions(Mechine mechine)
        {
            ResetButtons(mechine);
        }

        public override void ResetButtons(Mechine mechine)
        {
            mechine.ProductsLabel.Show();
            mechine.ComboPoducts.Show();
            mechine.BagCheckBox.Show();
            mechine.GiftWrapCheckBox.Show();
            mechine.MoveToPaymentButton.Show();
            mechine.BackButton.Hide();
            mechine.PayNowButton.Hide();
            mechine.InsertMoneyLabel.Hide();
            mechine.MoneyReceivedUpDown.Hide();
            mechine.ChangeLabel.Hide();
            mechine.ProductsOutputLabel.Hide();
            
        }
    }
}
