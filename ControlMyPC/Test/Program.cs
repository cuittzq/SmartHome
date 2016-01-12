using ControlMyPC.Buiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlComputer controlComputer = new ControlComputer();
            controlComputer.SetVolDown();
            controlComputer.SetVolUp();
            controlComputer.SetVolMute();
            controlComputer.Turnoffmonitor();
            Console.ReadLine();
        }
    }

}
