

namespace AutoMachine
{
    public partial class Mechine : Form
    {
        public Stock Stock { get; set; }
        public StateManager StateManager { get; set; }
        public Label ProductsLabel { get; set; }
        public ComboBox ComboPoducts { get; set; }
        public CheckBox BagCheckBox { get; set; }
        public CheckBox GiftWrapCheckBox { get; set; }

        public Button MoveToPaymentButton { get; set; }
        public Button BackButton { get; set; }
        public Button PayNowButton { get; set; }
        public Label InsertMoneyLabel { get; set; }
        public NumericUpDown MoneyReceived { get; set; }
        public Label ChangeLabel { get; set; }
        public Label ProductsOutputLabel { get; set; }



        public Mechine(Stock stock)
        {
            InitializeComponent();
            
            this.Stock = stock;
            this.StateManager = new StateManager(SelectionState.GetInstance(), stock);
            List<string> productList = new List<string>();
            for (int i = 0; i < stock.StockDict.Count; i++)
            {
                productList.Add((ProductType)i+"  "+stock.StockDict[(ProductType)i][0].Price.ToString());
            }
            products.DataSource = productList;
            this.ProductsLabel = productLabel;
            this.ComboPoducts = products;
            this.BagCheckBox = bagCheckBox;
            this.GiftWrapCheckBox = giftWrapCheckBox;
            this.MoveToPaymentButton = moveToPayment;
            this.BackButton = backButton;
            this.PayNowButton = payNow;
            this.InsertMoneyLabel = insertMoneyLabel;
            this.MoneyReceived = moneyReceived;
            this.ChangeLabel = changeLabel;
            this.ProductsOutputLabel = productOutput;
            

            this.StateManager.PerformCurrentStateActions(this);


        }

        private void products_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void moveToPayment_Click(object sender, EventArgs e)
        {
            StateManager.ProductType = (ProductType)ComboPoducts.SelectedIndex;
            StateManager.ChangeState(PaymentState.GetInstance());
            StateManager.ResetButtons(this);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            StateManager.ChangeState(SelectionState.GetInstance());
            StateManager.ResetButtons(this);
        }
    }
}