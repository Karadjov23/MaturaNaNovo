using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data
{
    public class Article
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Моля въведи име на статията")]
        [Display(Name="Име на статията")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Моля въведи текст за статията")]
        [Display(Name ="Текст за статията")]
        public string ArticleText { get; set; }
        [Required(ErrorMessage = "Моля сложи снимка за статията")]
        [Display(Name = "Снимка")]
        public string Image { get; set; }
        [Display(Name = "Дата на създаване")]
        public DateTime Date { get; set; }
        public Article()
        {
            Date = DateTime.Now;
        }
    }
}
