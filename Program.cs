namespace HomeTask_3.NET
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введiть цiле число A: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Введiть цiле число B (воно має бути меншим, нiж A): ");
            int B = int.Parse(Console.ReadLine());

            if (A > B)
            {
                do
                {
                    Console.WriteLine(A);
                    A--;
                }
                while (A >= B);
            }
            else 
            {
                Console.Write("\nВи ввели неправильнi вхiднi данi! (число A менше за B)");
            }
        }
    }
}
