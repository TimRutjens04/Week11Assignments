using System.Web;

namespace SnackBar
{
    public partial class Form1 : Form
    {
        private SnackBar snackBar = new SnackBar();
        private double totalRevenue = 0;

        private int stockFrikandel = 0;
        private int stockCheese = 0;
        private int stockMex = 0;

        public Form1()
        {
            InitializeComponent();
            // Initialize stock labels with initial values
            lblStockFrikandelAdmin.Text = $"Amount in stock: {stockFrikandel}";
            lblStockKaasAdmin.Text = $"Amount in stock: {stockCheese}";
            lblStockMexAdmin.Text = $"Amount in stock: {stockMex}";
            lblStockFrikandelCustomer.Text = $"Amount in stock: {stockFrikandel}";
            lblStockKaasCustomer.Text = $"Amount in stock: {stockCheese}";
            lblStockMexCustomer.Text = $"Amount in stock: {stockMex}";
        }


        private void btnAddToStock_Click(object sender, EventArgs e)
        {
            snackBar.McFrikandel.AmountInStock += (int)numStockFrikandelAdmin.Value;
            snackBar.McCheese.AmountInStock += (int)numStockCheeseAdmin.Value;
            snackBar.McMex.AmountInStock += (int)numStockMexAdmin.Value;
            UpdateStockLabels();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            List<string> messages = new List<string>();

            int orderFrikandel = (int)numFrikandel.Value;
            int orderCheese = (int)numCheese.Value;
            int orderMex = (int)numMex.Value;

            // Process orders using the SnackBar class
            messages.Add(ProcessOrder(snackBar.McFrikandel, orderFrikandel));
            messages.Add(ProcessOrder(snackBar.McCheese, orderCheese));
            messages.Add(ProcessOrder(snackBar.McMex, orderMex));

            UpdateStockLabels();

            MessageBox.Show(string.Join(Environment.NewLine, messages));
        }

        private string ProcessOrder(Snack snack, int orderAmount)
        {
            // Check if the order amount is greater than the amount in stock
            if (orderAmount > snack.AmountInStock)
            {
                return $"Not enough {snack.Name} in stock!";
            }
            else
            {
                // Update the stock
                snack.AmountInStock -= orderAmount;

                // Update revenue
                double orderRevenue = orderAmount * snack.Price;
                totalRevenue += orderRevenue;

                // Return a confirmation message
                return $"Order for {orderAmount} {snack.Name} processed!";
            }
        }


        private void UpdateStockLabels()
        {
            // Update stock labels after processing orders
            lblStockFrikandelAdmin.Text = $"Amount in stock: {snackBar.McFrikandel.AmountInStock}";
            lblStockKaasAdmin.Text = $"Amount in stock: {snackBar.McCheese.AmountInStock}";
            lblStockMexAdmin.Text = $"Amount in stock: {snackBar.McMex.AmountInStock}";
            lblStockFrikandelCustomer.Text = $"Amount in stock: {snackBar.McFrikandel.AmountInStock}";
            lblStockKaasCustomer.Text = $"Amount in stock: {snackBar.McCheese.AmountInStock}";
            lblStockMexCustomer.Text = $"Amount in stock: {snackBar.McMex.AmountInStock}";

            numFrikandel.Maximum = snackBar.McFrikandel.AmountInStock;
            numCheese.Maximum = snackBar.McCheese.AmountInStock;
            numMex.Maximum = snackBar.McMex.AmountInStock;
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Total revenue: €{totalRevenue:F2}");
        }
    }
    public class Snack
    {
        public string Name { get; }
        public double Price { get; }
        public int AmountInStock { get; set; }

        public Snack(string name, double price, int stock)
        {
            Name = name;
            Price = price;
            AmountInStock = stock;
        }
    }

    public class SnackBar
    {
        public Snack McFrikandel { get; set; }
        public Snack McCheese { get; set; }
        public Snack McMex { get; set; }

        public SnackBar()
        {
            McFrikandel = new Snack("McFrikandel", 1.99, 0);
            McCheese = new Snack("McCheese", 2.49, 0);
            McMex = new Snack("McMexicano", 2.49, 0);
        }
    }


}