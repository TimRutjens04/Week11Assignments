namespace ListBoxExc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbxUpperCase.Checked) { lbxDisplay.Items.Add(cbxColor.Text.ToUpper()); }
            else { lbxDisplay.Items.Add(cbxColor.Text); }
            if (rbApple.Checked)
            {
                lbxDisplay.Items.Add("Apple");
            }
            else if (rbBanana.Checked)
            {
                lbxDisplay.Items.Add("Banana");
            }
            else if (rbPear.Checked)
            {
                lbxDisplay.Items.Add("Pear");
            }
            else { MessageBox.Show("Please choose a fruit to add."); }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbxDisplay.Items.Clear();
        }
    }
}