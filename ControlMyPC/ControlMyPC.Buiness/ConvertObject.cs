// ***********************************************************************
// <copyright file="ConvertObject.cs" company="四川全球通">
// Copyright (c) 四川全球通. All rights reserved.</copyright>
// Assembly         : MyComputer
// Author            : 谭志强
// Created          : 2016/1/12 15:25:28
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ControlMyPC.Buiness
{
    public static class ConvertObject
    {
        /// <summary>
        /// JSON转换为Dictionary 循环转换
        /// </summary>
        /// <param name="jsonString">原JSON字符串</param>
        /// <returns>Dictionary</returns>
        public static Dictionary<string, object> ConvertJSONToDictionary(string jsonString)
        {
            jsonString = jsonString.Replace("\r", string.Empty).Replace("\n", string.Empty);

            JavaScriptSerializer javaSerializer = new JavaScriptSerializer();
            Dictionary<string, object> jsonData = (Dictionary<string, object>)javaSerializer.Deserialize<object>(jsonString);
            Dictionary<string, object> jsonDictionary = new Dictionary<string, object>();

            BuildDictionary(jsonData, jsonDictionary);

            return jsonDictionary;
        }

        /// <summary>
        /// Json转换为Dictionary 一次转换不循环
        /// </summary>
        /// <param name="jsonString">Json字符串</param>
        /// <returns>返回</returns>
        public static Dictionary<string, object> ConvertJsonToOneDictionary(string jsonString)
        {
            jsonString = jsonString.Replace("\r", string.Empty).Replace("\n", string.Empty);

            JavaScriptSerializer javaSerializer = new JavaScriptSerializer();
            Dictionary<string, object> jsonData = (Dictionary<string, object>)javaSerializer.Deserialize<object>(jsonString);
            return jsonData;
        }

        /// <summary>
        /// 递归创建Dictionary
        /// </summary>
        /// <param name="inputDic">输入Dictionary</param>
        /// <param name="jsonDic">输出Dictionary</param>
        private static void BuildDictionary(Dictionary<string, object> inputDic, Dictionary<string, object> jsonDic)
        {
            foreach (KeyValuePair<string, object> item in inputDic)
            {
                if (item.Value is Dictionary<string, object>)
                {
                    BuildDictionary((Dictionary<string, object>)item.Value, jsonDic);
                }
                else
                {
                    jsonDic.Add(item.Key, item.Value);
                }
            }
        }

    }
}
