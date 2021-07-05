using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayUltilityProgram
{
    class ArrayUtility
    {
       
       
        public static void Resize(ref int[] array, int newSize)
        {           
            int[] temp = new int[newSize];
            Array.Copy(array, temp, array.Length);
            array = temp; 

        }
    }
}
