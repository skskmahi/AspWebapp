using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryData.Domain_Models
{
   public class Status
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string desc { get; set; }
    }
}
