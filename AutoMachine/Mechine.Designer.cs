namespace AutoMachine
{
    partial class Mechine
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.products = new System.Windows.Forms.ComboBox();
            this.productLabel = new System.Windows.Forms.Label();
            this.moveToPayment = new System.Windows.Forms.Button();
            this.payNow = new System.Windows.Forms.Button();
            this.moneyReceived = new System.Windows.Forms.NumericUpDown();
            this.insertMoneyLabel = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.productOutput = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.bagCheckBox = new System.Windows.Forms.CheckBox();
            this.giftWrapCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.moneyReceived)).BeginInit();
            this.SuspendLayout();
            // 
            // products
            // 
            this.products.FormattingEnabled = true;
            this.products.Location = new System.Drawing.Point(43, 104);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(121, 23);
            this.products.TabIndex = 0;
            this.products.SelectedIndexChanged += new System.EventHandler(this.products_SelectedIndexChanged);
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(43, 38);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(101, 15);
            this.productLabel.TabIndex = 1;
            this.productLabel.Text = "Choose a product";
            // 
            // moveToPayment
            // 
            this.moveToPayment.Location = new System.Drawing.Point(43, 215);
            this.moveToPayment.Name = "moveToPayment";
            this.moveToPayment.Size = new System.Drawing.Size(132, 23);
            this.moveToPayment.TabIndex = 2;
            this.moveToPayment.Text = "Move to payment";
            this.moveToPayment.UseVisualStyleBackColor = true;
            this.moveToPayment.Click += new System.EventHandler(this.moveToPayment_Click);
            // 
            // payNow
            // 
            this.payNow.Location = new System.Drawing.Point(319, 206);
            this.payNow.Name = "payNow";
            this.payNow.Size = new System.Drawing.Size(132, 23);
            this.payNow.TabIndex = 3;
            this.payNow.Text = "Pay now";
            this.payNow.UseVisualStyleBackColor = true;
            // 
            // moneyReceived
            // 
            this.moneyReceived.Location = new System.Drawing.Point(331, 142);
            this.moneyReceived.Name = "moneyReceived";
            this.moneyReceived.Size = new System.Drawing.Size(120, 23);
            this.moneyReceived.TabIndex = 4;
            // 
            // insertMoneyLabel
            // 
            this.insertMoneyLabel.AutoSize = true;
            this.insertMoneyLabel.Location = new System.Drawing.Point(349, 83);
            this.insertMoneyLabel.Name = "insertMoneyLabel";
            this.insertMoneyLabel.Size = new System.Drawing.Size(76, 15);
            this.insertMoneyLabel.TabIndex = 5;
            this.insertMoneyLabel.Text = "Insert money";
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Location = new System.Drawing.Point(362, 266);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(54, 15);
            this.changeLabel.TabIndex = 6;
            this.changeLabel.Text = "Change: ";
            // 
            // productOutput
            // 
            this.productOutput.AutoSize = true;
            this.productOutput.Location = new System.Drawing.Point(637, 108);
            this.productOutput.Name = "productOutput";
            this.productOutput.Size = new System.Drawing.Size(0, 15);
            this.productOutput.TabIndex = 7;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(319, 38);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(130, 23);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "Back to selection mode";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // bagCheckBox
            // 
            this.bagCheckBox.AutoSize = true;
            this.bagCheckBox.Location = new System.Drawing.Point(43, 146);
            this.bagCheckBox.Name = "bagCheckBox";
            this.bagCheckBox.Size = new System.Drawing.Size(46, 19);
            this.bagCheckBox.TabIndex = 9;
            this.bagCheckBox.Text = "Bag";
            this.bagCheckBox.UseVisualStyleBackColor = true;
            // 
            // giftWrapCheckBox
            // 
            this.giftWrapCheckBox.AutoSize = true;
            this.giftWrapCheckBox.Location = new System.Drawing.Point(43, 181);
            this.giftWrapCheckBox.Name = "giftWrapCheckBox";
            this.giftWrapCheckBox.Size = new System.Drawing.Size(97, 19);
            this.giftWrapCheckBox.TabIndex = 10;
            this.giftWrapCheckBox.Text = "Gift wrap +2$";
            this.giftWrapCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.giftWrapCheckBox);
            this.Controls.Add(this.bagCheckBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.productOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.insertMoneyLabel);
            this.Controls.Add(this.moneyReceived);
            this.Controls.Add(this.payNow);
            this.Controls.Add(this.moveToPayment);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.products);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.moneyReceived)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox products;
        private Label productLabel;
        private Button moveToPayment;
        private Button payNow;
        private NumericUpDown moneyReceived;
        private Label insertMoneyLabel;
        private Label changeLabel;
        private Label productOutput;
        private Button backButton;
        private CheckBox bagCheckBox;
        private CheckBox giftWrapCheckBox;
    }
}