using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DBTreeView
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            IConfiguration configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();

            if (Convert.ToBoolean(configuration.GetConnectionString("UseSQLite")))
                optionsBuilder.UseSqlite(connectionString);
            else
                optionsBuilder.UseSqlServer(connectionString);

            using (var dbContext = new ApplicationContext(optionsBuilder.Options))
            {
                MainForm mainForm = new MainForm(dbContext);

                Application.Run(mainForm);
            }
        }
    }
}