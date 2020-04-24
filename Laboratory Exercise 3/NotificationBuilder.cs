using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratory_Exercise_3
{
    class NotificationBuilder : IBuilder
    {
        private ConsoleNotification notification;

        public NotificationBuilder()
        {
            this.notification = new ConsoleNotification("N/A", "N/A", "Default", DateTime.Now, Category.INFO, ConsoleColor.Green);
        }

        public ConsoleNotification Build()
        {
            return notification;
        }
        public IBuilder SetAuthor(String author)
        {
            this.notification.Author = author;
            return this;
        }
        public IBuilder SetTitle(String title)
        {
            this.notification.Title = title;
            return this;
        }
        public IBuilder SetTime(DateTime time)
        {
            this.notification.Timestamp = time;
            return this;
        }
        public IBuilder SetLevel(Category level)
        {
            this.notification.Level = level;
            return this;
        }
        public IBuilder SetColor(ConsoleColor color)
        {
            this.notification.Color = color;
            return this;
        }
        public IBuilder SetText(String text)
        {
            this.notification.Text = text;
            return this;
        }
    }
}
