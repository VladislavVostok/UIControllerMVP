using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UIController.Views
{
    public partial class StudentView : Form, IView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public StudentView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPage2);
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnCloseStudentView.Click += delegate { this.Close(); };


            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearchBox.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };

            bntAddStudentView.Click += delegate { 
                AddEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Add(tabPage2);
                tabPage2.Text = "Добавьте студента";

            };
            bntEditStudentView.Click += delegate { 
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Add(tabPage2);
                tabPage2.Text = "Изменить студента";
            };
            btnSaveStudentView.Click += delegate { 
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPage2);
                    tabControl1.TabPages.Add(tabPage1);

                }
                MessageBox.Show(Message);
            };
            btnDeleteStudentView.Click += delegate { 
                
                var result = MessageBox.Show("Вы точно хотите удалить выранного студента?","Внимание!",
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
            btnCancelStudentView.Click += delegate { 
                
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Add(tabPage1);

            };

        }

        public string StudentId { get { return txtStudentID.Text; } set => txtStudentID.Text = value; }
        public string Name { get { return txtStudentName.Text; } set => txtStudentName.Text = value; }
        public string Age { get { return txtStudentAge.Text; } set => txtStudentAge.Text = value; }
        public string SearchValue { get { return txtSearchBox.Text; } set => txtSearchBox.Text = value; }
        public bool IsEdit { get { return isEdit; } set => isEdit = value; }
        public bool IsSuccessful { get { return isSuccessful; } set => isSuccessful = value; }
        public string Message { get { return message; } set => message = value; }

        public event EventHandler SearchEvent;
        public event EventHandler AddEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetStudentListBindingSource(BindingSource studentList)
        {
            dataGridView1.DataSource = studentList;
        }

        // Паттерн Singleton

        private static StudentView instance;
        public static StudentView GetInstance(Form parentContainer)
        {
            if(instance == null || instance.IsDisposed)
            {
                instance = new StudentView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if(instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }
    }
}
