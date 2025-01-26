using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal static class Helper<T>
    {
        //Genesric : allow any Data type which you Want in using this method or class
        public static void Swap(ref T  A,ref T B)
        {
            T temp = A;
            A = B;
            B = temp;
        }


        //cant use == with Generic =>there is type not support == so we use (Equals)
        //by default it comapre by refrence not value


        //if change it to compare  with state  override it and 
        public static  int linear_search<T>(T[]array,T value)
        {
            if (value is not null && array.Length > 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (value.Equals(array[i])) return i;
                }
            }
                return -1;

        }
    
    }
}
