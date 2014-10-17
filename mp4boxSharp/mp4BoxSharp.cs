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
    /// Baseclass for async and syncmp4BoxSharp
    /// </summary>
    public abstract class mp4BoxSharp
    {
        /// <summary>
        /// The path to mp4box exe
        /// </summary>
        internal string pathToMp4boxExe;

        /// <summary>
        /// Initializes a new instance of the <see cref="mp4BoxSharp"/> class.
        /// </summary>
        public mp4BoxSharp()
        {
            pathToMp4boxExe = getPathToMp4BoxSharpBin();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Mp4BoxAsync"/> class.
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
        /// Gets the path to MP4 box sharp bin.
        /// </summary>
        /// <returns></returns>
        public string getPathToMp4BoxSharpBin()
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