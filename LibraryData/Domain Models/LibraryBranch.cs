using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryData.Domain_Models
{
    public class LibraryBranch
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30,ErrorMessage ="Limit 30")]
        public string Name { get; set; }

        [Required]
        
        public string Address { get; set; }

        [Required]

        public string Tphone { get; set; }
        public string Desc { get; set; }
        public DateTime pdate { get; set; }

        public virtual IEnumerable<Patron> Patrons { get; set; }
        public virtual IEnumerable<LibraryAsset> LibraryAsset { get; set; }
        public string URL { get; set; }
    }
}
