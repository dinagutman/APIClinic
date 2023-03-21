using BLClinic.Services;
using DALClinic.Models;
using DALClinic.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLClinic.Models
{
    public class PatientsService : IPatientsService
    {
        IPatientsRepository patientsRepository;
        public PatientsService(IPatientsRepository patientsRepository)
        {
            this.patientsRepository = patientsRepository;
        }
        public Patient GetById(int id)
        {
          return  patientsRepository.GetById(id);
        }
    }
}
