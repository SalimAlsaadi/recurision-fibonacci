namespace recursion_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Console.WriteLine("power of this number is " + power(3, 2));
            Console.WriteLine(recursionFib(8));
            static int powerByuseForLoop(int num, int pow)
            {    //this function for find power of number by using for loop

                int value = num;
                for (int i = 2; i <= pow; i++)
                {
                    value = value * num;
                }
                return value;
            }



            static int power(int num, int pow)//this function for find power of number by using recursion method
            {
                if (pow == 0)
                {
                    return 1;
                }

                else if (pow == 1)
                {
                    return num;
                }

                return num * power(num, pow - 1);
            }


            static int fib(int n)
            {
                int secondLastTerm = 0;
                int lastTerm = 1;
                int nextTerm = 0;

                for (int i = 2; i <= n; i++)
                {

                    nextTerm = lastTerm + secondLastTerm;
                    secondLastTerm = lastTerm;
                    lastTerm = nextTerm;

                }
                return nextTerm;


            }

            

            static int recursionFib(int i)
            {



                if (i <= 1)
                {
                    return i;
                }
                else
                    return recursionFib(i - 1) + recursionFib(i - 2);
            }

        }
    }
}
