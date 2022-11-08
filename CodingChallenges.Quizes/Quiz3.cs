namespace CodingChallenges.Quizes
{
    internal class Quiz3
    {
        private string _result;
 

        public void Run()
        {
            SaySomething();
            Console.WriteLine($"Result: {_result}");
        }

        private async Task<string> SaySomething()
        {
            await Task.Delay(5);

            _result = "Hello world!";

            return "Something";
        }


        #region What if

        //static Task<string> SaySomething()
        //{
        //    Thread.Sleep(5);

        //    _result = "Hello world!";
        //    return "Something";
        //}

        #endregion
    }
}
