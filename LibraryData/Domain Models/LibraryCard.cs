using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData.Domain_Models
{
    public class LibraryCard
    {
        public int Id { get; set; }
        public decimal Fees { get; set; }

        public DateTime created { get; set; }

        public virtual IEnumerable<Checkout> Checkout { get; set; }
    }
}
