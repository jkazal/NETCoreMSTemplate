using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Vssize
    {
        public Vssize()
        {
            VsproductPrice = new HashSet<VsproductPrice>();
            VsproductReview = new HashSet<VsproductReview>();
            VsproductSize = new HashSet<VsproductSize>();
        }

        public int Id { get; set; }
        public string SizeName { get; set; }

        public virtual ICollection<VsproductPrice> VsproductPrice { get; set; }
        public virtual ICollection<VsproductReview> VsproductReview { get; set; }
        public virtual ICollection<VsproductSize> VsproductSize { get; set; }
    }
}
