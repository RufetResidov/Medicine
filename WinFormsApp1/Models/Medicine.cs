using System;
using System.Collections.Generic;

#nullable disable

namespace ApteklerSebekesi.Models
{
    public partial class Medicine
    {
        public Medicine()
        {
            MedicineToTags = new HashSet<MedicineToTag>();
            Orders = new HashSet<Order>();
        }

        public int MId { get; set; }
        public string MedicineName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public bool IsReseipt { get; set; }
        public DateTime Prodate { get; set; }
        public DateTime ExperienceDate { get; set; }
        public int? Barcode { get; set; }
        public int FirmId { get; set; }

        public virtual Firm Firm { get; set; }
        public virtual ICollection<MedicineToTag> MedicineToTags { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
