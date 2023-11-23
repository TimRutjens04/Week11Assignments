using System.Windows.Forms;

namespace CourseExc
{
    public partial class Form1 : Form
    {
        private Course currentCourse;
        public Form1()
        {
            InitializeComponent();
            currentCourse = new Course();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void btnCreateCourse_Click(object sender, EventArgs e)
        {
            // Get values from text boxes
            string courseName = tbxCourseName.Text;
            int ec;

            // Validate and parse EC value
            if (int.TryParse(tbxCourseEC.Text, out ec))
            {
                // Set values in the Course object
                currentCourse.SetName(courseName);
                currentCourse.SetEc(ec);

                // Display information or perform any other actions
                MessageBox.Show($"Course created!\nName: {currentCourse.GetName()}\nEC: {currentCourse.GetEc()}");
            }
            else
            {
                // Display an error message if EC is not a valid integer
                MessageBox.Show("Please enter a valid EC value.");
            }
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            // Check if a course has been created
            if (currentCourse != null)
            {
                // Display course information in the label
                lblDisplayInfo.Text = $"Course Information:\nName: {currentCourse.GetName()}\nEC: {currentCourse.GetEc()}";
            }
            else
            {
                // Display a message if no course has been created
                lblDisplayInfo.Text = "No course information available. Create a course first.";
            }
        }

    }


    public class Course
    {
        // Instance variables     
        private string name;
        private int ec;
        // Methods     
        public void SetName(string name)
        { this.name = name; }

        public string GetName()
        { return this.name; }

        public void SetEc(int ec)
        { this.ec = ec; }

        public int GetEc()
        { return this.ec; }
    }


}