using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace FileData.Tests
{
    [TestClass()]
    public class FileInfoTests
    {
        string[] versionDelimeters = { "-v", "--v", "/v", "--version" };
        string[] sizeDelimeters = { "-s", "--s", "/s", "--size" };
        private readonly FileInfo _fileInfo;
        private readonly string filePath = "c:/test.txt";
        public FileInfoTests()
        {
            _fileInfo = new FileInfo();
        }

        [TestMethod()]
        public void GetFileVersionInfoTest()
        {
            object info =_fileInfo.GetFileInfo(versionDelimeters[0], filePath);
            Assert.AreNotEqual(info, null, "Invalid entries in the parameters");

        }
        [TestMethod()]
        public void GetFileVersionsizeTest()
        {
            object info = _fileInfo.GetFileInfo(sizeDelimeters[0], filePath);
            Assert.AreNotEqual(info, null, "Invalid entries in the parameters");

        }

    }
}