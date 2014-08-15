using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp4boxSharp
{
    /// <summary>
    /// Mencoderwrapper synchron
    /// </summary>
    public class mp4BoxSharpSync : mp4BoxSharp
    {
        public bool mp4BoxConcat(List<Uri> sources, Uri destination)
        {
            string concatedParameterAndSources = string.Empty;
            Process p = new Process();
            p.StartInfo.FileName = pathToMp4boxExe;
            //http://msdn.microsoft.com/de-de/library/system.diagnostics.processstartinfo.redirectstandardoutput.aspx
            p.StartInfo.RedirectStandardOutput = false;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            foreach (var item in sources)
            {
                concatedParameterAndSources += "-cat \"" + item.LocalPath + "\" ";
            }
            p.StartInfo.Arguments = concatedParameterAndSources + "\"" + destination.LocalPath + "\"";
            p.Start();
            //nur eins darf synchron gelesen werden!! http://msdn.microsoft.com/de-de/library/system.diagnostics.processstartinfo.redirectstandarderror.aspx
            standardError = p.StandardError.ReadToEnd();
            p.WaitForExit();
            if (p.ExitCode.Equals(0))
                return true;
            return false;
        }

        /// <summary>
        /// The standard error
        /// </summary>
        public string standardError;

        // Howto create a Async Method that throws events when finished
        //http://msdn.microsoft.com/en-us/library/e7a34yad.aspx
        // The method to be executed asynchronously.

        public bool concatMp4s(List<Uri> sources, Uri destination)
        {
            return mp4BoxConcat(sources, destination);
        }
    }
}
