using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEmbeddedSourceProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Embedded Source!");
            System.Diagnostics.Debugger.Break();
            TinyFile tinyFile = new TinyFile();
            tinyFile.F();
        }
    }
}
