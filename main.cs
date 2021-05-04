using System;
using System.Collections.Generic;

namespace main {
    class Program {
        static void Main(string[] args){
            
            // int[] intArray = new int[5];
            int[] intArray = new int[] { 1, 2, 3, 4, 5 };

            List<int> intList = new List<int>() { 1, 2, 3};
            
            for (int i = 0; i < intList.Count; i++) {
                Console.WriteLine(i + " " + intList[i]);
            }

            Console.ReadKey();
        }
    }
}