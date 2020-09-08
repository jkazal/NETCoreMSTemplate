using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Vsbrand
    {
        public Vsbrand()
        {
            Vsproduct = new HashSet<Vsproduct>();
        }

        public int Id { get; set; }
        public string BrandName { get; set; }

        public virtual ICollection<Vsproduct> Vsproduct { get; set; }
    }
}
