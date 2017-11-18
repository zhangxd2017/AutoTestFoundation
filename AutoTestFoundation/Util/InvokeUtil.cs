using AutoTestFoundation.Constant;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Management.Automation.Runspaces;
using static AutoTestFoundation.Util.InvokeUtil;

namespace AutoTestFoundation.Util
{
    class InvokeUtil
    {

        internal class Host01
        {
            /// <summary>
            /// Indicator to tell the host application that it should exit.
            /// </summary>
            private bool shouldExit;

            /// <summary>
            /// The exit code that the host application will use to exit.
            /// </summary>
            private int exitCode;

            /// <summary>
            /// Gets or sets a value indicating whether the 
            /// host application should exit.
            /// </summary>
            public bool ShouldExit
            {
                get { return this.shouldExit; }
                set { this.shouldExit = value; }
            }

            /// <summary>
            /// Gets or sets the PSHost implementation that is
            /// used to tell the host application what code to use
            /// when exiting.
            /// </summary>
            public int ExitCode
            {
                get { return this.exitCode; }
                set { this.exitCode = value; }
            }
        }
    

        internal class MyHost : PSHost
        {
            /// <summary>
            /// A reference to the PSHost implementation.
            /// </summary>
            private Host01 program;

            /// <summary>
            /// The culture information of the thread that created
            /// this object.
            /// </summary>
            private CultureInfo originalCultureInfo =
                System.Threading.Thread.CurrentThread.CurrentCulture;

            /// <summary>
            /// The UI culture information of the thread that created
            /// this object.
            /// </summary>
            private CultureInfo originalUICultureInfo =
                System.Threading.Thread.CurrentThread.CurrentUICulture;

            /// <summary>
            /// The identifier of this PSHost implementation.
            /// </summary>
            private Guid myId = Guid.NewGuid();

            /// <summary>
            /// Initializes a new instance of the MyHost class. Keep
            /// a reference to the host application object so that it 
            /// can be informed of when to exit.
            /// </summary>
            /// <param name="program">
            /// A reference to the host application object.
            /// </param>
            public MyHost(Host01 program)
            {
                this.program = program;
            }

            /// <summary>
            /// Return the culture information to use. This implementation 
            /// returns a snapshot of the culture information of the thread 
            /// that created this object.
            /// </summary>
            public override System.Globalization.CultureInfo CurrentCulture
            {
                get { return this.originalCultureInfo; }
            }

            /// <summary>
            /// Return the UI culture information to use. This implementation 
            /// returns a snapshot of the UI culture information of the thread 
            /// that created this object.
            /// </summary>
            public override System.Globalization.CultureInfo CurrentUICulture
            {
                get { return this.originalUICultureInfo; }
            }

            /// <summary>
            /// This implementation always returns the GUID allocated at 
            /// instantiation time.
            /// </summary>
            public override Guid InstanceId
            {
                get { return this.myId; }
            }

            /// <summary>
            /// Return a string that contains the name of the host implementation. 
            /// Keep in mind that this string may be used by script writers to
            /// identify when your host is being used.
            /// </summary>
            public override string Name
            {
                get { return "MySampleConsoleHostImplementation"; }
            }

            /// <summary>
            /// This sample does not implement a PSHostUserInterface component so
            /// this property simply returns null.
            /// </summary>
            public override PSHostUserInterface UI
            {
                get { return null; }
            }

            /// <summary>
            /// Return the version object for this application. Typically this
            /// should match the version resource in the application.
            /// </summary>
            public override Version Version
            {
                get { return new Version(1, 0, 0, 0); }
            }

            /// <summary>
            /// Not implemented by this example class. The call fails with
            /// a NotImplementedException exception.
            /// </summary>
            public override void EnterNestedPrompt()
            {
                throw new NotImplementedException(
                    "The method or operation is not implemented.");
            }

            /// <summary>
            /// Not implemented by this example class. The call fails
            /// with a NotImplementedException exception.
            /// </summary>
            public override void ExitNestedPrompt()
            {
                throw new NotImplementedException(
                    "The method or operation is not implemented.");
            }

            /// <summary>
            /// This API is called before an external application process is 
            /// started. Typically it is used to save state so the parent can 
            /// restore state that has been modified by a child process (after 
            /// the child exits). In this example, this functionality is not  
            /// needed so the method returns nothing.
            /// </summary>
            public override void NotifyBeginApplication()
            {
                return;
            }

            /// <summary>
            /// This API is called after an external application process finishes.
            /// Typically it is used to restore state that a child process may
            /// have altered. In this example, this functionality is not  
            /// needed so the method returns nothing.
            /// </summary>
            public override void NotifyEndApplication()
            {
                return;
            }

            /// <summary>
            /// Indicate to the host application that exit has
            /// been requested. Pass the exit code that the host
            /// application should use when exiting the process.
            /// </summary>
            /// <param name="exitCode">The exit code to use.</param>
            public override void SetShouldExit(int exitCode)
            {
                this.program.ShouldExit = true;
                this.program.ExitCode = exitCode;
            }
        }

        public static void InitPowerShell()
        {
            Runspace runspace = RunspaceFactory.CreateRunspace();
            runspace.Open();
            Pipeline pipeline = runspace.CreatePipeline();
            pipeline.Commands.AddScript("Set-ExecutionPolicy RemoteSigned");
            pipeline.Invoke();
            runspace.Close();
        }

        public static int InvokeExe(string path, string param)
        {
            Process process = new Process();
            process.StartInfo.FileName = path;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.StandardInput.WriteLine(param + "&exit");
            process.StandardInput.AutoFlush = true;
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            int code = process.ExitCode;
            process.Close();
            return code;
        }

        public static int InvokeCmd(string path, string param)
        {
            return InvokeExe(path, param);
        }

        public static int InvokePowerShell(string path, string param)
        {
            int code = ResultCode.RESULT_ERROR;

            Host01 me = new Host01();

            MyHost myHost = new MyHost(me);

            using (Runspace myRunSpace = RunspaceFactory.CreateRunspace(myHost))
            {
                myRunSpace.Open();

                using (PowerShell powershell = PowerShell.Create())
                {
                    powershell.Runspace = myRunSpace;
                    string script = File.ReadAllText(path);
                    powershell.AddScript(script);
                    try
                    {
                        powershell.Invoke();
                        code = me.ExitCode;
                    }
                    catch
                    {
                        code = ResultCode.RESULT_ERROR;
                    }
                }
                myRunSpace.Close();
            }
            return code;
        }

    }
}
