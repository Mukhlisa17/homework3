namespace Homwework
{
    public class returnOnlyUpperCaseBase
    {
        public static void Main()
        {
            string word = "DDD example CQRS Event Sourcing";

            var returnUppercaseOnly = word.Split(' ').Where(x => string.Equals(x, x.ToUpper()));

            foreach (var u in returnUppercaseOnly)
            {
                Console.Write($"{u}, ");
            }


        }
    }
}