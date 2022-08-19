using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestHPA.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TestHPAController : ControllerBase
    {
        // GET: <TestHPAController>
        [HttpGet]
        public string Get()
        {
            return new TestHPA().GetName();
        }
    }
}
