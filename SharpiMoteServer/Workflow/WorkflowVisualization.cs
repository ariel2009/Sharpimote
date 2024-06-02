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
        public void WelcomeState()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome to Sharpimote server!\n");
            Console.WriteLine("Press ENTER to start server, or ESC to exit...");
        }
        public void StartServerState()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Starting server...");
        }
        public void AfterServerUpState() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Server is up!");
            Console.WriteLine("Press S to stop server or ESC to exit");
        }
        public void StopWorkflow()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("Are you sure stopping the server? Y/N");
        }
        public void AfterWorkflowStopped()
        {
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.White;
        }
        public void StopServerState()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Server stopped.");
            Thread.Sleep(3000);
            Console.Clear();
        }
        public void BackFromStopWorkflow()
        {
            Console.Clear();
        }
    }
}
