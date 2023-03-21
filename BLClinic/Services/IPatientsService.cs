using DALClinic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLClinic.Services
{
    public interface IPatientsService
    {
        public Patient GetById(int id);
    }
}
