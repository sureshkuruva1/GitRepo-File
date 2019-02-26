using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace FileData
{
    public class FileInfo : IFileInfo
    {
        string[] versionDelimeters = { "-v", "--v", "/v", "--version" };
        string[] sizeDelimeters = { "-s", "--s", "/s", "--size" };
        private readonly FileDetails _fileDetails;
        public FileInfo()
        {
            _fileDetails = new FileDetails();
        }
        /// <summary>
        /// Get the file information based on the delimeters and file 
        /// </summary>
        /// <param name="delimeter"></param>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public object GetFileInfo(string delimeter, string filePath)
        {
            try
            {
                if (sizeDelimeters.Contains(delimeter.ToLower()))
                {
                    var size = _fileDetails.Size(filePath);

                    return $"File size: {size}";
                }
                else if (versionDelimeters.Contains(delimeter.ToLower()))
                {
                    var version = _fileDetails.Version(filePath);

                    return $"File version: {version}";
                }
            }
            catch(Exception ex)
            {
                return ex.Message;
            }

            return null;
        }
    }
}
