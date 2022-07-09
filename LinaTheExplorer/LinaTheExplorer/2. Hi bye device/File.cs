using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_bye_device
{
    public class PathToFile
    {
        public const string SearchPattern = "*_.json";
        public const string InputFileDefault = "trips_.json";

        public static string GetSystemPath()
        {

            var inputFilePath =
                Directory.GetFiles(Directory.GetCurrentDirectory(), SearchPattern).FirstOrDefault();
            

            if (inputFilePath == null)
            {
                File.Create(InputFileDefault, default, FileOptions.RandomAccess);
                inputFilePath = InputFileDefault;
            }

            return inputFilePath;
        }

    }
}
