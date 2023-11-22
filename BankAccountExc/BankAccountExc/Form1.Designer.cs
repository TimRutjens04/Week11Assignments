namespace BankAccountExc
{
    partial class Form1
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
            label1 = new Label();
            lblSpendingBalance = new Label();
            label3 = new Label();
            lblSavingsBalance = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            btnWithdraw = new Button();
            btnDeposit = new Button();
            tbxEurosAmount = new TextBox();
            rbSaving = new RadioButton();
            rbSpending = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(41, 27);
            label1.Name = "label1";
            label1.Size = new Size(258, 25);
            label1.TabIndex = 0;
            label1.Text = "Spendings account balance:";
            // 
            // lblSpendingBalance
            // 
            lblSpendingBalance.AutoSize = true;
            lblSpendingBalance.Location = new Point(299, 27);
            lblSpendingBalance.Name = "lblSpendingBalance";
            lblSpendingBalance.Size = new Size(22, 25);
            lblSpendingBalance.TabIndex = 1;
            lblSpendingBalance.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(41, 63);
            label3.Name = "label3";
            label3.Size = new Size(234, 25);
            label3.TabIndex = 2;
            label3.Text = "Savings account balance:";
            // 
            // lblSavingsBalance
            // 
            lblSavingsBalance.AutoSize = true;
            lblSavingsBalance.Location = new Point(299, 63);
            lblSavingsBalance.Name = "lblSavingsBalance";
            lblSavingsBalance.Size = new Size(22, 25);
            lblSavingsBalance.TabIndex = 3;
            lblSavingsBalance.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(29, 27);
            label5.Name = "label5";
            label5.Size = new Size(259, 25);
            label5.TabIndex = 4;
            label5.Text = "Please select the bank account:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(29, 122);
            label6.Name = "label6";
            label6.Size = new Size(149, 25);
            label6.TabIndex = 5;
            label6.Text = "Amount in euros:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnWithdraw);
            groupBox1.Controls.Add(btnDeposit);
            groupBox1.Controls.Add(tbxEurosAmount);
            groupBox1.Controls.Add(rbSaving);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(rbSpending);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(41, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(325, 258);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Actions";
            // 
            // btnWithdraw
            // 
            btnWithdraw.Cursor = Cursors.Hand;
            btnWithdraw.Location = new Point(176, 207);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(112, 34);
            btnWithdraw.TabIndex = 13;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnDeposit
            // 
            btnDeposit.Cursor = Cursors.Hand;
            btnDeposit.Location = new Point(29, 207);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(112, 34);
            btnDeposit.TabIndex = 10;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // tbxEurosAmount
            // 
            tbxEurosAmount.Location = new Point(29, 152);
            tbxEurosAmount.Name = "tbxEurosAmount";
            tbxEurosAmount.Size = new Size(259, 31);
            tbxEurosAmount.TabIndex = 12;
            // 
            // rbSaving
            // 
            rbSaving.AutoSize = true;
            rbSaving.Cursor = Cursors.Hand;
            rbSaving.Location = new Point(29, 90);
            rbSaving.Name = "rbSaving";
            rbSaving.Size = new Size(165, 29);
            rbSaving.TabIndex = 11;
            rbSaving.TabStop = true;
            rbSaving.Text = "Savings account";
            rbSaving.UseVisualStyleBackColor = true;
            // 
            // rbSpending
            // 
            rbSpending.AutoSize = true;
            rbSpending.Cursor = Cursors.Hand;
            rbSpending.Location = new Point(29, 55);
            rbSpending.Name = "rbSpending";
            rbSpending.Size = new Size(188, 29);
            rbSpending.TabIndex = 10;
            rbSpending.TabStop = true;
            rbSpending.Text = "Spendings account";
            rbSpending.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 386);
            Controls.Add(groupBox1);
            Controls.Add(lblSavingsBalance);
            Controls.Add(label3);
            Controls.Add(lblSpendingBalance);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblSpendingBalance;
        private Label label3;
        private Label lblSavingsBalance;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private RadioButton rbSaving;
        private RadioButton rbSpending;
        private Button btnWithdraw;
        private Button btnDeposit;
        private TextBox tbxEurosAmount;
    }
}