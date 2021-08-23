using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Collections.Generic;
namespace FileReaderLib
{
    public class FileReader : IFileReader
    {
        public async Task<string> ReadSingleFileAsync(string path)
        {
            var text = await File.ReadAllTextAsync(path);
            return text;
        }

        public async Task<List<string>> ReadMultipleFilesAsync(string directoryPath, SearchOption searchOption, string extension = null)
        {
            var files = GetFilesByExtension(directoryPath, extension, searchOption);
            var bag = new ConcurrentBag<string>();
            var tasks = files.Select(async item =>
            {

                var response = await ReadSingleFileAsync(item);
                bag.Add(response);
            });
            await Task.WhenAll(tasks);

            return bag.ToList();
        }

        private static IEnumerable<string> GetFilesByExtension(string folderPath, string extension, SearchOption searchOption)
        {
            return Directory.EnumerateFiles(folderPath, "*" + extension, searchOption);
        }

       
    }
}
