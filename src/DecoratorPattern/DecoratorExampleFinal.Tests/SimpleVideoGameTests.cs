using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace DecoratorExampleFinal.Tests
{
    [TestFixture]
    public class SimpleVideoGameTests
    {
        private VideoGame _game;

        [SetUp]
        public void SimpleVideoGameSetup()
        {
            _game = new SimpleVideoGame();
        }

        [Test]
        public void TestDescription()
        {
            _game.Description.Should().Contain("Ceci est un simple jeu !");
        }

        [Test]
        public void TestNumberOfPlayers()
        {
            _game.NumberOfPlayers.Should().Be(1);
        }
    }
}
