using System;
using System.Collections.Generic;

#nullable disable

namespace ApteklerSebekesi.Models
{
    public partial class Tag
    {
        public Tag()
        {
            MedicineToTags = new HashSet<MedicineToTag>();
        }

        public int TId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<MedicineToTag> MedicineToTags { get; set; }
    }
}
