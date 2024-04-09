using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIController.Views
{
    public interface IView
    {

        string StudentId { get; set; }
        string Name { get; set; }
        string Age { get; set; }

        string SearchValue {  get; set; }
        bool IsEdit {  get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        // События
        event EventHandler SearchEvent;
        event EventHandler AddEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Методы
        void SetStudentListBindingSource(BindingSource studentList);
        void Show();

    }
}
