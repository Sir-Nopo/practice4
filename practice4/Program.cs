using System;

namespace practice4
{
    class Program
    {
        //MohammadReza Fatahi
        //tamrin4
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c = 0;
            first:
            Console.WriteLine("adad mored nazar baraye donbale ra vared konid");
            string adad = Console.ReadLine();
            int n = int.Parse(adad);
            if (n<0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("adad bozorgtar az 0 !");
                Console.ForegroundColor = ConsoleColor.White;
                goto first;
            }
            else if (n==1 || n==2)
            {
                Console.WriteLine(" ");
                Console.WriteLine("1");
            }
            else
            {
                for(int i = 0; i < n; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                    Console.WriteLine(c);
                }
            }
            
        }
    }
}
