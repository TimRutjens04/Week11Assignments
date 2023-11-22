namespace FinanceExc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Items 
        {
            //items need a name, an amount. for methods they need to be able to be added to the lbx, and checked based on amount
            string name = "";
            decimal cost = 0;

            public decimal Cost { get { return cost; } }

            public void AddExpense()
            {
            
            }
        }
    }
}