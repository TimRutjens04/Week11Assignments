using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseExc
{
    public class CourseClass
    {
        private string courseName;
        private int courseEC;

        public CourseClass(string courseName, int courseEC)
        { 
            this.courseName = courseName;
            this.courseEC = courseEC;
        }
        public CourseClass(string courseName)
        : this(courseName, 3)
        {}
    } 
}
