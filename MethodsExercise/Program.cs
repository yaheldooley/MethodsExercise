using System.Net.Http.Headers;

namespace MethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            

            Console.WriteLine("What is your favorite color?");
            string favColor = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string favAnimal = Console.ReadLine();

            Console.WriteLine("And lastly, what is your favorite band?");
            string favBand = Console.ReadLine();

            string storyString = $"Into the arena riding on the back of a {favAnimal}" +
                                    $" wearing a {favColor}, {favBand} shirt\n...was {userName}.\n";

            Console.WriteLine(storyString);
            Console.ReadLine();

            
            int addedResult = Addition(3,6,1);
            int subResult = Subtraction(10,3,2);
            int multResult = Multiply(10,2,5);
            int divResult = Divide(100,2,5);
            int modResult = Modulus(5,3); //2
            Console.ReadLine();
        }


        public static int Addition(params int[] numList)
        {
            if (numList.Length < 2) return numList[0];

            int value = 0;
            for (int i = 0; i < numList.Length; i++)
			{
                value += numList[i];
			}
            
            return value;
        }

        public static int Subtraction(params int[] numList)
        {
            if (numList.Length < 2) return numList[0];

            int value = numList[0];

            for (int i = 1; i < numList.Length; i++)
			{
                value -= numList[i];
			}

            return value;
        }

        public static int Multiply(params int[] numList)
        {
            if (numList.Length < 2) return numList[0];

            int value = numList[0];

            for (int i = 1; i < numList.Length; i++)
			{
                if (numList[i] == 0) return 0;

                value *= numList[i];
			}


            return value;
        }

        public static int Divide(params int[] numList)
        {
            if (numList.Length < 2) return numList[0];

            int value = numList[0];

            for (int i = 1; i < numList.Length; i++)
			{
                value /= numList[i];
			}

            return value;
        }

        public static int Modulus(int firstNum, int secondNum)
        {
            if (firstNum == 0 || secondNum == 0) return 0;
            
            return firstNum % secondNum;
        }

        
    }
}