using System;
using System.Collections.Generic;

#nullable disable

namespace AdvanceWebApi.Models
{
    public partial class Designation
    {
        public Designation()
        {
            Employees = new HashSet<Employee>();
        }

        public int DesgId { get; set; }
        public string DesgName { get; set; }
        public decimal? DesgSalary { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
