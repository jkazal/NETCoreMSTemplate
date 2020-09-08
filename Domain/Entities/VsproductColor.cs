using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class VsproductColor
    {
        public int ProductId { get; set; }
        public int ColorId { get; set; }

        public virtual Vscolor Color { get; set; }
        public virtual Vsproduct Product { get; set; }
    }
}
