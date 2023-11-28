namespace RandomCar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnStartStop = new Button();
            pbxCar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbxCar).BeginInit();
            SuspendLayout();
            // 
            // btnStartStop
            // 
            btnStartStop.Location = new Point(12, 72);
            btnStartStop.Name = "btnStartStop";
            btnStartStop.Size = new Size(776, 34);
            btnStartStop.TabIndex = 0;
            btnStartStop.Text = "Start";
            btnStartStop.UseVisualStyleBackColor = true;
            btnStartStop.Click += btnStartStop_Click;
            // 
            // pbxCar
            // 
            pbxCar.BackColor = SystemColors.ControlLightLight;
            pbxCar.Image = (Image)resources.GetObject("pbxCar.Image");
            pbxCar.Location = new Point(12, 12);
            pbxCar.Name = "pbxCar";
            pbxCar.Size = new Size(150, 54);
            pbxCar.SizeMode = PictureBoxSizeMode.Zoom;
            pbxCar.TabIndex = 1;
            pbxCar.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 118);
            Controls.Add(pbxCar);
            Controls.Add(btnStartStop);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbxCar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnStartStop;
        private PictureBox pbxCar;
    }
}