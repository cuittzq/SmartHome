using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ControlMyPC.WebApiUI.Controllers
{
    public class WebApiController : ApiController
    {
        /// <summary>
        /// 去哪订单处理
        /// </summary>
        /// <param name="data">传入参数</param>
        /// <returns>返回结果</returns>
        [System.Web.Http.AcceptVerbs("GET", "POST")]
        public string CommandHandler([FromBody]object dataObject)
        {
            string result = string.Empty;

            return result;
        }
    }
}
