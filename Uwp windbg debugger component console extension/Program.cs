using System;
using System.Diagnostics;
using System.IO;

namespace Uwp_windbg_debugger_component_console_extension
{
    class Program
    {
        static void Main(string[] args)
        {
      
        Process p = new Process();
        ProcessStartInfo info = new ProcessStartInfo();
        info.FileName = "cmd.exe";
        info.RedirectStandardInput = true;
        info.UseShellExecute = false;
            info.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            info.Verb = "runas";
            p.StartInfo = info;
        p.Start();

        using (StreamWriter sw = p.StandardInput)
        {
            if (sw.BaseStream.CanWrite)
            {
                sw.WriteLine(@"cd C:\Program Files (x86)\Windows Kits\10\Debuggers\x64");
                sw.WriteLine(@"windbg.exe -plmPackage 2505FireCubeStudios.Fluentpad_1.2.4.0_x64__k45w5yt88e21j -plmApp App");
           
            }
}
    }
    }
}
