using System;
using System.Collections.Generic;
using System.Text;

namespace th4
{
    class Course

    {
        private string courseName;
        private string courseCode;
        private int courseCredit;
        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }

        }
        public string CourseCode
        {
            get { return courseCode; }
            set { courseCode = value; }

        }
        public int CourseCredit
        {
            get { return courseCredit; }
            set { courseCredit = value; }

        }

        public void ShowCourseInfo()
        {
            Console.WriteLine("My course name is " + courseName);
            Console.WriteLine("My course code is " + courseCode);
            Console.WriteLine("My course credit is " + courseCredit);

        }
    }
}
