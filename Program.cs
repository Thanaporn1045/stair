using System;

namespace สอบกลางภาควันที่24
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            int width, height, num,i,j,k;
            a = Console.ReadLine();
            width = int.Parse(Console.ReadLine());
            height = int.Parse(Console.ReadLine());
            num = int.Parse(Console.ReadLine());

            for (k = 1; k <= num; k++)
            {
                for (i = 1; i <= height ; i++)
                {
                    for (j = 1; j <= width *k; j++)
                    { Console.Write(a); }
                    Console.WriteLine();
                }
            }
        }
    }
}
