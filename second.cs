using System.Text;
using System.Threading.Tasks;

namespace second {
    
    class Program {

        enum PlayerState {
            Idle,
            Attacking
        }
        static PlayerState playerState;

        static void Main(string[] args) {

            switch (playerState) {
                case PlayerState.Idle:
                    break;
                case PlayerState.Attacking:
                    break;
            }

            Console.ReadKey();
        }
    }
}