using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpiMoteServer.Workflow
{
    internal class WorkflowVisualization : IWorkflow
    {
        public WorkflowVisualization()
        {

        }
        public void Welcome()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Sharpimote server!\n");
            Console.WriteLine("Press ENTER to start server, or ESC to exit...");
        }
    }
}
