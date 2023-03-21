using DALClinic.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALClinic.Models
{
    public class PatientsRepository : IPatientsRepository
    {
        Clinic clinic;
        public PatientsRepository(Clinic clinic)
        {
            this.clinic = clinic;
        }
        public Patient? GetById(int id)
        {
            var Cli = clinic.Patients.Where(i => i.Id == id).FirstOrDefault();
            return Cli;
        }
    }
}
