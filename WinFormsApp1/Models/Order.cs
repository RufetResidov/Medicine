using System;
using System.Collections.Generic;

#nullable disable

namespace ApteklerSebekesi.Models
{
    public partial class Order
    {
        public int OId { get; set; }
        public int WorkerId { get; set; }
        public int MedicineId { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }

        public virtual Medicine Medicine { get; set; }
        public virtual Worker Worker { get; set; }
    }
}
