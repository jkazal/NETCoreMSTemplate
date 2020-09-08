using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Vsindex
    {
        public int FakeId { get; set; }
        public int? Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string BrandName { get; set; }
        public string CategoryName { get; set; }
        public string ColorName { get; set; }
        public string SizeName { get; set; }
        public string ImageUrl { get; set; }
    }
}
