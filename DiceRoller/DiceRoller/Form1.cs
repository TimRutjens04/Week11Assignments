namespace DiceRoller
{
    public partial class Form1 : Form
    {
        private List<Form> formOptions = new List<Form>();
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            formOptions.Add(new dice1());
            formOptions.Add(new dice2());
            formOptions.Add(new dice3());
            formOptions.Add(new dice4());
            formOptions.Add(new dice5());
            formOptions.Add(new dice6());
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            if (numCounter.Value > 0)
            {
                ThrowRandomDice((int)numCounter.Value);
            }
            else { MessageBox.Show("C'mon man you can't throw 0 dice you know."); }
        }

        private void ThrowRandomDice(int numberOfDice)
        {
            for (int i = 0; i < numberOfDice; i++) 
            {
                Form randomDice = formOptions[random.Next(formOptions.Count)];
                randomDice.Show();
            }
        }
    }
}