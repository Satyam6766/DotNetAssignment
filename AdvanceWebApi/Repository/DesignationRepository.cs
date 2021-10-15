using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvanceWebApi.IRepositiory;
using AdvanceWebApi.Models;

namespace AdvanceWebApi.Repository
{
    public class DesignationRepository : IDesignationRepsitory
    {
        public readonly AdvanceWebApiContext _context;
        public DesignationRepository(AdvanceWebApiContext context)
        {
            _context = context;
        }
        public string Delete(int id)
        {
            string str;
            try
            {
                var response = _context.Designations.FirstOrDefault(x => x.DesgId == id);
                if (response != null)
                {
                    _context.Designations.Remove(response);
                    _context.SaveChanges();
                    str = "Designation record deleted successfully.";
                }
                else
                {
                    str = "Designation record not found for this id" + id + ".";
                }
            }
            catch (Exception ex)
            {
                str = "Deletion failed due to this error=" + ex.Message + ".";
            }
            return str;
        }

        public Designation GetDesignation(int id)
        {
            var response = _context.Designations.FirstOrDefault(x => x.DesgId == id);
            return response;
        }

        public IEnumerable<Designation> GetDesignations()
        {
            var response = _context.Designations.ToList();
            return response;
        }

        public string Insert(Designation designation)
        {
            string str;
            try
            {
                _context.Designations.Add(designation);
                _context.SaveChanges();
                str = "Designation saved successfully.";
            }
            catch(Exception ex)
            {
                str = "Designation insertion failed due to this error="+ex.Message+".";
            }
            return str;
        }


        public string Update(int id, Designation designation)
        {
            string str;
            var response = _context.Designations.FirstOrDefault(x => x.DesgId == id);
            try
            {
                if (response != null)
                {
                    response.DesgName = designation.DesgName;
                    response.DesgSalary = designation.DesgSalary;
                   
                    _context.SaveChanges();
                    str = "Designation record  updated successfully";
                }
                else
                {
                    str = "Designation record not found for the given id" + id + ".";
                }
            }
            catch (Exception ex)
            {
                str = "Updation failed due to this error=" + ex.Message + ".";
            }
            return str;
        }
    }
}
