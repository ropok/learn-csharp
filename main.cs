using System;

namespace main {
    class Program {
        static void Main(string[] args){
            
            int i = 13;
            
            switch (i) {
                default:
                    Console.Write("No case!");
                    break;
                case 1:
                    Console.WriteLine("First case!");
                    break;
                case 5:
                    break;
            }

            Console.ReadKey();
        }

        static void TestFunction() {

        }

        static bool SecondTestFunction(int i) {
            return i < 100;
        }
    }
}