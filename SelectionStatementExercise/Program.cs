namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Number guessing game
            var r = new Random();
            var favNumber = r.Next(1, 1000);


            Console.WriteLine(“Try to guess my favorite number”);
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {

                Console.WriteLine($"{userInput} is too low");

            }
            else if (userInput > favNumber)
            {

                Console.WriteLine($"{userInput) is PathTooLongException high");

            }
            else
            {
                Console.WriteLine("Nevermind.");

            }           
        }
    }
}
