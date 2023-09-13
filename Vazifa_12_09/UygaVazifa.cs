
namespace Vazifa_12_09
{
    public class UygaVazifa
    {

        static void   Vazifa1(int n)
        {
            for (int i = 0; i < n * 2 - 1; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i == n - 1) || (i == 0 || j == 0) && i < n || (i == n * 2 - 2 || j == n - 1) && i >= n)
                        Console.Write("S ");
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }

        static bool Vazifa2(int n)
        {
            
            if(n == Vazifa3(n))
            {
                return true;
            }
            else
            { 
                return false; 
            }

        }

        static int Vazifa3(int n)
        {
            int m = 0,k=1;
            if (n < 0) k = -1;
            n = Math.Abs(n);
            while(n>0)
            {
                m = m * 10 + n % 10;
                n/= 10;
            }
            m *= k;
            return m;
        }

        static void Vazifa4(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j < (n + 1) / 2 - 1 || (n - j + i < (n + 1) / 2) || (n - i + j < (n + 1) / 2) || (n - i + n - j < (n + 1) / 2 + 1))
                    {

                        Console.Write("  ");
                    }

                    else
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Vazifa 1 uchun o`lcham sonini kiriting :");
            int n = Convert.ToInt32(Console.ReadLine());
            Vazifa1(n);

            Console.WriteLine("\nSon kiriting : ");
            n= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{n} soni {(Vazifa2(n)?"palindrom":"palindrom emas")}");


            Console.WriteLine("\nSon kiriting : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{n} soni teskarisi {Vazifa3(n)}");

            Console.WriteLine("Vazifa 4 uchun o`lcham sonini kiriting :");
            n = Convert.ToInt32(Console.ReadLine());
            Vazifa4(n);

        }
    }
}