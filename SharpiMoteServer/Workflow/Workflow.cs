using SharpiMoteServer.Networking.CredentialsRecieverServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SharpiMoteServer.Workflow
{
    internal class Workflow : IWorkflow {
        private WorkflowVisualization visualization;
        private CredServerManager credServer;
        private enum STATES
        {
            INACTIVE,
            WELCOME,
            START_SERVER,
            AFTER_SERVER_UP,
            STOP_SERVER,
            STOP_WORKFLOW
        }
        private STATES previousState;
        public Workflow()
        {
            visualization = new WorkflowVisualization();
            previousState = STATES.INACTIVE;
            credServer = new CredServerManager();
        }
        
        protected static int current_status;
        public void StartWorkflow() {
            WelcomeState();
        }
        public virtual void WelcomeState()
        {
            visualization.WelcomeState();
            bool nextExecution = WorkflowOperations.WelcomeState();
            previousState = STATES.WELCOME;
            if (nextExecution)
            {
                StartServerState();
            }
            else
            {
                Environment.Exit(0);
            }
        }
        public virtual void StartServerState()
        {
            visualization.StartServerState();
            credServer.StartServer();
            previousState = STATES.START_SERVER;
            AfterServerUpState();
        }
        public virtual void AfterServerUpState()
        {
            visualization.AfterServerUpState();
            bool nextExecution = WorkflowOperations.AfterServerUpState();
            previousState = STATES.AFTER_SERVER_UP;
            if (nextExecution)
            {
                StopServerState();
            }
            else
            {
                StopWorkflow();
            }
        }
        public void StopServerState()
        {
            credServer.StopServer();
            previousState = STATES.STOP_SERVER;
            WelcomeState();
        }
        public void StopWorkflow()
        {
            visualization.StopWorkflow();
            var nextExecution = WorkflowOperations.StopWorkflow();
            if (nextExecution)
            {
                visualization.AfterWorkflowStopped();
                Environment.Exit(0);
            }
            else
            {
                visualization.BackFromStopWorkflow();
                GoBack();
            }
        }
        private void GoBack()
        {
            switch (previousState)
            {
                case STATES.WELCOME: WelcomeState(); break;
                case STATES.START_SERVER: StartServerState(); break;
                case STATES.AFTER_SERVER_UP: AfterServerUpState(); break;
                case STATES.STOP_SERVER: StopServerState(); break;
                case STATES.STOP_WORKFLOW: StopWorkflow(); break;
            }
        }
    }
}
