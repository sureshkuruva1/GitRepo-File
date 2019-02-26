using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThirdPartyTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdPartyTools.Tests
{
    [TestClass()]
    public class FileDetailsTests
    {
        string[] versionDelimeters = { "-v", "--v", "/v", "--version" };
        string[] sizeDelimeters = { "-s", "--s", "/s", "--size" };
        private readonly FileDetails _fileDetails;
        private readonly string filePath = "c:/test.txt";
        public FileDetailsTests()
        {
            _fileDetails = new FileDetails();
        }

        [TestMethod()]
        public void VersionTest()
        {          
           string version= _fileDetails.Version(filePath);
           Assert.AreEqual(string.Empty, version, "Version information can not be found");
        }

        [TestMethod()]
        public void SizeTest()
        {
            int size = _fileDetails.Size(filePath);
            Assert.AreEqual(int.MinValue, size, "Size information can not be found");
        }
    }
}