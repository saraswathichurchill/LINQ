using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime LeaveFrom = DateTime.ParseExact("01/01/2014", "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime LeaveTo = DateTime.ParseExact("03/01/2016", "dd/MM/yyyy", CultureInfo.InvariantCulture);
            TimeSpan dtspan = LeaveTo - LeaveFrom;
            double diff = dtspan.TotalDays;

            DateTime aDay = DateTime.Now;
            TimeSpan aMonth = new System.TimeSpan(30, 0, 0, 0);
            DateTime aDayAfterAMonth = aDay.Add(aMonth);
            DateTime aDayBeforeAMonth = aDay.Subtract(aMonth);
            Console.WriteLine("{0:dddd}", aDayAfterAMonth);
            Console.WriteLine("{0:dddd}", aDayBeforeAMonth);
            int days = DateTime.DaysInMonth(2002, 2);
            Console.WriteLine(days);
            Console.ReadKey();
			int y1 = LeaveFrom.Year;
            int y2 = LeaveTo.Year;

            int ydiff = y2 - y1;

            int in2 = LeaveTo.Month;
            int in1 = LeaveFrom.Month;

             int input1m =(ydiff* 12) - in1; 

            int diff = in2-in1;

            Console.WriteLine($"Month Difference: {diff}");

        }
    }
}

