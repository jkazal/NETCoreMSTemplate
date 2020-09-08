using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class VsproductPrice
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? SizeId { get; set; }
        public int? RetailerId { get; set; }
        public int? ColorId { get; set; }
        public decimal? Price { get; set; }
        public int? StockQuantity { get; set; }

        public virtual Vscolor Color { get; set; }
        public virtual Vsproduct Product { get; set; }
        public virtual Vsretailer Retailer { get; set; }
        public virtual Vssize Size { get; set; }
    }
}
