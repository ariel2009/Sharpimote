// See https://aka.ms/new-console-template for more information
using SharpiMoteServer.Workflow;

internal class Program
{
    public static void Main()
    {
        Workflow workflow = new Workflow();
        workflow.StartWorkflow();
    }
}