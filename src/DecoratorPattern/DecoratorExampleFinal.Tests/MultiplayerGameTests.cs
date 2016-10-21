using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace DecoratorExampleFinal.Tests
{
    [TestFixture]
    public class MultiplayerGameTests
    {
        private VideoGame _game;
        private const int NumberOfPlayers = 4;

        [SetUp]
        public void MultiplayerVideoGameSetup()
        {
            _game = new MultiplayerGameDecorator(new SimpleVideoGame(), NumberOfPlayers);
        }

        [Test]
        public void TestDescriptionContainsSimpleVideoGameDescription()
        {
            _game.Description.Should().Contain("Ceci est un simple jeu !");
        }

        [Test]
        public void TestDescriptionContainsMultiplayerDescription()
        {
            _game.Description.Should().Contain($"Avec possibilité de jouer jusqu'à {NumberOfPlayers} joueurs!");
        }

        [Test]
        public void TestNumberOfPlayersIsCorrectlySet()
        {
            _game.NumberOfPlayers.Should().Be(NumberOfPlayers);
        }

        [Test]
        public void TestWrappingWithHiResPreservesMultiplayer()
        {
            _game = new HiResGameDecorator(_game);
            _game.Description.Should().Contain($"Avec possibilité de jouer jusqu'à {NumberOfPlayers} joueurs!")
                .And.Contain("Avec graphiques en haute résolution!");
            _game.NumberOfPlayers.Should().Be(NumberOfPlayers);

        }

    }
}
