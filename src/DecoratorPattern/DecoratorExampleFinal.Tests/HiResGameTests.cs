using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace DecoratorExampleFinal.Tests
{

    [TestFixture]
    public class HiResGameTests
    {
        private VideoGame _game;
        private const int NumberOfPlayers = 4;

        [SetUp]
        public void HiResVideoGameSetup()
        {
            _game = new HiResGameDecorator(new SimpleVideoGame());
        }

        [Test]
        public void TestDescriptionContainsSimpleVideoGameDescription()
        {
            _game.Description.Should().Contain("Ceci est un simple jeu !");
        }

        [Test]
        public void TestDescriptionContainsHiResDescription()
        {
            _game.Description.Should().Contain("Avec graphiques en haute résolution!");
        }

        [Test]
        public void TestNumberOfPlayersIsCorrectlySet()
        {
            _game.NumberOfPlayers.Should().Be(1);
        }

        [Test]
        public void TestWrappingWithMultiplayerPreservesHiRes()
        {
            _game = new MultiplayerGameDecorator(_game, NumberOfPlayers);
            _game.Description.Should().Contain("Avec graphiques en haute résolution!")
                .And.Contain($"Avec possibilité de jouer jusqu'à {NumberOfPlayers} joueurs!");
        }

    }

}
