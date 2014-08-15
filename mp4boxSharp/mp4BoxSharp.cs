using System;
using System.IO;

namespace mp4boxSharp
{
    /// <summary>
    /// The <see cref="mp4boxSharp"/> Namespace contains wrapperclasses for async and sync calls of mp4boxSharp. Keep the mp4boxSharpbinary (mp4boxSharp.exe) in the same directory as the instancing assembly. Documentation and Assembly - http://code.google.com/p/mencoder-sharp/ (GPLv3) Stefan Seeland
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    internal class NamespaceDoc
    {
    }

    /// <summary>
    /// Baseclass for async and syncmencodercalls
    /// </summary>
    public abstract class mp4BoxSharp
    {
        /// <summary>
        /// The path to mencoder exe
        /// </summary>
        internal string pathToMp4boxExe;

        /// <summary>
        /// Initializes a new instance of the <see cref="MencoderAsync"/> class.
        /// </summary>
        public mp4BoxSharp()
        {
            pathToMp4boxExe = getPathToMencoderBin();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MencoderAsync"/> class.
        /// </summary>
        /// <param name="pathToExternalMencoderExe">The path to external mencoder exe.</param>
        public mp4BoxSharp(string pathToExternalMencoderExe)
        { pathToMp4boxExe = pathToExternalMencoderExe; }

        /// <summary>
        /// Finalizes an instance of the <see cref="MencoderAsync"/> class.
        /// </summary>
        ~mp4BoxSharp()
        {
            File.Delete(pathToMp4boxExe);
        }

        /// <summary>
        /// Gets the path to mencoder bin.
        /// </summary>
        /// <returns></returns>
        public string getPathToMencoderBin()
        {
            string path = Path.GetTempPath() + @"\mp4box" + Guid.NewGuid() + ".exe";
            if (!File.Exists(path))
                using (FileStream fsDst = new FileStream(path, FileMode.CreateNew, FileAccess.Write))
                {
                    byte[] bytes = mp4boxSharp.Properties.Resources.mp4box;
                    fsDst.Write(bytes, 0, bytes.Length);
                }
            return path;
        }
    }
}