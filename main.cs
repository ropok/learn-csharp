using System;

namespace main {
    class Program {
        static void Main(string[] args){

            int i = 56;

            Console.WriteLine("Hello World! " + i);

            TestFunction();
            bool b = SecondTestFunction(50);
            Console.ReadKey();
        }

        static void TestFunction() {

        }

        static bool SecondTestFunction(int i) {
            return i < 100;
        }
    }
}