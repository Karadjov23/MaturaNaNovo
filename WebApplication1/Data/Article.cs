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
        [Required]
        public string Name { get; set; }
        [Required]
        public string ArticleText { get; set; }
        [Required]
        public string Image { get; set; }
        public DateTime Date { get; set; }
        public Article()
        {
            Date = DateTime.Now;
        }
    }
}
