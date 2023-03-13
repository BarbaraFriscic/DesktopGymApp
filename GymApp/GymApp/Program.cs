using GymApp.Model;
using GymApp.Presenter;
using GymApp.Repository;
using GymApp.View;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            ILoginView loginView = new LoginView();
            ILoginRepository loginRepository = new LoginRepository(sqlConnectionString);
            new LoginPresenter(loginView, loginRepository);
            Application.Run((Form)loginView);
        }
    }
}
