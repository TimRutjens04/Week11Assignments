namespace DiceRoller
{
    public partial class Form1 : Form
    {
        private List<Result> resultOptions = new List<Result>();
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            int numForms = (int)numCounter.Value;
            for (int i = 0; i < numForms; i++)
            {
                OpenResultsForm();
            }
        }

        private void OpenResultsForm()
        {
            Result resultsForm = new Result();

            int randomDiceValue = random.Next(1, 7);
            string fileLocation = $"Properties/DiceRolling_Images/DiceFace{randomDiceValue}.png";
            resultsForm.DisplayImage(fileLocation);
            resultsForm.Show();
            resultOptions.Add(resultsForm);
        }
    }
}