using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExampleFinal
{
    public class SimpleVideoGame : VideoGame
    {
        public override string Description => "Ceci est un simple jeu !";

        public override int NumberOfPlayers => 1;
    }

}
