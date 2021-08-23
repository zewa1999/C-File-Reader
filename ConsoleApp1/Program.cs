using FileReaderLib;
using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {

            //var text = await FileReader.ReadSingleFile("C:\\Users\\costa\\Desktop\\C-Sharp-File-Reader\\safas.txt");
            var multipleFiles = await FileReader.ReadMultipleFilesAsync("C:\\Users\\costa\\Desktop\\C-Sharp-File-Reader", "txt", System.IO.SearchOption.TopDirectoryOnly);


        }
    }
}
