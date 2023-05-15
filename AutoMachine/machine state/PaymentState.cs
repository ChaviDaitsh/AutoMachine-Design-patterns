namespace AutoMachine
{
    internal class PaymentState : MachineState
    {
        private PaymentState() { }
        private static PaymentState _instance;

        public static PaymentState GetInstance()
        {
            if (_instance == null)
            {
                _instance = new PaymentState();
            }
            return _instance;
        }
        public override void PerformCurrentStateActions(Mechine form)
        {
            ResetButtons(form);
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
            form.MoneyReceived.Show();
            form.ChangeLabel.Show();
            form.ProductsOutputLabel.Hide();
        }
    }
}
