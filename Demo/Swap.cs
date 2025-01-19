using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal static class Helper
    {
        //Genesric : allow any Data type which you Want in using this method or class
        public static void Swap<T>(ref T  A,ref T B)
        {
            T temp = A;
            A = B;
            B = temp;
        }
    }
}
