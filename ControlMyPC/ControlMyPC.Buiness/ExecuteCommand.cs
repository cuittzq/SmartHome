// ***********************************************************************
// <copyright file="ExecuteCommand.cs" company="四川全球通">
// Copyright (c) 四川全球通. All rights reserved.</copyright>
// Assembly         : MyComputer
// Author            : 谭志强
// Created          : 2016/1/5 12:20:54
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlMyPC.Buiness
{
    public class ExecuteCommand
    {
        /// <summary>
        /// CMD执行Command命令
        /// </summary>
        /// <returns>执行结果</returns>
        public MResultObject ExecuteCommandReturnValue(string commondtxt)
        {
            MResultObject resultObject = new MResultObject();
            try
            {
                //this.Writecmd(string.Format("命令{0}", command));
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = string.Format("/c {0}", commondtxt);
                    process.StartInfo.RedirectStandardInput = true;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.RedirectStandardError = true;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.CreateNoWindow = true;
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.Start();
                    // this.Writecmd(string.Format("命令{0}开始执行", command));
                    process.WaitForExit(20 * 60 * 1000);
                    resultObject.Result = process.ExitCode == 0;
                    resultObject.Message = process.StandardError.ReadToEnd();
                    // this.Writecmd(string.Format("命令{0}执行完成，执行结果{1}", command, resultObject.Message));
                }
            }
            catch (Exception ex)
            {
                resultObject.Result = false;
                resultObject.Message = string.Format("执行CMD：“{1}”命令出现异常：{0}", ex.Message, commondtxt);
                resultObject.ReturnObject = ex;
            }

            return resultObject;
        }
    }
}
