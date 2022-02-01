using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Annu.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }

        public string Image { get; set; }

        public string Name { get; set; }

        public string IsActive { get; set; }
    }
}
