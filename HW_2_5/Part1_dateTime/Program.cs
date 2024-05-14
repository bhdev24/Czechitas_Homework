using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_dateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Vypiš aktuální datum a čas, nemusíš řešit, v kterém je to časovém pásmu.
            // 2. Vytvoř proměnnou typu DateTime a ulož do ní svoje datum narození. Potom vypiš, kolik dnů od té doby uteklo.

            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine($"The current time is: {currentDateTime}");
            DateTime DOB = new DateTime(1997, 9,1);
            TimeSpan difference = currentDateTime - DOB;
            int differenceInDays = difference.Days;

            Console.WriteLine($"The difference in days between current date and DOB is: {differenceInDays}");
            Console.ReadLine();
        }
    }
}
