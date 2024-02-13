using System;
namespace Clock
{
    class MyTime
    {


        private int hour = 0;
        private int minute = 0;
        private int second = 0;

        public MyTime()
        {

        }


        public MyTime(int hour, int minute, int second)
        {

            SetTime(hour, minute, second);
            

        }

        public void SetTime(int hour, int minute, int second)
        {
            
            SetHour(hour);
            SetMinute(minute);
            SetSecond(second);

        }

        public void SetHour(int hour)
        {
            if (hour < 24 && hour >= 0)
            {
                this.hour = hour;
            }
            else
            {
                Console.WriteLine("Only values between 0 and 24 are valid as an hour input!!");
            }
        }

        public void SetMinute(int minute)
        {
            if (minute < 60 && minute >= 0)
            {
                this.minute = minute;
            }
            else
            {
                Console.WriteLine("Only values between 0 and 60 are valid as minute input");
            }
  
        }

        public void SetSecond(int second)
        {
            if (second < 60 && second >= 0)
            {
                this.second = second;
            }
            else
            {
                Console.WriteLine("Only values between 0 and 60 are valid as a second input");
            }
        }

        public int GetHour()
        {
            return hour;
        }

        public int GetMinute()
        {
            return minute;
        }

        public int GetSecond()
        {
            return second;
        }


        new public string ToString()
        {

            return hour.ToString("00") + ":" + minute.ToString("00") + ":" + second.ToString("00");

        }

        public MyTime NextSecond()
        {
            second++;
            if (second > 59)
            {
                second = 0;
                NextMinute();
                return this;
            }
            else
            {
                return this;
            }

        }

        public MyTime NextMinute()
        {
            minute++;
            if (minute > 59)
            {

                minute = 0;
                NextHour();
                return this;

            }
            else
            {
                return this;
            }
        }

        public MyTime NextHour()
        {
            hour++;
            if (hour >  23)
            {

                hour = 0;
                return this;

            }
            else
            {
                return this;
            }
        }

        public MyTime PreviousSecond()
        {
            second--;

            if (second < 0)
            {
                second = 59;
                PreviousMinute();
                return this;
            }
            else
            {
                return this;
            }

        }

        public MyTime PreviousMinute()
        {
            minute--;

            if (minute < 0)
            {
                minute = 59;
                PreviousHour();
                return this;
            }
            else
            {
                return this;
            }

        }

        public MyTime PreviousHour()
        {
            hour--;

            if (hour < 0)
            {
                hour = 23;
                return this;
            }
            else
            {
                return this;
            }

        }







    }
}
