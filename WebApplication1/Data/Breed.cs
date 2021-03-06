using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data
{
    public class Breed
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Порода Куче/Котка")]
        public string Breeds { get; set; }

        public ICollection<Animal> Animals { get; set; }
    }
}
