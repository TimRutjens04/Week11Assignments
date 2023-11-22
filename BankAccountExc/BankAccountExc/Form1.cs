namespace BankAccountExc
{
    public partial class Form1 : Form
    {
        BankAccount spendingsAccount = new BankAccount();
        BankAccount savingsAccount = new BankAccount();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (rbSaving.Checked)
            {
                double amount = double.Parse(tbxEurosAmount.Text);
                double balance = Convert.ToDouble(lblSavingsBalance.Text);
                savingsAccount.Deposit(amount);
                lblSavingsBalance.Text = (balance + amount).ToString();
            }
            else if (rbSpending.Checked)
            {
                double amount = double.Parse(tbxEurosAmount.Text);
                double balance = Convert.ToDouble(lblSpendingBalance.Text);
                spendingsAccount.Deposit(amount);
                lblSpendingBalance.Text = (balance + amount).ToString();
            }
            else { MessageBox.Show("Please select an account."); }


        }


        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            double amount = double.Parse(tbxEurosAmount.Text);
            if (rbSaving.Checked)
            {
                double balance = Convert.ToDouble(lblSavingsBalance.Text);
                if (balance < amount)
                {
                    MessageBox.Show("Your balance is too low to withdraw this amount.");
                    balance = balance;
                }
                else
                {
                    savingsAccount.Withdraw(amount);
                    lblSavingsBalance.Text = (balance - amount).ToString();
                }

            }
            else if (rbSpending.Checked)
            {
                double balance = Convert.ToDouble(lblSpendingBalance.Text);
                if (balance < amount)
                {
                    MessageBox.Show("Your balance is too low to withdraw this amount.");
                    balance = balance;
                }
                else
                {
                    spendingsAccount.Withdraw(amount);
                    lblSpendingBalance.Text = (balance - amount).ToString();
                }

            }

            else { MessageBox.Show("Please select an account."); }

        }
    }
}