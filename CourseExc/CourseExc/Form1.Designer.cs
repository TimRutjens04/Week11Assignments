namespace CourseExc
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
            lblDisplayInfo = new Label();
            tbxCourseName = new TextBox();
            tbxCourseEC = new TextBox();
            btnCreateCourse = new Button();
            btnShowInfo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Course name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Course ECs:";
            // 
            // lblDisplayInfo
            // 
            lblDisplayInfo.AutoSize = true;
            lblDisplayInfo.BorderStyle = BorderStyle.FixedSingle;
            lblDisplayInfo.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblDisplayInfo.Location = new Point(39, 162);
            lblDisplayInfo.Name = "lblDisplayInfo";
            lblDisplayInfo.Size = new Size(115, 17);
            lblDisplayInfo.TabIndex = 2;
            lblDisplayInfo.Text = "Label to display info";
            lblDisplayInfo.Click += label3_Click;
            // 
            // tbxCourseName
            // 
            tbxCourseName.Location = new Point(98, 6);
            tbxCourseName.Name = "tbxCourseName";
            tbxCourseName.Size = new Size(90, 23);
            tbxCourseName.TabIndex = 3;
            // 
            // tbxCourseEC
            // 
            tbxCourseEC.Location = new Point(98, 35);
            tbxCourseEC.Name = "tbxCourseEC";
            tbxCourseEC.Size = new Size(90, 23);
            tbxCourseEC.TabIndex = 4;
            // 
            // btnCreateCourse
            // 
            btnCreateCourse.Location = new Point(48, 64);
            btnCreateCourse.Name = "btnCreateCourse";
            btnCreateCourse.Size = new Size(97, 23);
            btnCreateCourse.TabIndex = 5;
            btnCreateCourse.Text = "Create course ";
            btnCreateCourse.UseVisualStyleBackColor = true;
            btnCreateCourse.Click += btnCreateCourse_Click;
            // 
            // btnShowInfo
            // 
            btnShowInfo.Location = new Point(39, 127);
            btnShowInfo.Name = "btnShowInfo";
            btnShowInfo.Size = new Size(115, 23);
            btnShowInfo.TabIndex = 6;
            btnShowInfo.Text = "Show course info";
            btnShowInfo.UseVisualStyleBackColor = true;
            btnShowInfo.Click += btnShowInfo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(202, 216);
            Controls.Add(btnShowInfo);
            Controls.Add(btnCreateCourse);
            Controls.Add(tbxCourseEC);
            Controls.Add(tbxCourseName);
            Controls.Add(lblDisplayInfo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblDisplayInfo;
        private TextBox tbxCourseName;
        private TextBox tbxCourseEC;
        private Button btnCreateCourse;
        private Button btnShowInfo;
    }
}