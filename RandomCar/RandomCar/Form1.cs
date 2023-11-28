using System.Security.Cryptography.X509Certificates;
using System;
using System.Windows.Forms;

namespace RandomCar
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (!timer.Enabled)
            {
                timer.Interval = 3; 
                timer.Tick += Timer_Tick;
                timer.Start();
                btnStartStop.Text = "Stop";
            }
            else
            {
                timer.Stop();
                btnStartStop.Text = "Start";
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            MovePictureBoxRandomly();
        }

        private void MovePictureBoxRandomly()
        {
            int newX = random.Next(this.ClientRectangle.Width - pbxCar.Width);
            pbxCar.Location = new System.Drawing.Point(newX, pbxCar.Location.Y);
        }
    }
}