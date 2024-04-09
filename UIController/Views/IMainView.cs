using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIController.Views
{
    public interface IMainView
    {
        event EventHandler ShowStudentView;

        // TODO: Сделать реализацию формы просмотра преподавателей. На основе модели TeacherModel
        event EventHandler ShowTeachersView;
    }
}
