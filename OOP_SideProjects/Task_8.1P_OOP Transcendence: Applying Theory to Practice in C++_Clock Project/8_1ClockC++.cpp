// 8_1ClockC++.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
#include <string> 
#include <iostream>
#include <iomanip>


// :)
using namespace std;

class MyTime
{
private:

    int myhour = 0;
    int myminute = 0;
    int mysecond = 0;

public:

    MyTime()
    {

    }


    MyTime(int hour, int minute, int second)
    {

        SetTime(hour, minute, second);


    }

    void SetTime(int hour, int minute, int second)
    {

        SetHour(hour);
        SetMinute(minute);
        SetSecond(second);

    }

    void SetHour(int hour)
    {
        if (hour < 24 && hour >= 0)
        {
            myhour = hour;
        }
        else
        {
            std::cout << ("Only values between 0 and 24 are valid as an hour input!!");
        }
    }

    void SetMinute(int minute)
    {
        if (minute < 60 && minute >= 0)
        {
            myminute = minute;
        }
        else
        {
            std::cout << ("Only values between 0 and 60 are valid as minute input");
        }

    }

    void SetSecond(int second)
    {
        if (second < 60 && second >= 0)
        {
            mysecond = second;
        }
        else
        {
            cout << ("Only values between 0 and 60 are valud as an second input");
        }
    }

    int GetHour()
    {
        return myhour;
    }

    int GetMinute()
    {
        return myminute;
    }

    int GetSecond()
    {
        return mysecond;
    }



    string ToString()
    {

        string hour = to_string(myhour);
        string minute = to_string(myminute);
        string second = to_string(mysecond);

        return hour + ":" + minute + ":" + second;


    }

public: MyTime NextSecond()
{
    mysecond++;
    if (mysecond > 59)
    {
        mysecond = 0;
        NextMinute();
        return MyTime(myhour, myminute, mysecond);
    }
    else
    {
        return MyTime(myhour, myminute, mysecond);
    }

}

public: MyTime NextMinute()
{
    myminute++;
    if (myminute > 59)
    {

        myminute = 0;
        NextHour();
        return MyTime(myhour, myminute, mysecond);

    }
    else
    {
        return MyTime(myhour, myminute, mysecond);
    }
}

public: MyTime NextHour()
{
    myhour++;
    if (myhour > 23)
    {

        myhour = 0;
        return MyTime(myhour, myminute, mysecond);

    }
    else
    {
        return MyTime(myhour, myminute, mysecond);
    }
}

public: MyTime PreviousSecond()
{
    mysecond--;

    if (mysecond < 0)
    {
        mysecond = 59;
        PreviousMinute();
        return MyTime(myhour, myminute, mysecond);
    }
    else
    {
        return MyTime(myhour, myminute, mysecond);
    }

}

public: MyTime PreviousMinute()
{
    myminute--;

    if (myminute < 0)
    {
        myminute = 59;
        PreviousHour();
        return MyTime(myhour, myminute, mysecond);
    }
    else
    {
        return MyTime(myhour, myminute, mysecond);
    }

}

public: MyTime PreviousHour()
{
    myhour--;

    if (myhour < 0)
    {
        myhour = 23;
        return MyTime(myhour, myminute, mysecond);
    }
    else
    {
        return MyTime(myhour, myminute, mysecond);
    }

}
};

int main()
{
    cout << "Hello World!\n";
    MyTime GeorgesTime(22, 11, 33);

    GeorgesTime = GeorgesTime.NextHour();

    cout << (GeorgesTime.ToString()) << endl;

    cout << (GeorgesTime.NextSecond().ToString()) << endl;
    cout << (GeorgesTime.NextMinute().ToString()) << endl;
    cout << (GeorgesTime.NextHour().ToString()) << endl;
    cout << setfill('0') << setw(2) << (GeorgesTime.NextHour().ToString()) << endl;

    //Past Time
    cout << (GeorgesTime.PreviousHour().ToString()) << endl;
    cout << (GeorgesTime.PreviousMinute().ToString()) << endl;
    cout << (GeorgesTime.PreviousSecond().ToString()) << endl;

    // set time
    GeorgesTime.SetHour(2);
    GeorgesTime.SetMinute(33);
    GeorgesTime.SetSecond(77);
    cout << (GeorgesTime.ToString()) << endl;
    GeorgesTime.SetTime(41, 72, 97);
    cout << (GeorgesTime.ToString()) << endl;

    // Get functions

    cout << (GeorgesTime.GetHour()) << endl;
    cout << (GeorgesTime.GetMinute()) << endl;
    cout << (GeorgesTime.GetSecond()) << endl;
    
}


