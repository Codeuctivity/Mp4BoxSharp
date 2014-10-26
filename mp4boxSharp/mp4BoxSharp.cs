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
            mp4boxSharpShouldBeDeletedOnDisposing = true;
            pathToMp4boxExe = getPathToMp4BoxSharpBin();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Mp4BoxAsync"/> class.
        /// </summary>
        /// <param name="pathToExternalMencoderExe">The path to external mencoder exe.</param>
        public mp4BoxSharp(string pathToExternalMencoderExe)
        { pathToMp4boxExe = pathToExternalMencoderExe; }

        private bool mp4boxSharpShouldBeDeletedOnDisposing;

        /// <summary>
        /// Finalizes an instance of the <see cref="MencoderAsync"/> class.
        /// </summary>
        ~mp4BoxSharp()
        {
            if (mp4boxSharpShouldBeDeletedOnDisposing)
                Directory.Delete(Path.GetDirectoryName((pathToMp4boxExe)), true);
        }

        /// <summary>
        /// Gets the path to MP4 box sharp bin.
        /// </summary>
        /// <returns></returns>
        public string getPathToMp4BoxSharpBin()
        {
            string directory = Path.GetTempPath() + @"\" + Guid.NewGuid() + @"\";
            Directory.CreateDirectory(directory);
            saveBinToTempFolder(directory + "libgpac.dll", mp4boxSharp.Properties.Resources.libgpac);
            saveBinToTempFolder(directory + "js.dll", mp4boxSharp.Properties.Resources.js);
            saveBinToTempFolder(directory + "libeay32.dll", mp4boxSharp.Properties.Resources.libeay32);
            saveBinToTempFolder(directory + "ssleay32.dll", mp4boxSharp.Properties.Resources.ssleay32);
            saveBinToTempFolder(directory + "mp4box.exe", mp4boxSharp.Properties.Resources.mp4box);
            return directory + "mp4box.exe";
        }

        private static void saveBinToTempFolder(string fileName, byte[] file)
        {
            string path = fileName;

            if (!File.Exists(path))
                using (FileStream fsDst = new FileStream(path, FileMode.CreateNew, FileAccess.Write))
                {
                    fsDst.Write(file, 0, file.Length);
                }
        }
    }
}