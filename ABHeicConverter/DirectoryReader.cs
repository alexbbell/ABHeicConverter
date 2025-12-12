using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABHeicConverter
{
    public class DirectoryReader
    {
        private readonly string _path;
        public DirectoryReader(string path)
        {
            _path = path;
        }
        public string[] GetDirectoryFiles()
        {
            string[] files = Directory.GetFileSystemEntries(_path, "*.heic");

            return files;

        }
    }
}
