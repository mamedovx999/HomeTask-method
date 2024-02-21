using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace HomeTask_method
{
    internal class Program
    {
        static void Main(string[] args)
        {  //Task1
           // Console.WriteLine(Calculate(50, 2));
           //Task2
           //int[]numbers = {100,550,23,45,67,99};
           //Console.WriteLine(SumArrofelement(numbers));
           //Task3
           // int n = 10;
           //int m = 26;
           // Console.WriteLine(numOfOdds(n,m));
           //Tasl4
           // Console.WriteLine(IsPrime(25));
           //Task 5
            int n = 16;
            Console.WriteLine(IsPrime(n));


        }



        //task1
        static int Calculate(int x, int y)
        {
            return x / y;

        }
        //Task2
        static int SumArrofelement(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        //Task3
        static int numOfOdds(int n, int m)
        {
            int count = 0;
            for (int i = n; i < m; i++)
            {
                if (i % 2 == 1)
                {
                    count++;
                }

            }
            return count;
        }

        static string IsPrime(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % 1 == 0)
                    return "murekkebdir";

            }
            return "sadedir";
        }
        static string IsPrime(double n)
        {
            while (n > 0)
            {
                n = n / 2;
                if (n == 1)
                    return "ededi 2-nin quvvetidir";
            }
            return "ededi 2-nin quvveti deyil";





        }



    }
}




