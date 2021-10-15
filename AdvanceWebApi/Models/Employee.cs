using System;
using System.Collections.Generic;

#nullable disable

namespace AdvanceWebApi.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }
        public int DesignationId { get; set; }

        public virtual Designation Designation { get; set; }
    }
}
