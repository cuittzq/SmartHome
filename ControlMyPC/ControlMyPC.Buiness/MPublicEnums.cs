// ***********************************************************************
// <copyright file="MPublicEnums.cs" company="四川全球通">
// Copyright (c) 四川全球通. All rights reserved.</copyright>
// Assembly         : MyComputer
// Author            : 谭志强
// Created          : 2016/1/12 14:54:04
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
    /// 控制类型
    /// </summary>
    public enum ControlType
    {
        NONE = -1,
        关机 = 0,
        重启 = 1,
        注销 = 2,
        锁定 = 3,
        显示器 = 4,
        音量 = 5,
        命令 = 6,
    }
}
