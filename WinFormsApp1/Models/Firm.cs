using System;
using System.Collections.Generic;

#nullable disable

namespace ApteklerSebekesi.Models
{
    public partial class Firm
    {
        public Firm()
        {
            Medicines = new HashSet<Medicine>();
        }

        public int FId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Medicine> Medicines { get; set; }
    }
}
