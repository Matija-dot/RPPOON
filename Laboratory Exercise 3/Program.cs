using System;

namespace Laboratory_Exercise_3
{

    class Program
    {
        static void Main(string[] args)
        {
            Dataset CSVData = new Dataset(Environment.CurrentDirectory + @"/CSV File.txt");
            Prototype CSVClone = CSVData.Clone();

            Logger logger = Logger.GetInstance();
            logger.Log(DateTime.Now.ToString() + ":\n" + CSVClone.ToString() +"\n");
            // Uporaba  loggera  na drugim mjestima u testu programa će pisati u istu datoteku.

            MatrixGenerator matrixGenerator = MatrixGenerator.GetInstance();
            double[][] matrix = matrixGenerator.Next(MatrixConstants.RowCount, MatrixConstants.ColumnCount);
            for (int i = 0; i < MatrixConstants.RowCount; i++)
            {
                for (int j = 0; j < MatrixConstants.ColumnCount; j++)
                {
                    logger.Log(matrix[i][j] + " ");
                }
                logger.Log("\n");
            }
            logger.Log("\n");

            NotificationManager notificationManager = new NotificationManager();
            Prototype notification = new ConsoleNotification("Matija", "Notification", "Test", DateTime.Now, Category.ALERT, ConsoleColor.Yellow);
            notificationManager.Display((ConsoleNotification)notification);
            notification = new ConsoleNotification("Matija", "Notification", "Test", DateTime.Now, Category.ERROR, ConsoleColor.Red);
            notificationManager.Display((ConsoleNotification)notification);
            notification = new ConsoleNotification("Matija", "Notification", "Test", DateTime.Now, Category.INFO, ConsoleColor.Green);
            notificationManager.Display((ConsoleNotification)notification);

            NotificationBuilder notificationBuilder = new NotificationBuilder();
            notificationBuilder.SetAuthor("Matija");
            notificationBuilder.SetTitle("Built Notification");
            notification = notificationBuilder.Build();
            notificationManager.Display((ConsoleNotification)notification);

            // Imenovanje klasa bi se sada moglo unaprijediti, npr. preimenovanjem "NotificationManager" u "NotificationViewer"
            NotificationDirector notificationDirector = new NotificationDirector();
            notification = notificationDirector.BuildAlert("Matija");
            notificationManager.Display((ConsoleNotification)notification);
            notification = notificationDirector.BuildError("Matija");
            notificationManager.Display((ConsoleNotification)notification);
            notification = notificationDirector.BuildInfo("Matija");
            notificationManager.Display((ConsoleNotification)notification);

            notificationManager.Display((ConsoleNotification)notification.Clone());
        }
    }
}
