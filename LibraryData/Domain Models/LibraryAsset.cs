using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryData.Domain_Models
{
    public abstract class LibraryAsset
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int year { get; set; }
        [Required]
        public Status status { get; set; }
        [Required]
        public decimal cost { get; set; }
        public string ImageURL { get; set; }
        public int copies { get; set; }
        public virtual LibraryBranch Location { get; set; }
    }
}
