using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExampleFinal
{
    public abstract class VideoGameDecorator : VideoGame
    {
        protected VideoGame _videoGame;

        public VideoGameDecorator(VideoGame game)
        {
            _videoGame = game;
        }

        public override string Description => _videoGame.Description;
    }

}
