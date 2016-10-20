using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExampleFinal
{
    public class MultiplayerGameDecorator : VideoGameDecorator
    {
        public MultiplayerGameDecorator(VideoGame game, int numberOfPlayers) : base(game)
        {
            NumberOfPlayers = numberOfPlayers;
        }

        public override int NumberOfPlayers { get; }

        public override string Description => base.Description + $" Avec possibilité de jouer jusqu'à {NumberOfPlayers} joueurs!";
    }

}
