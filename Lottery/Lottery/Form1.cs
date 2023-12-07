namespace Lottery
{
    public partial class Form1 : Form
    {
        private int nrOfBalls;
        private int maxValue;
        private Lottery lottery;
        private System.Windows.Forms.Timer timer;
        public Form1()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 2000;
            timer.Tick += Timer_Tick;
            btnOneByOne.Enabled = false;
            btnAllAtOnce.Enabled = false;

        }

        private void btnCreateLottery_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbxMaxValue.Text, out maxValue) && int.TryParse(tbxAmountOfNumbers.Text, out nrOfBalls))
            {
                this.lottery = new Lottery(maxValue, nrOfBalls);
                if (lottery.IsValid)
                {
                    btnOneByOne.Enabled = true;
                    btnAllAtOnce.Enabled = true;
                    btnCreateLottery.Enabled = false;
                }
                else { MessageBox.Show("Trying this just throws away the whole idea of randomness."); }
            }
            else { MessageBox.Show("Please enter a valid integer."); }
        }

        private void btnOneByOne_Click(object sender, EventArgs e)
        {
            btnOneByOne.Enabled = false;
            btnAllAtOnce.Enabled = false;
            if (lottery != null)
            {
                timer.Start();
            }
        }

        private void btnAllAtOnce_Click(object sender, EventArgs e)
        {
            btnAllAtOnce.Enabled = false;
            btnOneByOne.Enabled = false;
            if (lottery != null)
            {
                DisplayAllNumbers();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (lottery != null)
            {
                int drawnNumber = lottery.DrawNextNumber();
                if (drawnNumber != -1)
                {
                    lbxCollection.Items.Add($"Drawn number: {drawnNumber}");
                }
                else { timer.Stop(); }
            }
            else { timer.Stop(); }
        }

        private void DisplayAllNumbers()
        {
            if (lottery != null)
            {
                int[] allNumbers = lottery.DrawAllNumbers();
                foreach (int number in allNumbers)
                {
                    lbxCollection.Items.Add($"Drawn number: {number}");
                }
            }
            else { MessageBox.Show("Error"); }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            lbxCollection.Items.Clear();
            btnCreateLottery.Enabled = true;
            btnAllAtOnce.Enabled = false;
            btnOneByOne.Enabled = false;
        }
    }
}