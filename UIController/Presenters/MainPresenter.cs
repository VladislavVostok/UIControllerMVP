using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIController.Views;
using UIController.Models;
using UIController._Repositories;
using System.Windows.Forms;

namespace UIController.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;

            this.mainView.ShowStudentView += ShowStudentView;
        }

        private void ShowStudentView(object sender, EventArgs e)
        {
            //IStudentView view = new StudentView();         //Сначала форма каждый вызов новый инстанс
            IView view = StudentView.GetInstance((MainView) mainView);  // После SIngelton
            IRepository repository = new StudentRepository(sqlConnectionString);
            new StudentPresenter(view, repository);
        }
    }
}
