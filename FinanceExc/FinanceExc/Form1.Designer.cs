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
            label1 = new Label();
            label2 = new Label();
            lbxCollection = new ListBox();
            btnAddExpense = new Button();
            btnShowExpense = new Button();
            label3 = new Label();
            btnShowSameAmount = new Button();
            tbxName = new TextBox();
            numExpense = new NumericUpDown();
            numCheck = new NumericUpDown();
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
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 179);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Expense form";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 27);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 1;
            label1.Text = "Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 68);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 2;
            label2.Text = "Amount:";
            // 
            // lbxCollection
            // 
            lbxCollection.FormattingEnabled = true;
            lbxCollection.ItemHeight = 25;
            lbxCollection.Items.AddRange(new object[] { "" });
            lbxCollection.Location = new Point(318, 24);
            lbxCollection.Name = "lbxCollection";
            lbxCollection.Size = new Size(263, 304);
            lbxCollection.TabIndex = 1;
            // 
            // btnAddExpense
            // 
            btnAddExpense.Location = new Point(94, 98);
            btnAddExpense.Name = "btnAddExpense";
            btnAddExpense.Size = new Size(186, 64);
            btnAddExpense.TabIndex = 3;
            btnAddExpense.Text = "Add expense to transaction log";
            btnAddExpense.UseVisualStyleBackColor = true;
            // 
            // btnShowExpense
            // 
            btnShowExpense.Location = new Point(12, 197);
            btnShowExpense.Name = "btnShowExpense";
            btnShowExpense.Size = new Size(300, 36);
            btnShowExpense.TabIndex = 4;
            btnShowExpense.Text = "Show all expenses";
            btnShowExpense.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 258);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 4;
            label3.Text = "Amount:";
            // 
            // btnShowSameAmount
            // 
            btnShowSameAmount.Location = new Point(12, 292);
            btnShowSameAmount.Name = "btnShowSameAmount";
            btnShowSameAmount.Size = new Size(300, 36);
            btnShowSameAmount.TabIndex = 5;
            btnShowSameAmount.Text = "Show expenses with same amount";
            btnShowSameAmount.UseVisualStyleBackColor = true;
            // 
            // tbxName
            // 
            tbxName.BorderStyle = BorderStyle.FixedSingle;
            tbxName.Location = new Point(94, 24);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(186, 31);
            tbxName.TabIndex = 4;
            // 
            // numExpense
            // 
            numExpense.Location = new Point(94, 62);
            numExpense.Name = "numExpense";
            numExpense.Size = new Size(90, 31);
            numExpense.TabIndex = 5;
            // 
            // numCheck
            // 
            numCheck.Location = new Point(106, 256);
            numCheck.Name = "numCheck";
            numCheck.Size = new Size(90, 31);
            numCheck.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 357);
            Controls.Add(numCheck);
            Controls.Add(btnShowSameAmount);
            Controls.Add(label3);
            Controls.Add(btnShowExpense);
            Controls.Add(lbxCollection);
            Controls.Add(groupBox1);
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
    }
}