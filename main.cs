using System;
using System.Collections.Generic;

namespace main {
    class Program {
        static void Main(string[] args){
            
            // This is a comment
            
            /*
            *
            *Multi line comment!
            * comment comment
            * */

            int[] intArray = new int[] { 1, 2, 3, 4, 5 };

            List<int> intList = new List<int>() { 1, 2, 3};

            int i = 0;
            do {
                i++;
            } while (i < 5);

            Console.ReadKey();
        }
    }
}