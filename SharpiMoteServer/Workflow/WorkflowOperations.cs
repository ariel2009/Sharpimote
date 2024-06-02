using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpiMoteServer.Workflow
{
    internal abstract class WorkflowOperations
    {
        public static bool WelcomeState()
        {
            ConsoleKey key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.Enter: return true;
                case ConsoleKey.Escape: return false;
                default: return false;
            }
        }
        public static bool StopWorkflow()
        {
            ConsoleKey key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.Y: return true;
                case ConsoleKey.N: return false;
                default: return false;
            }
        }
        public static bool AfterServerUpState()
        {
            ConsoleKey key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.S: return true;
                case ConsoleKey.Escape: return false;
                default: return false;
            }
        }
    }
}