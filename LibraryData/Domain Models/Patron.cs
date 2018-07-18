using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData.Domain_Models
{
    public class Patron
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public string Phno { get; set; }
        public DateTime Dob { get; set; }
        public  LibraryCard LibrayCard { get; set; }
        //public virtual LibraryCard Abc { get; set; }
        public virtual LibraryBranch HomeLibraryBranch { get; set; }
    }
}
