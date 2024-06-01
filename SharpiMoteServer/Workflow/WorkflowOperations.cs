using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpiMoteServer.Workflow
{
    internal abstract class WorkflowOperations
    {
        public enum WelcomeOperation
        {
            START,
            EXIT,
            ILLEGAL
        }
        public static WelcomeOperation Welcome()
        {
            ConsoleKey key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.Enter: return WelcomeOperation.START;
                case ConsoleKey.Escape: return WelcomeOperation.EXIT;
                default: return WelcomeOperation.ILLEGAL;
            }
        }
    }
}