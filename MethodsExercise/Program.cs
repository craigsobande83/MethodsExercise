namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello what is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi,{userName}, what is your favorite color ? ");
              var color = Console.ReadLine();

            Console.WriteLine($" Nice, {color} is an awesome color! what is your favorite animal ?") ;
            var animal = Console.ReadLine();

            Console.WriteLine("Great, Now what is your favorite band ");
            var band = Console.ReadLine();

            Console.WriteLine($" Thanks, {userName}! Here is your Login profile") ;

            Console.WriteLine("-----------------------------");

            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite Color :{color} ");
            Console.WriteLine($" Favorite Animal : {animal}");
            Console.WriteLine($"Favorite Band: {band}");


        }
    }
}
