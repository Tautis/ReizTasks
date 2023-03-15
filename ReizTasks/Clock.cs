using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReizTasks
{
    class Clock
    {
        public void clock ()
        {
            Console.WriteLine("Enter the hour:");

            string hourInput = Console.ReadLine();
            Console.WriteLine("Enter the minute:");

            string minuteInput = Console.ReadLine();

            int hour = Convert.ToInt32(hourInput);
            int minute = Convert.ToInt32(minuteInput);

            hour *= 5;
            int res = hour - minute;
            res = Math.Abs(res / 5 * 30);
            if (res > 180)
            {
                res = 360 - res;
            }

            Console.WriteLine("the lesser angle in degrees is " + res);
        }
    }
}