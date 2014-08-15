using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectMp4boxSharp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            mp4boxSharp.mp4BoxSharpSync mp4boxSync = new mp4boxSharp.mp4BoxSharpSync();

            var sourcelist = new List<Uri>();
            sourcelist.Add(new Uri(getDirectoryOfAssembly() + "\\source1.mp4"));
            sourcelist.Add(new Uri(getDirectoryOfAssembly() + "\\source2.mp4"));

            Assert.IsTrue(mp4boxSync.concatMp4s(sourcelist, new Uri(testContextInstance.ResultsDirectory + "\\TestOutput.mp4")));

        }
        private static string getDirectoryOfAssembly()
        {
            return System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
        }
        private TestContext testContextInstance;


        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
    }
}
