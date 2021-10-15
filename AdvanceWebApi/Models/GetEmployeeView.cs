using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceWebApi.Models
{
    public class GetEmployeeView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }
        public int DesignationId { get; set; }
        public string DesgName { get; set; }
        public double salary { get; set; }

    }
}
