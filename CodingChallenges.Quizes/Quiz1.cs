// ReSharper disable All
namespace CodingChallenges.Quizes
{
    internal class Quiz1
    {
        public void Run()
        {
            var number = 0;

            SetValue(number);
            Console.WriteLine(number);

            SetValue(ref number);
            Console.WriteLine(number);


            var list = new List<int> { 0 };

            SetValue(list);
            Console.WriteLine(list[0]);

            SetValue(ref list);
            Console.WriteLine(list[0]);
        }


        private void SetValue(int value) { value = -1; }

        private void SetValue(ref int value) { value = -1; }


        private void SetValue(List<int> value) { value[0] = -1; }

        private void SetValue(ref List<int> value) { value[0] = -1; }
    }
}
