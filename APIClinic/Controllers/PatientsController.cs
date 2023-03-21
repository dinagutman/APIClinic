using BLClinic.Services;
using DALClinic.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIClinic.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientsController : ControllerBase
    {
        IPatientsService patientsService;
        public PatientsController(IPatientsService patientsService)
        {
            this.patientsService = patientsService; 
        }


        //return class from type autoMapper
        [HttpGet("{id}")]
        public Patient GetById(int id)
        {
           return patientsService.GetById(id);
        }
    };
}  
