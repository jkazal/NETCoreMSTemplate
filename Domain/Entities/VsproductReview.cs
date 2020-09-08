using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class VsproductReview
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? SizeId { get; set; }
        public int? ColorId { get; set; }
        public decimal? Rating { get; set; }
        public int? ReviewCount { get; set; }

        public virtual Vscolor Color { get; set; }
        public virtual Vsproduct Product { get; set; }
        public virtual Vssize Size { get; set; }
    }
}
