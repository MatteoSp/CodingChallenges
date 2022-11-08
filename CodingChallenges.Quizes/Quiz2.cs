// ReSharper disable All
namespace CodingChallenges.Quizes
{
    internal class Quiz2
    {
        private delegate void Printer();
 

        public void Run()
        {
            var printers = new List<Printer>();

            for(var i = 0; i < 10; i++)
            {
                printers.Add(delegate
                {
                    Console.WriteLine(i);
                });
            }

            foreach (var printer in printers)
            {
                printer();
            }
        }
    }
}
