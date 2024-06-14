namespace MethodsExercise
{
    public class Program
    {

        public static int Sum(int num1, int num2)

        {
            return num1 + num2;
        }

        public static int Sum(int num1, int num2, int num3)
        {
            return num1+ num2 + num3;
        }

        public static int Sum(int num1, int num2 , int num3 , int num4, int num5)
        {
            return num1 + num2 + num3 + num4 + num5;

         }
         public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
         public static int Subtract(int num1,int num2 , int num3)
         {
            return num1 - num2 - num3;
          }
          public static int Subtract (int num1, int num2 , int num3, int num4, int num5)

          {
            return num1 - num2 - num3 - num4 - num5;
          }

          public static int Multiply(int num1, int num2)

        {
            return num1 * num2;
        }

        public static int Multiply(int num1, int num2, int num3)

        {
            return num1 * num2 * num3;
        }

        public static int Multiply(int num1, int num2, int num3, int num4, int num5)

        {
            return num1 * num2 * num3 *num4 * num5;
        }


        public static int Divide(int num1, int num2)

        {
            return num1 / num2;
        }

        public static int Divide(int num1, int num2, int num3)

        {
            return num1 / num2 / num3;
        }

        public static int Divide(int num1, int num2, int num3, int num4, int num5)

        {
            return num1 / num2 / num3 / num4 / num5;
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

            
            int answer1 = Sum(2,4 );
            int answer2 = Sum(2, 4,6);
            int answer3 = Sum(1,1,1,1,1);
            Console.WriteLine(answer1);
            Console.WriteLine(answer2);
            Console.WriteLine(answer3);

            int answer4 = Subtract(2,4);
            int answer5 = Subtract(2, 4, 6);
            int answer6 = Subtract(1,1,1,1,1);
            Console.WriteLine(answer4);
            Console.WriteLine(answer5);
            Console.WriteLine(answer6);


            int answer7 = Multiply(2, 4);
            int answer8 = Multiply(2, 4, 6);
            int answer9 = Multiply(1, 1, 1, 1, 1);
            Console.WriteLine(answer7);
            Console.WriteLine(answer8);
            Console.WriteLine(answer9);

            int answer10 = Divide(2, 4);
            int answer11 = Divide(2, 4, 6);
            int answer12 = Divide(1, 1, 1, 1, 1);
            Console.WriteLine(answer10);
            Console.WriteLine(answer11);
            Console.WriteLine(answer12);

        }




    }






}
