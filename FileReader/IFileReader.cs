using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReaderLib
{
    public interface IFileReader
    {
         Task<string> ReadSingleFileAsync(string path);
         Task<List<string>> ReadMultipleFilesAsync(string directoryPath, SearchOption searchOption, string extension = null);


    }
}
