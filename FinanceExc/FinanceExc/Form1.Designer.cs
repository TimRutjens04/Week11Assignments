namespace FinanceExc
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
            numExpense = new NumericUpDown();
            tbxName = new TextBox();
            btnAddExpense = new Button();
            label2 = new Label();
            label1 = new Label();
            lbxCollection = new ListBox();
            btnShowExpense = new Button();
            label3 = new Label();
            btnShowSameAmount = new Button();
            numCheck = new NumericUpDown();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numExpense).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCheck).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numExpense);
            groupBox1.Controls.Add(tbxName);
            groupBox1.Controls.Add(btnAddExpense);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(8, 7);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(210, 107);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Expense form";
            // 
            // numExpense
            // 
            numExpense.DecimalPlaces = 2;
            numExpense.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            numExpense.Location = new Point(66, 37);
            numExpense.Margin = new Padding(2);
            numExpense.Name = "numExpense";
            numExpense.Size = new Size(63, 23);
            numExpense.TabIndex = 5;
            // 
            // tbxName
            // 
            tbxName.BorderStyle = BorderStyle.FixedSingle;
            tbxName.Location = new Point(66, 14);
            tbxName.Margin = new Padding(2);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(131, 23);
            tbxName.TabIndex = 4;
            // 
            // btnAddExpense
            // 
            btnAddExpense.Location = new Point(66, 59);
            btnAddExpense.Margin = new Padding(2);
            btnAddExpense.Name = "btnAddExpense";
            btnAddExpense.Size = new Size(130, 38);
            btnAddExpense.TabIndex = 3;
            btnAddExpense.Text = "Add expense to transaction log";
            btnAddExpense.UseVisualStyleBackColor = true;
            btnAddExpense.Click += btnAddExpense_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 41);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Amount:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "Name: ";
            // 
            // lbxCollection
            // 
            lbxCollection.FormattingEnabled = true;
            lbxCollection.ItemHeight = 15;
            lbxCollection.Items.AddRange(new object[] { "" });
            lbxCollection.Location = new Point(223, 29);
            lbxCollection.Margin = new Padding(2);
            lbxCollection.Name = "lbxCollection";
            lbxCollection.Size = new Size(185, 169);
            lbxCollection.TabIndex = 0;
            // 
            // btnShowExpense
            // 
            btnShowExpense.Location = new Point(8, 118);
            btnShowExpense.Margin = new Padding(2);
            btnShowExpense.Name = "btnShowExpense";
            btnShowExpense.Size = new Size(210, 22);
            btnShowExpense.TabIndex = 4;
            btnShowExpense.Text = "Show all expenses";
            btnShowExpense.UseVisualStyleBackColor = true;
            btnShowExpense.Click += btnShowExpense_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 155);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 4;
            label3.Text = "Amount:";
            // 
            // btnShowSameAmount
            // 
            btnShowSameAmount.Location = new Point(8, 175);
            btnShowSameAmount.Margin = new Padding(2);
            btnShowSameAmount.Name = "btnShowSameAmount";
            btnShowSameAmount.Size = new Size(210, 22);
            btnShowSameAmount.TabIndex = 5;
            btnShowSameAmount.Text = "Show expenses with same amount";
            btnShowSameAmount.UseVisualStyleBackColor = true;
            btnShowSameAmount.Click += btnShowSameAmount_Click;
            // 
            // numCheck
            // 
            numCheck.DecimalPlaces = 2;
            numCheck.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            numCheck.Location = new Point(74, 154);
            numCheck.Margin = new Padding(2);
            numCheck.Name = "numCheck";
            numCheck.Size = new Size(63, 23);
            numCheck.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(270, 12);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 7;
            label4.Text = "Transaction Log";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 206);
            Controls.Add(label4);
            Controls.Add(numCheck);
            Controls.Add(btnShowSameAmount);
            Controls.Add(label3);
            Controls.Add(btnShowExpense);
            Controls.Add(lbxCollection);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numExpense).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCheck).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private ListBox lbxCollection;
        private Button btnAddExpense;
        private Button btnShowExpense;
        private Label label3;
        private Button btnShowSameAmount;
        private NumericUpDown numExpense;
        private TextBox tbxName;
        private NumericUpDown numCheck;
        private Label label4;
    }
}