// ***********************************************************************
// <copyright file="ControlComputer.cs" company="四川全球通">
// Copyright (c) 四川全球通. All rights reserved.</copyright>
// Assembly         : MyComputer
// Author            : 谭志强
// Created          : 2015/9/29 11:54:50
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ControlMyPC.Buiness
{
    public class ControlComputer
    {
        [DllImport("user32")]
        public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);

        [DllImport("user32")]
        public static extern void LockWorkStation();

        [DllImport("user32")]
        public static extern int SendMessage(int hWnd, int hMsg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        Process process = null;

        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0x0a0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x090000;
        private const int WM_APPCOMMAND = 0x319;

        public ControlComputer()
        {
            process = Process.GetCurrentProcess();
        }


        /// <summary>
        /// 加音量 
        /// </summary>
        public void SetVolUp()
        {
            //加音量 
            SendMessageW(this.process.Handle, WM_APPCOMMAND, this.process.Handle, (IntPtr)APPCOMMAND_VOLUME_UP);
        }

        /// <summary>
        /// 减音量
        /// </summary>
        public void SetVolDown()
        {
            //减音量 
            SendMessageW(this.process.Handle, WM_APPCOMMAND, this.process.Handle, (IntPtr)APPCOMMAND_VOLUME_DOWN);
        }

        //静音
        public void SetVolMute()
        {
            //静音 
            SendMessageW(this.process.Handle, WM_APPCOMMAND, this.process.Handle, (IntPtr)APPCOMMAND_VOLUME_MUTE);
        }

        /// <summary>
        /// 关机
        /// </summary>
        public void ShutDown()
        {
            try
            {
                System.Diagnostics.ProcessStartInfo startinfo = new System.Diagnostics.ProcessStartInfo("shutdown.exe", "-s -t 00");
                System.Diagnostics.Process.Start(startinfo);
            }
            catch { }
        }

        /// <summary>
        /// 重启
        /// </summary>
        public void Restart()
        {
            try
            {
                System.Diagnostics.ProcessStartInfo startinfo = new System.Diagnostics.ProcessStartInfo("shutdown.exe", "-r -t 00");
                System.Diagnostics.Process.Start(startinfo);
            }
            catch { }
        }

        /// <summary>
        /// 注销
        /// </summary>
        public void LogOff()
        {
            try
            {
                ExitWindowsEx(0, 0);
            }
            catch { }
        }

        /// <summary>
        /// 锁定
        /// </summary>
        public void LockPC()
        {
            try
            {
                LockWorkStation();
            }
            catch { }
        }

        /// <summary>
        /// 关闭显示器
        /// </summary>
        public void Turnoffmonitor()
        {
            SetMonitorInState(MonitorState.MonitorStateOff);
        }

        private void SetMonitorInState(MonitorState state)
        {
            SendMessage(0xFFFF, 0x112, 0xF170, (int)state);
        }

        public enum MonitorState
        {
            MonitorStateOn = -1,
            MonitorStateOff = 2,
            MonitorStateStandBy = 1
        }
    }
}
