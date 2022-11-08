namespace CodingChallenges.Quizes
{
    internal class Program
    {
        private static readonly List<Action> _quizes = new()
        {
            new Quiz3().Run,
            new Quiz2().Run,
            new Quiz1().Run
        };


        private static void Main(string[] args)
        {
            var quizNumber = Convert.ToInt32(args[0]) - 1;

            var quiz = _quizes[quizNumber];
            quiz();
        }
    }
}