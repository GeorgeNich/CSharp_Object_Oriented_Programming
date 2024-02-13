using System;

namespace Clock
{
    class TestMyTime
    {
        static void Main(string[] args)
        {
            MyTime GeorgesTime = new MyTime(00, 00, 00);
            //Current time
            Console.WriteLine(GeorgesTime.ToString());

            //future time
            Console.WriteLine(GeorgesTime.NextSecond().ToString());
            Console.WriteLine(GeorgesTime.NextMinute().ToString());
            Console.WriteLine(GeorgesTime.NextHour().ToString());
            Console.WriteLine(GeorgesTime.NextHour().ToString()); 

            //Past Time
            Console.WriteLine(GeorgesTime.PreviousHour().ToString());
            Console.WriteLine(GeorgesTime.PreviousMinute().ToString());
            Console.WriteLine(GeorgesTime.PreviousSecond().ToString());

            // set time
            GeorgesTime.SetHour(2);
            GeorgesTime.SetMinute(33);
            GeorgesTime.SetSecond(77);
            Console.WriteLine(GeorgesTime.ToString());
            GeorgesTime.SetTime(41, 72, 97);
            Console.WriteLine(GeorgesTime.ToString());

            // Get functions

            Console.WriteLine(GeorgesTime.GetHour());
            Console.WriteLine(GeorgesTime.GetMinute());
            Console.WriteLine(GeorgesTime.GetSecond());








        }
    }
}
