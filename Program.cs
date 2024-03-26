using System;
namespace HomeTask_3.NET
{
    internal class Program
    {
        static void Main()
        {
            int A, B;

            do
            {
                Console.Write("Введiть цiле число A: ");
                A = int.Parse(Console.ReadLine());
                Console.Write("Введiть цiле число B (воно має бути меншим за перше): ");
                B = int.Parse(Console.ReadLine());

                if (A <= B)
                {
                    Console.WriteLine("Ви ввели неправильнi вхiднi данi! (число A менше за B)\n\n");
                }
            }
            while (A <= B);

            for (int i = A; i >= B; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
