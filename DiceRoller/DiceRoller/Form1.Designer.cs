namespace DiceRoller
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
            label1 = new Label();
            numCounter = new NumericUpDown();
            btnRoll = new Button();
            ((System.ComponentModel.ISupportInitialize)numCounter).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(197, 25);
            label1.TabIndex = 0;
            label1.Text = "Amount of dice to roll: ";
            // 
            // numCounter
            // 
            numCounter.Location = new Point(215, 7);
            numCounter.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numCounter.Name = "numCounter";
            numCounter.Size = new Size(66, 31);
            numCounter.TabIndex = 1;
            // 
            // btnRoll
            // 
            btnRoll.Location = new Point(12, 44);
            btnRoll.Name = "btnRoll";
            btnRoll.Size = new Size(269, 34);
            btnRoll.TabIndex = 2;
            btnRoll.Text = "Roll the dice(s)";
            btnRoll.UseVisualStyleBackColor = true;
            btnRoll.Click += btnRoll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 95);
            Controls.Add(btnRoll);
            Controls.Add(numCounter);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numCounter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numCounter;
        private Button btnRoll;
    }
}