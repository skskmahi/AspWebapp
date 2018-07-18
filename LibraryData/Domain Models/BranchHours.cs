using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryData.Domain_Models
{
    public class BranchHours
    {
        public int Id { get; set; }
        public  LibraryBranch Location { get; set; }
        [Range(0,6)]
        public int Dow { get; set; }
        [Range(0, 23)]
        public int opt { get; set; }
        [Range(0, 23)]
        public int ct { get; set; }
    }
}
