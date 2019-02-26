using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData
{
    public interface IFileInfo
    {
        object GetFileInfo(string delimeter, string filePath);
    }
}
