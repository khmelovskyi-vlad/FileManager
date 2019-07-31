using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.FileManager();
            Console.ReadKey();
        }
    }
}
