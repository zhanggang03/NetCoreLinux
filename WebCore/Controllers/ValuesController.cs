using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public ValuesController()
        {
        }

        [HttpGet,Route("GetValues/{value}")]
        [Description("测试使用")]
        public string GetValues(string value)
        {
            Logger.Info(value);
            return value;
        }
    }
}