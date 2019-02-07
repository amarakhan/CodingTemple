using System;
using System.Linq;

namespace W1L4morningChallenge
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int[] scrambledNumbers = Scramble(new int []{ 1, 2, 3});

            for (int i=0; i<scrambledNumbers.Length; i++)
            {
                Console.Write(scrambledNumbers[i]+" ");
            }
            Console.WriteLine();
            int[] scrambledNumbers2 = Scramble(new int[]{ 1, 2, 3});

            for (int i = 0; i < scrambledNumbers2.Length; i++)
            {
                Console.Write(scrambledNumbers2[i] + " ");
            }

            for (int i = 0; i < scrambledNumbers.Length; i++)
            {
                if (scrambledNumbers[i] == scrambledNumbers2[i])
                {
                    //throw new Exception("Your scramble method isn't scrambly enough");
                    Console.WriteLine("Your scramble method isn't scrambly enough");
                }
            }
        }
        static int[] Scramble(int[] numbers)
        {
            int temp0 = numbers[0];
            int temp1 = numbers[1];
            int temp2 = numbers[2];
            Random rand = new Random();
            int index0 = rand.Next(0, numbers.Length);
            int index1 = rand.Next(0, numbers.Length);
            int index2 = rand.Next(0, numbers.Length);

            while (index1 == index0)
            {
                index1 = rand.Next(0, numbers.Length);
            }
            while (index2 == index1 || index2 == index0)
            {
                index2 = rand.Next(0, numbers.Length);
            }

            numbers[index0] = temp0;
            numbers[index1] = temp1;
            numbers[index2] = temp2;
            return numbers;


        }
    }
}
