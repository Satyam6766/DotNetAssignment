using AdvanceWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceWebApi.IRepositiory
{
    public interface IDesignationRepsitory
    {
        public IEnumerable<Designation> GetDesignations();
        public Designation GetDesignation(int id);
        public string Insert(Designation designation);
        public string Update(int id, Designation designation);
        public string Delete(int id);

    }
}
