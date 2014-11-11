using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BR.AN.PviServices;

namespace ControlWorks.PviServices
{
    public interface IBrPviService
    {
        event EventHandler<PviEventArgs> Connected;
        event EventHandler<PviEventArgs> Disconnected;
        event EventHandler<PviEventArgs> Error;

        string Name { get; set; }

        void Connect();
        void Connect(ConnectionType connectionType);
        void Connect(string server, int port);

    }


            //    Console.WriteLine("Service Connected Error=" + e.ErrorCode.ToString());
            //cpu = new Cpu(service, "Cpu");
            //cpu.Connection.DeviceType = DeviceType.Serial;
            //cpu.Connection.Serial.Channel = 1;
            //cpu.Connected += new PviEventHandler(cpu_Connected);
            //Console.WriteLine("Connecting Cpu ...");
            //cpu.Connect();

}
