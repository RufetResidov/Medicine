using System;
using System.Collections.Generic;

#nullable disable

namespace ApteklerSebekesi.Models
{
    public partial class Worker
    {
        public Worker()
        {
            Orders = new HashSet<Order>();
        }

        public int WId { get; set; }
        public string Fullname { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
