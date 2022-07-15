using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OBS.DomainLayer.Models;
using OBS.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OBS_Repository;

namespace Online_Banking_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IOnlineBankingSystem onlineBankingSystem;

        public ServiceController(IOnlineBankingSystem onlineBankingSystem)
        {
            this.onlineBankingSystem = onlineBankingSystem;
        }
        public void CalcInterest()
        {
           
        }
        

    }
}
