using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExampleFinal
{
    public abstract class VideoGame
    {
        public abstract string Description { get; }

        public abstract int NumberOfPlayers { get; }
    }

}
