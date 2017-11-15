using System.Management.Automation.Runspaces;

namespace AutoTestFoundation.Util
{
    class InvokeUtil
    {

        public static void InitPowerShell()
        {
            Runspace runspace = RunspaceFactory.CreateRunspace();
            runspace.Open();
            Pipeline pipeline = runspace.CreatePipeline();
            pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
            pipeline.Invoke();
            runspace.Close();
        }

    }
}
