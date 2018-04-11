using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimSnyderLab2_2._0
{
    class Program
    {
        static void Main(string[] args)

        {

            //Accept the dates as user inputs

            Console.WriteLine("Please Enter a Date and Time in Format yyyy-mm-dd 00:00 for start date: ");

            string entry1 = Console.ReadLine();

            Console.WriteLine("Please Enter Another Date and Time in yyyy-mm-dd 00:00 format for end date: ");

            string entry2 = Console.ReadLine();



            //Convert the entries to DateTimes

            DateTime dateStart = DateTime.Parse(entry1);

            DateTime dateEnd = DateTime.Parse(entry2);



            TimeSpan span = dateEnd.Subtract(dateStart);

            Console.WriteLine("Time Difference (minutes): " + span.Minutes);

            Console.WriteLine("Time Difference (hours): " + span.Hours);

            Console.WriteLine("Time Difference (days): " + span.Days);
            Console.WriteLine("Press Enter to end. ");

            Console.ReadLine();
        }

    }

}