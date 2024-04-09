using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIController.Models
{
    public class TeacherModel
    {
        private int id;
        private string name;
        private int age;
        private string major;       // Специальность
        private int classroomId;    // Кабинет

        [DisplayName("ИД")]
        public int Id { get => id; set => id = value; }

        [DisplayName("Имя")]
        [Required(ErrorMessage = "Имя учителя заполнить обязательно!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Имя учителя должно быть от 3 до 50 символов!")]
        public string Name { get => name; set => name = value; }

        [DisplayName("Возраст")]
        [Required(ErrorMessage = "Возраст учителя нужно заполнить обязательно!")]
        public int Age { get => age; set => age = value; }
        
        [DisplayName("Специальность")]
        [Required(ErrorMessage = "Специальность учителя нужно заполнить обязательно!")]
        public string Major { get => major; set => major = value; }

        [DisplayName("Кабинет")]
        [Required(ErrorMessage = "Кабинет учителя нужно заполнить обязательно!")]
        public int ClassroomId { get => classroomId; set => classroomId = value; }

    }
}
