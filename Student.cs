using System;
using System.Collections.Generic;
using System.Text;

namespace th4
{
    class Student
    {
        private string name;
        private string id;
        private string department;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }


        public string Department
        {
            get { return department; }
            set { department = value; }
        }


    }
}