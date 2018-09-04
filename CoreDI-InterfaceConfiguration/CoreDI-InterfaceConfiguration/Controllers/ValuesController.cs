using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreDI.InterfaceConfiguration.Sample;

namespace CoreDI_InterfaceConfiguration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        /// <summary>
        /// Step 4 : 
        /// </summary>
        private ISample _sample;
        public ValuesController(ISample example)
        {
            _sample = example;
        }


        // GET api/values
        [HttpGet]
        public string Get()
        {
            return _sample.SampleHello();
        }

        
    }
}
