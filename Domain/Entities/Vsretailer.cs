using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Vsretailer
    {
        public Vsretailer()
        {
            VsproductPrice = new HashSet<VsproductPrice>();
        }

        public int Id { get; set; }
        public string RetailerName { get; set; }

        public virtual ICollection<VsproductPrice> VsproductPrice { get; set; }
    }
}
