namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your favorite school subject: ");
            string favoriteSchoolSubject = Console.ReadLine();

            switch (favoriteSchoolSubject){
                case "Math":
                    Console.WriteLine("Math is great for building problem-solving skills!");
                    break;
                case "Science":
                    Console.WriteLine("Science helps us understand the world around us.");
                    break;
                case "History":
                     Console.WriteLine("History is important to learn from past events and shape the future.");
                    break;
                case "English":
                     Console.WriteLine("English improves communication skills and unlocks the power of literature.");
                    break;
                case "Art":
                     Console.WriteLine("Art encourages creativity and allows you to express yourself.");
                    break;
                default:
                    Console.WriteLine("That's an interesting subject! Keep learning.");
                    break;
            }
        }
    }
}
