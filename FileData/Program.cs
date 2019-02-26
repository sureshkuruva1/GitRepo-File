using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            // check the argument length to find the size\version of the file
            if (args?.Length != 2)
            {
                System.Console.WriteLine("Please make sure you have valid 2 arguments to process the request..");
            }
            else
            {
                FileInfo fileInfo = new FileInfo();
                var info = fileInfo.GetFileInfo(args[0], args[1]);
                if(info!=null)
                Console.Write(info);
                else
                    Console.Write("Invalid entries in the arguments..");

            }
            Thread.Sleep(10000);


        }
    }
}
