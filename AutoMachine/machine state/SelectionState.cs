

namespace AutoMachine
{
    public class SelectionState : MachineState
    {
        private SelectionState() { }
        private static SelectionState _instance;

        public static SelectionState GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SelectionState();
            }
            return _instance;
        }
        public override void PerformCurrentStateActions(Mechine form)
        {
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
            form.MoneyReceived.Hide();
            form.ChangeLabel.Hide();
            form.ProductsOutputLabel.Hide();
            
        }
    }
}
