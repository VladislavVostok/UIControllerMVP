using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIController.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            btnStudentsMainView.Click += delegate
            {
                ShowStudentView?.Invoke(this, EventArgs.Empty);
            };

            // Здесь создать вызов формы по кнопке как с кнопкой студенты.

        }

        public event EventHandler ShowStudentView;

        public event EventHandler ShowTeachersView;
    }
}
