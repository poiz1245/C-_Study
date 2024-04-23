using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = null; //null 불가
            int? b = null; // Nullable 타입으로 null할당 가능
           
            bool c = null;
            bool? d = null; 

            Nullable<int> e = null; //int?를 int로 할당
            int f = e.Value;
        }
    }
}
