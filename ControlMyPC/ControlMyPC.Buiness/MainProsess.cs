// ***********************************************************************
// <copyright file="MainProsess.cs" company="四川全球通">
// Copyright (c) 四川全球通. All rights reserved.</copyright>
// Assembly         : ControlMyPC.Buiness
// Author            : 谭志强
// Created          : 2016/1/12 15:58:34
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlMyPC.Buiness
{
    /// <summary>
    /// 主流程
    /// </summary>
    public class MainProsess
    {
        private MRequsetParam requsetParam = null;

        public MainProsess(MRequsetParam requsetParam)
        {
            this.requsetParam = requsetParam;
        }

        /// <summary>
        /// 执行
        /// </summary>
        public void Exetue()
        {
            ControlComputer controlComputer = new ControlComputer();
            this.ResultObject = new MResultObject();
            try
            {
                switch (this.requsetParam.ControlType)
                {
                    case ControlType.NONE:
                        break;
                    case ControlType.关机:
                        controlComputer.ShutDown();
                        this.ResultObject.Result = true;
                        break;
                    case ControlType.重启:
                        controlComputer.Restart();
                        this.ResultObject.Result = true;
                        break;
                    case ControlType.注销:
                        controlComputer.LogOff();
                        this.ResultObject.Result = true;
                        break;
                    case ControlType.锁定:
                        controlComputer.LockPC();
                        this.ResultObject.Result = true;
                        break;
                    case ControlType.显示器:
                        controlComputer.Turnoffmonitor();
                        this.ResultObject.Result = true;
                        break;
                    case ControlType.音量:
                        if (this.requsetParam.VoiceValue > 0)
                        {
                            controlComputer.SetVolUp();
                        }
                        else if (this.requsetParam.VoiceValue < 0)
                        {
                            controlComputer.SetVolMute();
                        }
                        this.ResultObject.Result = true;
                        break;
                    case ControlType.命令:
                        this.ResultObject = new ExecuteCommand().ExecuteCommandReturnValue(this.requsetParam.Commendstr);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                this.ResultObject.Result = false;
                this.ResultObject.ReturnObject = ex;
            }

        }

        public MResultObject ResultObject
        {
            get;
            set;
        }
    }
}
