using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpiMoteServer.Workflow
{
    internal class Workflow : IWorkflow {
        private WorkflowVisualization visualization;
        public Workflow()
        {
            visualization = new WorkflowVisualization();
        }
        
        protected static int current_status;
        public void StartWorkflow() {
            Welcome();
        }
        public virtual void Welcome()
        {
            visualization.Welcome();
            var nextExecution = WorkflowOperations.Welcome();
        }
    }
}
