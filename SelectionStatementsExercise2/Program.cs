namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");

            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                case "calculus":
                    Console.WriteLine("I hate Math!");
                    break;
                case "science":
                case "physics":
                case "biology":
                    Console.WriteLine("I love Sciene!");
                    break;
                case "pe":
                case "physical education":
                    Console.WriteLine("PE is the Best!");
                    break;
                case "history":
                    Console.WriteLine("History is Fun1");
                    break;
                case "english":
                    Console.WriteLine("English is Boring!");
                    break;
                default:
                    Console.WriteLine("I don't know that subject.");
                    break;

            }
        }
    }
}