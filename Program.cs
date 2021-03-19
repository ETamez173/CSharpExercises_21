using System;


// Building an Exponent Method | C# | Tutorial 21

namespace CSharpExercises_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetPow(4, 3));

            Console.ReadLine();
        }

        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;
            // create i variable then use a rule/gaurd to tell C# to loop
            // powNum times and we increment the i variable
            for(int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }

            return result;
        }

    }
}
