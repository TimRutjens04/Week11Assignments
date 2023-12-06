namespace SnackBar
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
            label2 = new Label();
            label3 = new Label();
            numFrikandel = new NumericUpDown();
            numCheese = new NumericUpDown();
            numMex = new NumericUpDown();
            lblStockFrikandelCustomer = new Label();
            lblStockMexCustomer = new Label();
            lblStockKaasCustomer = new Label();
            btnOrder = new Button();
            TabControl = new TabControl();
            tpCustomer = new TabPage();
            tpAdmin = new TabPage();
            btnAddToStock = new Button();
            label4 = new Label();
            lblStockKaasAdmin = new Label();
            label6 = new Label();
            lblStockMexAdmin = new Label();
            label8 = new Label();
            lblStockFrikandelAdmin = new Label();
            numStockFrikandelAdmin = new NumericUpDown();
            numStockMexAdmin = new NumericUpDown();
            numStockCheeseAdmin = new NumericUpDown();
            btnRevenue = new Button();
            ((System.ComponentModel.ISupportInitialize)numFrikandel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCheese).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMex).BeginInit();
            TabControl.SuspendLayout();
            tpCustomer.SuspendLayout();
            tpAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numStockFrikandelAdmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStockMexAdmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStockCheeseAdmin).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 12);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 0;
            label1.Text = "McFrikandel €1,99";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 62);
            label2.Name = "label2";
            label2.Size = new Size(169, 25);
            label2.TabIndex = 1;
            label2.Text = "McKaassouflé €2,49";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 109);
            label3.Name = "label3";
            label3.Size = new Size(160, 25);
            label3.TabIndex = 2;
            label3.Text = "McMexicano €2,49";
            // 
            // numFrikandel
            // 
            numFrikandel.Location = new Point(188, 10);
            numFrikandel.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numFrikandel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numFrikandel.Name = "numFrikandel";
            numFrikandel.Size = new Size(73, 31);
            numFrikandel.TabIndex = 3;
            numFrikandel.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numCheese
            // 
            numCheese.Location = new Point(188, 60);
            numCheese.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numCheese.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCheese.Name = "numCheese";
            numCheese.Size = new Size(73, 31);
            numCheese.TabIndex = 4;
            numCheese.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numMex
            // 
            numMex.Location = new Point(188, 103);
            numMex.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numMex.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numMex.Name = "numMex";
            numMex.Size = new Size(73, 31);
            numMex.TabIndex = 5;
            numMex.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblStockFrikandelCustomer
            // 
            lblStockFrikandelCustomer.AutoSize = true;
            lblStockFrikandelCustomer.Location = new Point(303, 12);
            lblStockFrikandelCustomer.Name = "lblStockFrikandelCustomer";
            lblStockFrikandelCustomer.Size = new Size(147, 25);
            lblStockFrikandelCustomer.TabIndex = 8;
            lblStockFrikandelCustomer.Text = "Amount in stock:";
            // 
            // lblStockMexCustomer
            // 
            lblStockMexCustomer.AutoSize = true;
            lblStockMexCustomer.Location = new Point(303, 109);
            lblStockMexCustomer.Name = "lblStockMexCustomer";
            lblStockMexCustomer.Size = new Size(147, 25);
            lblStockMexCustomer.TabIndex = 9;
            lblStockMexCustomer.Text = "Amount in stock:";
            // 
            // lblStockKaasCustomer
            // 
            lblStockKaasCustomer.AutoSize = true;
            lblStockKaasCustomer.Location = new Point(303, 60);
            lblStockKaasCustomer.Name = "lblStockKaasCustomer";
            lblStockKaasCustomer.Size = new Size(147, 25);
            lblStockKaasCustomer.TabIndex = 10;
            lblStockKaasCustomer.Text = "Amount in stock:";
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(6, 161);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(484, 34);
            btnOrder.TabIndex = 11;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // TabControl
            // 
            TabControl.Controls.Add(tpCustomer);
            TabControl.Controls.Add(tpAdmin);
            TabControl.Location = new Point(12, 12);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(504, 252);
            TabControl.TabIndex = 12;
            // 
            // tpCustomer
            // 
            tpCustomer.Controls.Add(btnOrder);
            tpCustomer.Controls.Add(label1);
            tpCustomer.Controls.Add(lblStockKaasCustomer);
            tpCustomer.Controls.Add(label2);
            tpCustomer.Controls.Add(lblStockMexCustomer);
            tpCustomer.Controls.Add(label3);
            tpCustomer.Controls.Add(lblStockFrikandelCustomer);
            tpCustomer.Controls.Add(numFrikandel);
            tpCustomer.Controls.Add(numMex);
            tpCustomer.Controls.Add(numCheese);
            tpCustomer.Location = new Point(4, 34);
            tpCustomer.Name = "tpCustomer";
            tpCustomer.Padding = new Padding(3);
            tpCustomer.Size = new Size(496, 214);
            tpCustomer.TabIndex = 0;
            tpCustomer.Text = "Customer";
            tpCustomer.UseVisualStyleBackColor = true;
            // 
            // tpAdmin
            // 
            tpAdmin.Controls.Add(btnAddToStock);
            tpAdmin.Controls.Add(label4);
            tpAdmin.Controls.Add(lblStockKaasAdmin);
            tpAdmin.Controls.Add(label6);
            tpAdmin.Controls.Add(lblStockMexAdmin);
            tpAdmin.Controls.Add(label8);
            tpAdmin.Controls.Add(lblStockFrikandelAdmin);
            tpAdmin.Controls.Add(numStockFrikandelAdmin);
            tpAdmin.Controls.Add(numStockMexAdmin);
            tpAdmin.Controls.Add(numStockCheeseAdmin);
            tpAdmin.Controls.Add(btnRevenue);
            tpAdmin.Location = new Point(4, 34);
            tpAdmin.Name = "tpAdmin";
            tpAdmin.Padding = new Padding(3);
            tpAdmin.Size = new Size(496, 214);
            tpAdmin.TabIndex = 1;
            tpAdmin.Text = "Admin";
            tpAdmin.UseVisualStyleBackColor = true;
            // 
            // btnAddToStock
            // 
            btnAddToStock.Location = new Point(6, 174);
            btnAddToStock.Name = "btnAddToStock";
            btnAddToStock.Size = new Size(366, 34);
            btnAddToStock.TabIndex = 20;
            btnAddToStock.Text = "Add to stock";
            btnAddToStock.UseVisualStyleBackColor = true;
            btnAddToStock.Click += btnAddToStock_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 14);
            label4.Name = "label4";
            label4.Size = new Size(156, 25);
            label4.TabIndex = 11;
            label4.Text = "McFrikandel €1,99";
            // 
            // lblStockKaasAdmin
            // 
            lblStockKaasAdmin.AutoSize = true;
            lblStockKaasAdmin.Location = new Point(303, 62);
            lblStockKaasAdmin.Name = "lblStockKaasAdmin";
            lblStockKaasAdmin.Size = new Size(147, 25);
            lblStockKaasAdmin.TabIndex = 19;
            lblStockKaasAdmin.Text = "Amount in stock:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 64);
            label6.Name = "label6";
            label6.Size = new Size(169, 25);
            label6.TabIndex = 12;
            label6.Text = "McKaassouflé €2,49";
            // 
            // lblStockMexAdmin
            // 
            lblStockMexAdmin.AutoSize = true;
            lblStockMexAdmin.Location = new Point(303, 111);
            lblStockMexAdmin.Name = "lblStockMexAdmin";
            lblStockMexAdmin.Size = new Size(147, 25);
            lblStockMexAdmin.TabIndex = 18;
            lblStockMexAdmin.Text = "Amount in stock:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 111);
            label8.Name = "label8";
            label8.Size = new Size(160, 25);
            label8.TabIndex = 13;
            label8.Text = "McMexicano €2,49";
            // 
            // lblStockFrikandelAdmin
            // 
            lblStockFrikandelAdmin.AutoSize = true;
            lblStockFrikandelAdmin.Location = new Point(303, 14);
            lblStockFrikandelAdmin.Name = "lblStockFrikandelAdmin";
            lblStockFrikandelAdmin.Size = new Size(147, 25);
            lblStockFrikandelAdmin.TabIndex = 17;
            lblStockFrikandelAdmin.Text = "Amount in stock:";
            // 
            // numStockFrikandelAdmin
            // 
            numStockFrikandelAdmin.Location = new Point(188, 12);
            numStockFrikandelAdmin.Name = "numStockFrikandelAdmin";
            numStockFrikandelAdmin.Size = new Size(73, 31);
            numStockFrikandelAdmin.TabIndex = 14;
            // 
            // numStockMexAdmin
            // 
            numStockMexAdmin.Location = new Point(188, 105);
            numStockMexAdmin.Name = "numStockMexAdmin";
            numStockMexAdmin.Size = new Size(73, 31);
            numStockMexAdmin.TabIndex = 16;
            // 
            // numStockCheeseAdmin
            // 
            numStockCheeseAdmin.Location = new Point(188, 62);
            numStockCheeseAdmin.Name = "numStockCheeseAdmin";
            numStockCheeseAdmin.Size = new Size(73, 31);
            numStockCheeseAdmin.TabIndex = 15;
            // 
            // btnRevenue
            // 
            btnRevenue.Location = new Point(378, 174);
            btnRevenue.Name = "btnRevenue";
            btnRevenue.Size = new Size(112, 34);
            btnRevenue.TabIndex = 0;
            btnRevenue.Text = "Revenue";
            btnRevenue.UseVisualStyleBackColor = true;
            btnRevenue.Click += btnRevenue_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 278);
            Controls.Add(TabControl);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numFrikandel).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCheese).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMex).EndInit();
            TabControl.ResumeLayout(false);
            tpCustomer.ResumeLayout(false);
            tpCustomer.PerformLayout();
            tpAdmin.ResumeLayout(false);
            tpAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numStockFrikandelAdmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStockMexAdmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStockCheeseAdmin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numFrikandel;
        private NumericUpDown numCheese;
        private NumericUpDown numMex;
        private Label lblStockFrikandelCustomer;
        private Label lblStockMexCustomer;
        private Label lblStockKaasCustomer;
        private Button btnOrder;
        private TabControl TabControl;
        private TabPage tpCustomer;
        private TabPage tpAdmin;
        private Button btnRevenue;
        private Button btnAddToStock;
        private Label label4;
        private Label lblStockKaasAdmin;
        private Label label6;
        private Label lblStockMexAdmin;
        private Label label8;
        private Label lblStockFrikandelAdmin;
        private NumericUpDown numStockFrikandelAdmin;
        private NumericUpDown numStockMexAdmin;
        private NumericUpDown numStockCheeseAdmin;
    }
}