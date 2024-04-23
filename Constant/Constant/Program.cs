using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constant
{
    internal class Program
    {
        class CSVar
        {
            const int maxValue = 1024;

            readonly int max;

            public CSVar()
            {
                max = 1;
            }

            public void Method1()
            {
                const int maxValue = 100;
                readonly int max;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
