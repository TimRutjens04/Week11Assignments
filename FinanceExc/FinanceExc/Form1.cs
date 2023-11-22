using System.Text;

namespace FinanceExc
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            numCheck.Maximum = decimal.MaxValue;
            numExpense.Maximum = decimal.MaxValue;

        }

        public class Item
        {
            public double Cost { get; set; }
            public string Name { get; set; }

            public override string ToString() { return $"{Name} - €{Cost}"; }

        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.Cost = Convert.ToDouble(numExpense.Value);
            item.Name = tbxName.Text;

            lbxCollection.Items.Add(item);
        }

        private void btnShowExpense_Click(object sender, EventArgs e)
        {
            string message = "Items in collection:\n";

            foreach (var item in lbxCollection.Items)
            {
                if (item is Item)
                {
                    message += $"{item}";
                }
            }

            MessageBox.Show(message.ToString());
        }


        private void btnShowSameAmount_Click(object sender, EventArgs e)
        {
            double compareAmount = Convert.ToDouble(numCheck.Value);
            string message = ($"Items with cost {compareAmount}: \n");
            bool findMatchingItems = false;

            foreach (var item in lbxCollection.Items)
            { 
                if (item is Item) 
                {
                    Item currentItem = (Item) item;
                    if (currentItem.Cost == compareAmount) 
                    {
                        message += $"{currentItem}\n";
                        findMatchingItems = true;
                    }
                }
            }
            if (findMatchingItems) { MessageBox.Show(message.ToString()); }
            else { MessageBox.Show($"No items with cost {compareAmount}"); }
        }


    }
}