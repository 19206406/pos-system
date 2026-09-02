using DbUp;
using DbUp.Engine;

namespace User.Api.Common.Database
{
    public static class DatabaseMigrator
    {
        public static void ApplyMigrations(string connectionString)
        {
            const int maxRetries = 10;
            int attempt = 0;

            bool isConnected = true; 

            while(isConnected)
            {
                try
                {
                    // the application creates the database 
                    EnsureDatabase.For.PostgresqlDatabase(connectionString);
                    isConnected = false; 
                } 
                catch(Exception) when (attempt < maxRetries)
                {
                    attempt++;
                    Console.WriteLine($"Postgres isn't ready yet. Retrying {attempt}/{maxRetries}...");
                    Thread.Sleep(2000); 
                }
            }

            UpgradeEngine upgrader = DeployChanges.To
                .PostgresqlDatabase(connectionString)
                .WithScriptsEmbeddedInAssembly(System.Reflection.Assembly.GetExecutingAssembly())
                .LogToConsole()
                .Build();

            DatabaseUpgradeResult result = upgrader.PerformUpgrade(); 

            if (!result.Successful)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(result.Error);
                Console.ResetColor();
                throw new Exception("The database migration failed.", result.Error);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Migrations implemented correctly.");
            Console.ResetColor();
        }
    }
}
