using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using ControlMyPC.Buiness;

namespace ControlMyPC.WebApiUI.Controllers
{
    public class WebApiController : ApiController
    {
        /// <summary>
        /// 控制接口
        /// </summary>
        /// <param name="data">传入参数</param>
        /// <returns>返回结果</returns>
        [System.Web.Http.AcceptVerbs("GET", "POST")]
        public string CommandHandler([FromBody]MRequsetParam requsetParam)
        {
            string result = string.Empty;
            try
            {
                if (requsetParam != null)
                {
                    //ControlType controlType = dicInfo.ContainsKey("type") ? (ControlType)Convert.ToInt32(dicInfo["type"]) : ControlType.NONE;
                    //int voiceValue = dicInfo.ContainsKey("voiceValue") ? Convert.ToInt32(dicInfo["voiceValue"]) : 0;
                    //string commendstr = dicInfo.ContainsKey("commend") ? dicInfo["commend"].ToString() : string.Empty;
                    MainProsess mainProsess = new MainProsess(requsetParam);
                    mainProsess.Exetue();
                    return JsonConvert.SerializeObject(mainProsess.ResultObject);
                }
            }
            catch (Exception ex)
            {

            }

            return result;
        }
    }
}
