using BR.AN.PviServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWorks.PviServices
{
    public interface IBrPviCpu
    {
        event EventHandler<PviEventArgs> Connected;
        event EventHandler<PviEventArgs> Disconnected;
        event EventHandler<PviEventArgs> Error;

        string Name { get; set; }
        IBrPviService BrPviService { get; set; }
        DeviceType DeviceType { get; set; }

        public override void Connect();
        public override void Connect(ConnectionType connectionType);
    }
}
