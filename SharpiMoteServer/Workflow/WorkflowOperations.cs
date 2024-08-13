using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpiMoteServer.Workflow
{
    enum AFTER_SERVER_UP_STATE
    {
        STOP,
        EXIT,
        NONE
    }
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
        public static AFTER_SERVER_UP_STATE AfterServerUpState()
        {
            ConsoleKey key = Console.ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.S: return AFTER_SERVER_UP_STATE.STOP;
                case ConsoleKey.Escape: return AFTER_SERVER_UP_STATE.EXIT;
                default: return AFTER_SERVER_UP_STATE.NONE;
            }
        }
    }
}