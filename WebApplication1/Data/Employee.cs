using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Въведи име")]
        [Display(Name ="Име")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Въведи презиме ")]
        [Display(Name = "Презиме")]
        public string SecondName { get; set; }
        [Required(ErrorMessage = "Въведи фамилия")]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Въведи емейл на служителя")]
        [Display(Name = "Емейл")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Снимка на служителя")]
        [Display(Name = "Снимка")]
        public string Image { get; set; }
        [Required(ErrorMessage = "Моля да посочите позицията на служителя")]
        [Display(Name = "Пизиция")]
        public string EmployeersPosition { get; set; }
    }
}
