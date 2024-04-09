using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIController.Models;
using UIController.Presenters;
using UIController._Repositories;
using UIController.Views;
using System.Configuration;

namespace UIController
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //string sqlConnectionString = "Data Source=database1.db; Version = 3; New = True; Compress = True;";
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

            IMainView view = new MainView();
            
            new MainPresenter(view, sqlConnectionString);

            Application.Run((Form)view);
        }
    }
}
