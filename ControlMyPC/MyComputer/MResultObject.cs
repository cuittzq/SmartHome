// ***********************************************************************
// <copyright file="MResultObject.cs" company="四川全球通">
// Copyright (c) 四川全球通. All rights reserved.</copyright>
// Assembly         : MyComputer
// Author            : 谭志强
// Created          : 2016/1/5 12:21:40
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyComputer
{
    public class MResultObject
    {
        /// <summary>
        /// 执行返回的消息
        /// </summary>
        private string message = string.Empty;

        /// <summary>
        /// 执行返回的bool值结果
        /// </summary>
        private bool result = false;

        /// <summary>
        /// 执行返回的数据
        /// </summary>
        private object returnObject = null;

        /// <summary>
        /// 执行结果
        /// </summary>
        public MResultObject()
        {
        }

        /// <summary>
        /// 执行返回的消息
        /// </summary>
        public string Message
        {
            get { return this.message; }
            set { this.message = value; }
        }

        /// <summary>
        /// 执行返回的bool值结果
        /// </summary>
        public bool Result
        {
            get { return this.result; }
            set { this.result = value; }
        }

        /// <summary>
        /// 执行返回的数据
        /// </summary>
        public object ReturnObject
        {
            get { return this.returnObject; }
            set { this.returnObject = value; }
        }
    }
}
