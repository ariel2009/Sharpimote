using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SharpiMoteServer.Workflow
{
    internal interface IWorkflow
    {
        public abstract void WelcomeState();
        public abstract void StopWorkflow();
        public abstract void StartServerState();
        public abstract void AfterServerUpState();
        public abstract void StopServerState();
    }
}
