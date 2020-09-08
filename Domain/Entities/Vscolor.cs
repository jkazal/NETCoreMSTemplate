using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Vscolor
    {
        public Vscolor()
        {
            VsproductColor = new HashSet<VsproductColor>();
            VsproductPrice = new HashSet<VsproductPrice>();
            VsproductReview = new HashSet<VsproductReview>();
        }

        public int Id { get; set; }
        public string ColorName { get; set; }
        public string ColorCode { get; set; }

        public virtual ICollection<VsproductColor> VsproductColor { get; set; }
        public virtual ICollection<VsproductPrice> VsproductPrice { get; set; }
        public virtual ICollection<VsproductReview> VsproductReview { get; set; }
    }
}
