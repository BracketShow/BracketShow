using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExampleFinal
{
    public class HiResGameDecorator : VideoGameDecorator
    {
        public HiResGameDecorator(VideoGame game) : base(game)
        {
        }

        public override string Description => base.Description + " Avec graphiques en haute résolution!";
    }

}
