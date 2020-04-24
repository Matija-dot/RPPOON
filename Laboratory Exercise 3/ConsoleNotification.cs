using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratory_Exercise_3
{
    public enum Category { ALERT, ERROR, INFO }

    class ConsoleNotification : Prototype
    {
        public String Author { get; set; }
        public String Title { get; set; }
        public String Text { get; set; }
        public DateTime Timestamp { get; set; }
        public Category Level { get; set; }
        public ConsoleColor Color { get; set; }

        public ConsoleNotification(String author, String title, String text, DateTime time, Category level, ConsoleColor color)
        {
            this.Author = author;
            this.Title = title;
            this.Text = text;
            this.Timestamp = time;
            this.Level = level;
            this.Color = color;
        }

        public Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
            /* U konkretnom slučaju razlika između plitkog i dubokog kopiranja bi se očitovala jedino u memorijskoj alokaciji.
               Funkcionalno razlike nema budući da se klasa ne mijenja nakon poziva konstruktora (u trećem primjeru svojstva imaju settere private razine pristupa). */ 
        }
    }
}
