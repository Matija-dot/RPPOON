using System;
using System.Collections.Generic;
using System.Text;

namespace LabExercise_1
{
    class Author
    {
        private String name;
        private String surname;

        public Author()
        {
            this.name = "unknown";
            this.surname = "unknown";
        }
        public Author(String name, String surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public String Name
        {
            get { return this.name; }
        }
        public String Surname
        {
            get { return this.surname; }
        }

        public override String ToString()
        {
            return " AUTHOR\n Name: " + this.name + "\n Surname: " + this.surname + "\n";
        }
    }
}
