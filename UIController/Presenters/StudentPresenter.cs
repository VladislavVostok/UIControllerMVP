using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIController.Models;
using UIController.Views;


namespace UIController.Presenters
{
    public class StudentPresenter
    {
        private IView view;
        private IRepository repository;
        private BindingSource studentBindingSource;
        private IEnumerable<StudentModel> studentList;

        public StudentPresenter(IView view, IRepository repository)
        {
            this.studentBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            //Подписываемся на события

            this.view.SearchEvent += SearchStudent;
            this.view.AddEvent += AddNewStudent;
            this.view.EditEvent += LoadSelectedStudentToEdit;
            this.view.DeleteEvent += DeleteSelectedStudent;
            this.view.SaveEvent += SaveStudent;
            this.view.CancelEvent += CancelAction;

            //Устанавливаем привязку к ресурсам
            this.view.SetStudentListBindingSource(studentBindingSource);

            this.view.Show();

            LoadAllStudentList();

        }

        private void LoadAllStudentList()
        {
            studentList = repository.GetAll();
            studentBindingSource.DataSource = studentList;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFilds();
                
                }

        private void SaveStudent(object sender, EventArgs e)
        {
            var model = new StudentModel();
            model.Id = Convert.ToInt32(view.StudentId);
            model.Name = view.Name;
            model.Age   = Convert.ToInt32(view.Age);
            // делаем валидацию в Presenter -> Common
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if(view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Студент изменён успешно.";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Студент создан!";
                }
                view.IsSuccessful = true;
                LoadAllStudentList();
                CleanviewFilds();

            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }

        }

        private void CleanviewFilds()
        {
            view.StudentId = "0";
            view.Name = "";
            view.Age = "";
        }

        private void DeleteSelectedStudent(object sender, EventArgs e)
        {
            try
            {
                var student = (StudentModel)studentBindingSource.Current;
                repository.Delete(student.Id);
                view.IsSuccessful = true;
                view.Message = "Студент удалён.";
                LoadAllStudentList();

            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "При удалении что-то пошло не так.";
            }
        }

        private void LoadSelectedStudentToEdit(object sender, EventArgs e)
        {
            var student = (StudentModel)studentBindingSource.Current;
            view.StudentId = student.Id.ToString();
            view.Name = student.Name;
            view.Age = student.Age.ToString();
            view.IsEdit = true;
        }

        private void AddNewStudent(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchStudent(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                studentList = repository.GetByValue(this.view.SearchValue);
            else studentList = repository.GetAll();
            studentBindingSource.DataSource = studentList;

        }
    }
}
