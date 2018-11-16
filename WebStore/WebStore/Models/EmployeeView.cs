using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebStore.Models
{
    public class EmployeeView
    {
        public int id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Имя является обязательным")]
        //[Display(Name = "Имя")]
        [StringLength(maximumLength:200, MinimumLength = 1, ErrorMessage = "В поле Имя необходимо ввести от 1-го до 200-х символов")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Фамилия является обязательной")]
        [StringLength(maximumLength: 200, MinimumLength = 1, ErrorMessage = "В поле Фамилия необходимо ввести от 1-го до 200-х символов")]
        public string SurName { get; set; }

        [StringLength(maximumLength: 200, ErrorMessage = "В поле Отчество необходимо ввести не более 200-х символов")]
        public string Patronymic { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Возраст является обязательной")]
        public int Age { get; set; }
    }
}
