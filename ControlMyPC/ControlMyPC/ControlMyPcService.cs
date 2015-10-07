using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ControlMyPC
{
    public partial class ControlMyPcService : ServiceBase
    {
        /// <summary>
        /// 后台扫描线程
        /// </summary>
        private Thread threadScan = null;

        private bool isControl = false;

        public ControlMyPcService()
        {
            InitializeComponent();
            this.isControl = true;
        }

        /// <summary>
        /// 服务启动
        /// </summary>
        /// <param name="args"></param>
        protected override void OnStart(string[] args)
        {
            this.Start();
        }

        protected override void OnStop()
        {
            this.isControl = false;
        }

        /// <summary>
        /// 开始
        /// </summary>
        public void Start()
        {
            this.threadScan = new Thread(new ThreadStart(this.ScanAndControl));
            this.threadScan.IsBackground = true;
            this.threadScan.Start();
        }

        /// <summary>
        /// 扫描并开始控制
        /// </summary>
        private void ScanAndControl()
        {
            while (this.isControl)
            {
                try
                {

                }
                catch (Exception ex)
                {

                }
                finally
                {
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
