using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Vscategory
    {
        public Vscategory()
        {
            Vsproduct = new HashSet<Vsproduct>();
        }

        public int Id { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Vsproduct> Vsproduct { get; set; }
    }
}
