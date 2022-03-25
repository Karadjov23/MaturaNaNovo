using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Enum;

namespace WebApplication1.Data
{
    public class Animal
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Моля въведи името на животното")]
        [Display(Name="Име на животното")]
        public string Name { get; set; }
        
        [Display(Name = "Избор на животното")]
        public KindCategory KindCategory { get; set; }
        [Required]
        public int BreedId { get; set; }
        [Display(Name = "Порода")]
        public Breed Breed { get; set; }

        [Required (ErrorMessage = "Въведи години")]
        [Range(1, 60, ErrorMessage = "Трябва да е по-голямо от 0")]
        [Display(Name = "Години")]
        public string Age { get; set; }

        [Display(Name = "Пол")]
        [Required]
        public Gender Gender { get; set; }

        [Required(ErrorMessage = "Въведи снимки")]
        [Display(Name = "Снимка")]
        public string Image { get; set; }

        [Display(Name = "Кастрация")]
        public bool Castrated { get; set; }
        [Display(Name = "Паспорт")]
        public bool Passport { get; set; }
        [Display(Name = "Информация за животното")]
        [Required (ErrorMessage = "Въведи информация за животното")]
        public string Condition { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Дата на създаване")]
        public DateTime Date { get; set; }
        public Animal()
        {
            Date = DateTime.Now;
        }
    }
}
