using IFilterTextReader;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Word = Microsoft.Office.Interop.Word;
//using System.Reflection;

namespace FileManager
{
    class Program
    {
        static void Main(string[] args)
        {
            //Word._Application application;
            //Word._Document document;
            //Object missingObj = System.Reflection.Missing.Value;
            //Object trueObj = true;
            //Object falseObj = false;
            //var w = "C:\\GIT\\w.txt";
            //var q = "C:\\GIT\\q.docx";
            //var fileStrings = File.ReadAllLines(w, Encoding.Default);
            //foreach (var fileString in fileStrings)
            //{
            //    Console.WriteLine(fileString);
            //}
            //Console.WriteLine();
            //var s = File.ReadAllText(w, Encoding.GetEncoding(10017));
            //StreamReader st = new StreamReader(w, Encoding.Default);
            //Console.WriteLine(st.ReadToEnd());
            //var qnew = new FilterReader(q);
            //q = qnew.ReadToEnd();
            //Console.WriteLine(q);
            //application = new Word.Application();
            //document = application.Documents.Add(ref q, ref missingObj, ref missingObj, ref missingObj);
            //Console.WriteLine(document);
            Manager manager = new Manager(new ConsoleUserInteractor());
            manager.FileManager();
            Console.ReadKey();
        }
    }
}
