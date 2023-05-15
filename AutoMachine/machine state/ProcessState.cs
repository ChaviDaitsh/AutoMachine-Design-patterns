namespace AutoMachine
{
    internal class ProcessState : MachineState
    {
        private ProcessState() { }
        private static ProcessState _instance;

        public static ProcessState GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ProcessState();
            }
            return _instance;
        }
        public override void PerformCurrentStateActions(Mechine form)
        {

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
            form.MoneyReceived.Hide();
            form.ChangeLabel.Hide();
            form.ProductsOutputLabel.Show();
        }
    }
}
