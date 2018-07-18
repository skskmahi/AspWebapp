﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData.Domain_Models
{
    public class Hold
    {
        public int Id { get; set; }
       
        public virtual LibraryAsset LibraryAsset { get; set; }
        public virtual LibraryCard LibraryCard { get; set; }
        public DateTime hplaced { get; set; }
    }
}
