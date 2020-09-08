using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class VsproductSize
    {
        public int ProductId { get; set; }
        public int SizeId { get; set; }

        public virtual Vsproduct Product { get; set; }
        public virtual Vssize Size { get; set; }
    }
}
