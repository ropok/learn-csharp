using System.Text;
using System.Threading.Tasks;

namespace third {

    class Program {
        static void Main(string[] args) {
            
            MyClass myClass = new MyClass();
            myClass.TestFunction();

            Console.ReadKey();
        }

        class MyClass {

            private float myFloat;
            private int myInt;
            public MyClass() {
                // Custom constructor
            }

            public void TestFunction() {
                // Do something
            }

        }
    }
}