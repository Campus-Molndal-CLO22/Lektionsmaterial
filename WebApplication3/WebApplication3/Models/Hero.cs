namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Hero
    {
        [Key]
        public int ID { get; set; }
        public string RealName { get; set; }
        public string Alias { get; set; }
        public string Powers { get; set; }
    }
}
