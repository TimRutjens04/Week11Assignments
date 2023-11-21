namespace ListBoxExc
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
            rbApple = new RadioButton();
            rbBanana = new RadioButton();
            rbPear = new RadioButton();
            lblFruit = new Label();
            lbxDisplay = new ListBox();
            cbxColor = new ComboBox();
            label1 = new Label();
            cbxUpperCase = new CheckBox();
            btnAdd = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // rbApple
            // 
            rbApple.AutoSize = true;
            rbApple.Location = new Point(129, 89);
            rbApple.Name = "rbApple";
            rbApple.Size = new Size(84, 29);
            rbApple.TabIndex = 0;
            rbApple.TabStop = true;
            rbApple.Text = "Apple";
            rbApple.UseVisualStyleBackColor = true;
            // 
            // rbBanana
            // 
            rbBanana.AutoSize = true;
            rbBanana.Location = new Point(219, 89);
            rbBanana.Name = "rbBanana";
            rbBanana.Size = new Size(94, 29);
            rbBanana.TabIndex = 1;
            rbBanana.TabStop = true;
            rbBanana.Text = "Banana";
            rbBanana.UseVisualStyleBackColor = true;
            // 
            // rbPear
            // 
            rbPear.AutoSize = true;
            rbPear.Location = new Point(319, 89);
            rbPear.Name = "rbPear";
            rbPear.Size = new Size(70, 29);
            rbPear.TabIndex = 2;
            rbPear.TabStop = true;
            rbPear.Text = "Pear";
            rbPear.UseVisualStyleBackColor = true;
            // 
            // lblFruit
            // 
            lblFruit.AutoSize = true;
            lblFruit.Location = new Point(174, 61);
            lblFruit.Name = "lblFruit";
            lblFruit.Size = new Size(167, 25);
            lblFruit.TabIndex = 3;
            lblFruit.Text = "Select a fruit to add";
            // 
            // lbxDisplay
            // 
            lbxDisplay.BackColor = Color.Azure;
            lbxDisplay.FormattingEnabled = true;
            lbxDisplay.ItemHeight = 25;
            lbxDisplay.Location = new Point(564, 15);
            lbxDisplay.Name = "lbxDisplay";
            lbxDisplay.Size = new Size(224, 229);
            lbxDisplay.TabIndex = 4;
            // 
            // cbxColor
            // 
            cbxColor.FormattingEnabled = true;
            cbxColor.Items.AddRange(new object[] { "green", "blue", "red", "yellow", "black", "white" });
            cbxColor.Location = new Point(164, 12);
            cbxColor.Name = "cbxColor";
            cbxColor.Size = new Size(182, 33);
            cbxColor.TabIndex = 5;
            cbxColor.Text = "green";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 6;
            label1.Text = "Choose a color";
            // 
            // cbxUpperCase
            // 
            cbxUpperCase.AutoSize = true;
            cbxUpperCase.Location = new Point(352, 16);
            cbxUpperCase.Name = "cbxUpperCase";
            cbxUpperCase.Size = new Size(155, 29);
            cbxUpperCase.TabIndex = 7;
            cbxUpperCase.Text = "To UPPERCASE";
            cbxUpperCase.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(129, 146);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(260, 34);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add to listbox";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(564, 276);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(224, 34);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear listbox";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(cbxUpperCase);
            Controls.Add(label1);
            Controls.Add(cbxColor);
            Controls.Add(lbxDisplay);
            Controls.Add(lblFruit);
            Controls.Add(rbPear);
            Controls.Add(rbBanana);
            Controls.Add(rbApple);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbApple;
        private RadioButton rbBanana;
        private RadioButton rbPear;
        private Label lblFruit;
        private ListBox lbxDisplay;
        private ComboBox cbxColor;
        private Label label1;
        private CheckBox cbxUpperCase;
        private Button btnAdd;
        private Button btnClear;
    }
}