// ***********************************************************************
// <copyright file="MRequsetParam.cs" company="四川全球通">
// Copyright (c) 四川全球通. All rights reserved.</copyright>
// Assembly         : ControlMyPC.Buiness
// Author            : 谭志强
// Created          : 2016/1/12 16:35:56
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlMyPC.Buiness
{
    public class MRequsetParam
    {
        /// <summary>
        /// 控制类型
        /// </summary>
        private ControlType controlType = ControlType.NONE;

        /// <summary>
        /// 声音加减
        /// </summary>
        private int voiceValue = 0;

        /// <summary>
        /// 命令
        /// </summary>
        private string commendstr = string.Empty;

        /// <summary>
        /// 控制类型
        /// </summary>
        public ControlType ControlType
        {
            get { return controlType; }
            set { controlType = value; }
        }

        /// <summary>
        /// 声音加减
        /// </summary>
        public int VoiceValue
        {
            get { return voiceValue; }
            set { voiceValue = value; }
        }

        /// <summary>
        /// 命令
        /// </summary>
        public string Commendstr
        {
            get { return commendstr; }
            set { commendstr = value; }
        }
    }
}
