using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data
{
    public class Signal
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
   
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Signal()
        {
            Date = DateTime.Now;
        }
    }
}
