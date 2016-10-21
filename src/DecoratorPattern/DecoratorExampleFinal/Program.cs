using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExampleFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            var simpleVideoGame = new SimpleVideoGame();
            Console.WriteLine(simpleVideoGame.Description);

            var multiplayerVideoGame = new MultiplayerGameDecorator(simpleVideoGame, 4);
            Console.WriteLine(multiplayerVideoGame.Description);

            var hiResVideoGame = new HiResGameDecorator(simpleVideoGame);
            Console.WriteLine(hiResVideoGame.Description);

            var multiplayerHiResVideoGame = new MultiplayerGameDecorator(new HiResGameDecorator(simpleVideoGame), 2);
            Console.WriteLine(multiplayerHiResVideoGame.Description);

            Console.ReadKey();
        }
    }
}
