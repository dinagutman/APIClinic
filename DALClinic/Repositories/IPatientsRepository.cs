using DALClinic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALClinic.Repositories
{
    public interface IPatientsRepository
    {
        public Patient GetById(int id);
    }
}
