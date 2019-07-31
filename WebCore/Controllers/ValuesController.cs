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

        static int count = 0;

        [HttpGet,Route("GetValues/{value}")]
        [Description("测试使用")]
        public string GetValues(string value)
        {
            count++;
            var headers = HttpContext.Request.Headers;
            Logger.Info(value);
            string str = "Host:" + headers["Host"];
            str += "  ||  X-Real-IP:" + headers["X-Real-IP"];
            str += "  ||  X-Forwarded-For:" + headers["X-Forwarded-For"];
            str += "  ||  value:" + value;
            str += "  ||  Count:" + count.ToString(); ;
            return str;
        }
    }
}