using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TodoLists
    {
        public TodoLists()
        {
            TodoItems = new HashSet<TodoItems>();
        }

        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public string Title { get; set; }
        public string Colour { get; set; }

        public virtual ICollection<TodoItems> TodoItems { get; set; }
    }
}
