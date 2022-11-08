namespace CodingChallenges.TennisMatch.ComponentModel;

public interface IGame
{
    GameStatus Status { get; }


    Points Player1Points { get; }

    Points Player2Points { get; }


    void ScoreP1();

    void ScoreP2();
}