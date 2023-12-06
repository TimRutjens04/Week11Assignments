namespace Lottery
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            tbxMaxValue = new TextBox();
            tbxAmountOfNumbers = new TextBox();
            btnCreateLottery = new Button();
            btnOneByOne = new Button();
            btnAllAtOnce = new Button();
            lbxCollection = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbxAmountOfNumbers);
            groupBox1.Controls.Add(tbxMaxValue);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(347, 150);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lottery settings";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 45);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 0;
            label1.Text = "Max value:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 87);
            label2.Name = "label2";
            label2.Size = new Size(178, 25);
            label2.TabIndex = 1;
            label2.Text = "Amount of numbers:";
            // 
            // tbxMaxValue
            // 
            tbxMaxValue.Location = new Point(190, 42);
            tbxMaxValue.Name = "tbxMaxValue";
            tbxMaxValue.Size = new Size(150, 31);
            tbxMaxValue.TabIndex = 2;
            // 
            // tbxAmountOfNumbers
            // 
            tbxAmountOfNumbers.Location = new Point(190, 87);
            tbxAmountOfNumbers.Name = "tbxAmountOfNumbers";
            tbxAmountOfNumbers.Size = new Size(150, 31);
            tbxAmountOfNumbers.TabIndex = 3;
            // 
            // btnCreateLottery
            // 
            btnCreateLottery.Location = new Point(18, 168);
            btnCreateLottery.Name = "btnCreateLottery";
            btnCreateLottery.Size = new Size(341, 34);
            btnCreateLottery.TabIndex = 1;
            btnCreateLottery.Text = "Create lottery";
            btnCreateLottery.UseVisualStyleBackColor = true;
            btnCreateLottery.Click += btnCreateLottery_Click;
            // 
            // btnOneByOne
            // 
            btnOneByOne.Location = new Point(18, 208);
            btnOneByOne.Name = "btnOneByOne";
            btnOneByOne.Size = new Size(341, 34);
            btnOneByOne.TabIndex = 2;
            btnOneByOne.Text = "Draw numbers one by one";
            btnOneByOne.UseVisualStyleBackColor = true;
            btnOneByOne.Click += btnOneByOne_Click;
            // 
            // btnAllAtOnce
            // 
            btnAllAtOnce.Location = new Point(18, 248);
            btnAllAtOnce.Name = "btnAllAtOnce";
            btnAllAtOnce.Size = new Size(341, 34);
            btnAllAtOnce.TabIndex = 3;
            btnAllAtOnce.Text = "Draw numbers all at once";
            btnAllAtOnce.UseVisualStyleBackColor = true;
            btnAllAtOnce.Click += btnAllAtOnce_Click;
            // 
            // lbxCollection
            // 
            lbxCollection.FormattingEnabled = true;
            lbxCollection.ItemHeight = 25;
            lbxCollection.Location = new Point(383, 24);
            lbxCollection.Name = "lbxCollection";
            lbxCollection.Size = new Size(316, 429);
            lbxCollection.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 477);
            Controls.Add(lbxCollection);
            Controls.Add(btnAllAtOnce);
            Controls.Add(btnOneByOne);
            Controls.Add(btnCreateLottery);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox tbxAmountOfNumbers;
        private TextBox tbxMaxValue;
        private Button btnCreateLottery;
        private Button btnOneByOne;
        private Button btnAllAtOnce;
        private ListBox lbxCollection;
    }
}