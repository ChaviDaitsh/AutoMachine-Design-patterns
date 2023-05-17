using System.Timers;
using Timer = System.Timers.Timer;


namespace AutoMachine
{
    public partial class Machine : Form
    {
        public Stock Stock { get; set; }
        public TodaysPurchase TodaysPurchase { get; set; }
        public StateManager StateManager { get; set; }
        public Label ProductsLabel { get; set; }
        public ComboBox ComboPoducts { get; set; }
        public CheckBox BagCheckBox { get; set; }
        public CheckBox GiftWrapCheckBox { get; set; }
        public Button MoveToPaymentButton { get; set; }
        public Button BackButton { get; set; }
        public Button PayNowButton { get; set; }
        public Label InsertMoneyLabel { get; set; }
        public NumericUpDown MoneyReceivedUpDown { get; set; }
        public Label ChangeLabel { get; set; }
        public Label ProductsOutputLabel { get; set; }
        private readonly Timer m_Timer;
        public Report ThisDayReport { get; set; }

        public Machine(Stock stock)
        {
            InitializeComponent();
            m_Timer = new Timer();
            m_Timer.Enabled = true;
            m_Timer.Interval = (10000 * 60);
            m_Timer.Elapsed += ReportMaker;
            m_Timer.Start();
            this.Stock = stock;
            this.TodaysPurchase = new TodaysPurchase();
            this.StateManager = new StateManager(SelectionState.GetInstance(StateManager), stock);
            this.ProductsLabel = productLabel;
            this.ComboPoducts = products;
            this.BagCheckBox = bagCheckBox;
            this.GiftWrapCheckBox = giftWrapCheckBox;
            this.MoveToPaymentButton = moveToPayment;
            this.BackButton = backButton;
            this.PayNowButton = payNow;
            this.InsertMoneyLabel = insertMoneyLabel;
            this.MoneyReceivedUpDown = moneyReceived;
            this.ChangeLabel = changeLabel;
            this.ProductsOutputLabel = productOutput;
            this.StateManager.PerformCurrentStateActions(this);
        }

        private void products_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void moveToPayment_Click(object sender, EventArgs e)
        {
            if (Stock.StockDict[(ProductType)ComboPoducts.SelectedIndex].Count > 0)
            {
                
                StateManager.ProductType = (ProductType)ComboPoducts.SelectedIndex;
                StateManager.ChangeState(PaymentState.GetInstance(StateManager));
                StateManager.ResetButtons(this);
            }
            else
            {
                ProductsLabel.Text = "This product is out of stock";
            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ProductsLabel.Text = "Please choose a product";
            StateManager.ChangeState(SelectionState.GetInstance(StateManager));
            StateManager.ResetButtons(this);
        }

        private void payNow_Click(object sender, EventArgs e)
        {
            if (Stock.StockDict[StateManager.ProductType] != null) { }
                StateManager.PerformCurrentStateActions(this);
        }
        private void ReportMaker(object sender, ElapsedEventArgs args)
        {
            if (DateTime.Now.Hour == 0)
            {
                ThisDayReport = new TextReport(TodaysPurchase);
                ThisDayReport.WriteReport();
                TodaysPurchase = new TodaysPurchase();
            }
        }
    }
}