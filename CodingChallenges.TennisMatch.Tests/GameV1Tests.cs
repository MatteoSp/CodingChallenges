using CodingChallenges.TennisMatch.ComponentModel;
using CodingChallenges.TennisMatch.Implementations;

namespace CodingChallenges.TennisMatch.Tests
{
    public class GameV1Tests
    {
        private static readonly Random _random = new();
        
        private GameV1 _game = default!;


        [SetUp]
        public void Setup()
        {
            _game = new GameV1();
        }


        [Test]
        public void P1_ScoresAll()
        {
            _game.ScoreP1();
            _game.ScoreP1();
            _game.ScoreP1();
            _game.ScoreP1();

            Assert.That(_game.Status, Is.EqualTo(GameStatus.P1Won));
        }


        [Test]
        public void P2_ScoresAll()
        {
            _game.ScoreP2();
            _game.ScoreP2();
            _game.ScoreP2();
            _game.ScoreP2();

            Assert.That(_game.Status, Is.EqualTo(GameStatus.P2Won));
        }


        [Test]
        public void Initial_Head_To_Head_Then_P1_Wins()
        {
            _game.ScoreP1();
            _game.ScoreP2();
            _game.ScoreP1();
            _game.ScoreP2();
            _game.ScoreP1();
            _game.ScoreP1();

            Assert.That(_game.Status, Is.EqualTo(GameStatus.P1Won));
        }


        [Test]
        public void Initial_Head_To_Head_Then_P2_Wins()
        {
            _game.ScoreP1();
            _game.ScoreP2();
            _game.ScoreP1();
            _game.ScoreP2();
            _game.ScoreP2();
            _game.ScoreP2();

            Assert.That(_game.Status, Is.EqualTo(GameStatus.P2Won));
        }


        [Test]
        public void Advantage_Deuce_Then_P1_Wins()
        {
            _game.ScoreP1();
            _game.ScoreP2();
            _game.ScoreP1();
            _game.ScoreP2();
            _game.ScoreP1();
            _game.ScoreP2();

            _game.ScoreP1(); //advantage p1
            _game.ScoreP2(); //deuce
            _game.ScoreP2(); //advantage p2
            _game.ScoreP1(); //deuce
            _game.ScoreP1(); //advantage p1
            _game.ScoreP1(); //p1 wins

            Assert.That(_game.Status, Is.EqualTo(GameStatus.P1Won));
        }


        [Test]
        public void Chaos()
        {
            Assert.DoesNotThrow(() =>
            {
                while (_game.Status == GameStatus.Playing)
                {
                    var number = _random.Next();
                    Math.DivRem(number, 2, out var remainder);

                    if (remainder == 0)
                        _game.ScoreP2();
                    else
                        _game.ScoreP1();
                }
            });
        }


        [Test]
        public void P1_ScoresOne()
        {
            _game.ScoreP1();

            Assert.That(_game.Status, Is.EqualTo(GameStatus.Playing));
            Assert.That(_game.Player1Points, Is.EqualTo(Points.Fifteen));
            Assert.That(_game.Player2Points, Is.EqualTo(Points.Zero));
        }


        [Test]
        public void P1_ScoresOne_P2_ScoreOne()
        {
            _game.ScoreP1();
            _game.ScoreP2();

            Assert.That(_game.Status, Is.EqualTo(GameStatus.Playing));
            Assert.That(_game.Player1Points, Is.EqualTo(Points.Fifteen));
            Assert.That(_game.Player2Points, Is.EqualTo(Points.Fifteen));
        }
    }
}