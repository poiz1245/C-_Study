using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable
{
    class CSVar
    {
        int globalVar;
        //const int Max = 1024;

        public void Method1()
        {
            int localVar;

            localVar = 100;

            Console.WriteLine(globalVar);
            Console.WriteLine(localVar);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CSVar obj = new CSVar();
            obj.Method1();
        }
    }
}
