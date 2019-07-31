using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    class Manager
    {
        public Manager()
        {
        }
        private string adressName { get; set; }
        private bool AdressHaving()
        {
            return File.Exists(adressName);
        }
        public void FileManager()
        {
            FirstDisk();
            while (true)
            {
                Console.WriteLine("If you want to select a different folder, click Enter");
                var key = Console.ReadKey(true);
                if(key.Key == ConsoleKey.Enter)
                {
                    InFolder();
                }
                else if(key.Key == ConsoleKey.Backspace)
                {
                    BackFolder();
                }
                else if(key.Key == ConsoleKey.Escape)
                {
                    throw new OperationCanceledException();
                }
            }
        }
        private void BackFolder()
        {
            try
            {
                var k = Path.GetDirectoryName(adressName);
                adressName = Path.GetDirectoryName(k);
                OutPutFiles();
            }
            catch (ArgumentNullException)
            {
                FirstDisk();
            }
        }
        private void InFolder()
        {
            Console.WriteLine("Select a folder");
            while (true)
            {
                var saveAdress = adressName;
                try
                {
                    var fileName = Console.ReadLine();
                    var adress = $"{fileName}\\";
                    adressName = $"{adressName}{adress}";
                    OutPutFiles();
                    break;
                }
                catch (DirectoryNotFoundException ex)
                {
                    adressName = saveAdress;
                    Console.WriteLine($"Bed input {ex}, try again");
                }
            }
        }
        private void FirstDisk()
        {
            Console.WriteLine("Select a disc");
            while (true)
            {
                Console.WriteLine("If you want 'C' disc click c, if 'D' disc click d, if you want to exit, click Escape");
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.C)
                {
                    adressName = "C:\\";
                    OutPutFiles();
                    break;
                }
                else if (key.Key == ConsoleKey.D)
                {
                    adressName = "D:\\";
                    OutPutFiles();
                    break;
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    throw new OperationCanceledException();
                }
                Console.WriteLine("Bed input");
            }
        }
        private void OutPutFiles()
        {
            var allDocument = Directory.GetFiles(adressName);
            var allFolder = Directory.GetDirectories(adressName);
            var allFiles = allFolder.Concat(allDocument);
            Console.Write("In this folder are: ");
            foreach (var file in allFiles)
            {
                Console.Write($"{Path.GetFileName(file)}, ");
            }
            Console.WriteLine();
        }
    }
}
