using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Vsproduct
    {
        public Vsproduct()
        {
            VsproductColor = new HashSet<VsproductColor>();
            VsproductPrice = new HashSet<VsproductPrice>();
            VsproductReview = new HashSet<VsproductReview>();
            VsproductSize = new HashSet<VsproductSize>();
        }

        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductUrl { get; set; }
        public int? BrandId { get; set; }
        public int? CategoryId { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public virtual Vsbrand Brand { get; set; }
        public virtual Vscategory Category { get; set; }
        public virtual ICollection<VsproductColor> VsproductColor { get; set; }
        public virtual ICollection<VsproductPrice> VsproductPrice { get; set; }
        public virtual ICollection<VsproductReview> VsproductReview { get; set; }
        public virtual ICollection<VsproductSize> VsproductSize { get; set; }
    }
}
