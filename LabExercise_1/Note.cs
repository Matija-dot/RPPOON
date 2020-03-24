using System;
using System.Collections.Generic;
using System.Text;

namespace LabExercise_1
{
    class Note
    {
        private String text;
        private Author author;
        private int importance;

        public Note()
        {
            this.text = "default text";
            this.author = new Author();
            this.importance = 0;
        }
        public Note(Author author)
        {
            this.text = "default text";
            this.author = author;
            this.importance = 1;
        }
        public Note(String text, Author author, int importance)
        {
            this.text = text;
            this.author = author;
            this.importance = importance;
        }

        public String getText()
        {
            return this.text;
        }
        public Author getAuthor()
        {
            return this.author;
        }
        public int getImportance()
        {
            return this.importance;
        }
        public void setText(String text)
        {
            this.text = text;
        }
        public void setImportance(int importance)
        {
            this.importance = importance;
        }

        public String Text
        {
            get { return this.text; }
            set { this.text = value; }
        }
        public Author Author
        {
            get { return this.author; }
        }
        public int Importance
        {
            get { return this.importance; }
            set { this.importance = value; }

        }

        public override String ToString()
        {
            return "---- N O T E ----\n" + this.Author.ToString() + " TEXT\n " + this.text + "\n";
        }

    }
}
