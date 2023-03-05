using System;

namespace Check18Age
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Doğum tarixinizi daxil edin");
            int date = Convert.ToInt32(Console.ReadLine());
            if (date > 0 && date <= 2023)
            {
                if (date + 18 <= 2023)
                {
                    Console.WriteLine("Sizin 18 yaşınız tamam olub");
                }
                else
                {
                    Console.WriteLine("Sizin 18 yaşınız tamam olmayıb");
                }
            }
            else
            {
                Console.WriteLine("Tarix mənfi və ya 0 ola bilməz və ya 2023 dən böyük ola bilməz");
            }
            Console.Write("Ededi daxil edin: ");
            int eded = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (eded > 0)
            {
                sum += eded % 10;
                eded = (eded - eded % 10) / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
