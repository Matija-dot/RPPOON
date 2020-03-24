using System;
using System.Collections.Generic;
using System.Text;

namespace LabExercise_1
{
    class TimedNote : Note
    {
        private DateTime timestamp;

        public TimedNote() : base()
        {
            this.timestamp = DateTime.Now;
        }
        public TimedNote(String text, Author author, int importance) : base(text, author, importance)
        {
            this.timestamp = DateTime.Now;
        }
        public TimedNote(String text, Author author, int importance, DateTime timestamp) : base(text, author, importance)
        {
            this.timestamp = timestamp;
        }

        public DateTime Timestamp
        {
            get { return this.timestamp; }
            set { this.timestamp = value; }
        }

        public override String ToString()
        {
            return "---- N O T E ----\n" + this.Author.ToString() + " TIME\n " + this.timestamp.ToString() + "\n TEXT\n " + this.Text + "\n";
        }
    }
}
