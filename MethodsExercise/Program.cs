namespace MethodsExercise
{
    public class Program
    {

        public static int sum(int num1, int num2)

        {
            return num1 + num2;
        }

        public static int sum(int num1, int num2, int num3)
        {
            return num1+ num2 + num3;
        }

        public static int sum(int num1, int num2 , int num3 , int num4, int num5)
        {
            return num1 + num2 + num3 + num4 + num5;

         }


        static void Main(string[] args)

        {
            Console.WriteLine("Hello what is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi,{userName}, what is your favorite color ? ");
            var color = Console.ReadLine();

            Console.WriteLine($" Nice, {color} is an awesome color! what is your favorite animal ?");
            var animal = Console.ReadLine();

            Console.WriteLine("Great, Now what is your favorite band ");
            var band = Console.ReadLine();

            Console.WriteLine($" Thanks, {userName}! Here is your Login profile");

            Console.WriteLine("-----------------------------");

            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite Color :{color} ");
            Console.WriteLine($" Favorite Animal : {animal}");
            Console.WriteLine($"Favorite Band: {band}");

            int answer1 = sum(2,4 );
            int answer2 = sum(2, 4,6);
            int answer3 = sum(1,1,1,1,1);
            Console.WriteLine(answer1);
            Console.WriteLine(answer2);
            Console.WriteLine(answer3);

        }




    }






}
