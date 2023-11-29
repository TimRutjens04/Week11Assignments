using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRoller
{
    public partial class Result : Form
    {
        Random random = new Random();

        public Result()
        {
            InitializeComponent();
        }
        public void DisplayImage(string fileLocation)
        {
            PictureBox pictureBox = new PictureBox
            {
                ImageLocation = fileLocation,
                Dock = DockStyle.Fill,
            };

            Controls.Add(pictureBox);
        }
    }
}
