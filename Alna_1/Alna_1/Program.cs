using System;

namespace Alna_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int h, m;

            //Valandu ivedimas
            Console.Write("iveskyte valanda (0-12): ");
            h = int.Parse(Console.ReadLine());

            if (h < 0 || h > 12)
            {
                Console.WriteLine("Neteisingai ivesta valanda!!!");
                Console.Write("Bandykite dar karta (0-12): ");
                h = int.Parse(Console.ReadLine());
            }

            //minuciu ivedimas
            Console.Write("iveskyte minutes (0-60): ");
            m = int.Parse(Console.ReadLine());
            if (m < 0 || m > 60)
            {
                Console.WriteLine("Neteisingai ivestos minutes!!!");
                Console.Write("Bandykite dar karta (0-60): ");
                m = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"{h} val., {m} min.");

            int trueHours = (m / 12) * 6;           //valandu kampas patikslinimas. kas 12min rodykle pasislenka
            int minutesAngle = m * 6;
            int hoursAngle = (h * 30) + trueHours; //tikslus valndu kampas

            
            // kampo apskaiciavimas
            int angle = Math.Abs(minutesAngle - hoursAngle);

            if (angle > 180)
            {
                int angle1 = 360 - angle;
                Console.WriteLine($"Maziausias kampas tarp rodykliu yra {angle1}");
            }
            else
            {
                Console.WriteLine($"Maziausias kampas tarp rodykliu yra {angle}");
            }

        }
    }
}
