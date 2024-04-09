
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace UIController.Models
{
    public class StudentModel
    {


        private int id;
        private string name;
        private int age;

        [DisplayName("ИД")]
        public int Id { get => id; set => id = value; }

        [DisplayName("Имя")]
        [Required(ErrorMessage ="Имя студента обязательно!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Имя студента должно быть от 3 до 50 символов!")]
        public string Name { get => name; set => name = value; }

        [DisplayName("Возраст")]
        [Required(ErrorMessage = "Возраст студента обязателен!")]
        public int Age { get => age; set => age = value; }

    }
}
