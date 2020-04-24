using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratory_Exercise_3
{
    class NotificationDirector
    {
        private NotificationBuilder notificationBuilder;

        public NotificationDirector()
        {
            this.notificationBuilder = new NotificationBuilder();
        }

        public ConsoleNotification BuildAlert(string author)
        {
            return notificationBuilder.SetAuthor(author).SetColor(ConsoleColor.Yellow).SetTitle("Alert").SetText("Infection spotted.").SetLevel(Category.ALERT).Build();
        }
        public ConsoleNotification BuildError(string author)
        {
            return notificationBuilder.SetAuthor(author).SetColor(ConsoleColor.Red).SetTitle("Error").SetText("Infection spread.").SetLevel(Category.ERROR).Build();
        }
        public ConsoleNotification BuildInfo(string author)
        {
            return notificationBuilder.SetAuthor(author).SetColor(ConsoleColor.Green).SetTitle("Info").SetText("Infection ended.").SetLevel(Category.INFO).Build();
        }
    }
}
