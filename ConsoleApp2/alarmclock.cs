using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ConsoleApp2
{
    internal class alarmclock
    {
        static int currenthour = 4;
        static int currentminute = 3;
        static int alarmhour = 8;
        static int alarmminute = 9;
        static bool isAlarmset = true;


        static int setCurrentime(int time, int minutes)
        {
            currenthour = time;
            currentminute = minutes;
            return 1;
        }
        static bool setAlarm(int time, int minutes)
        {
            alarmhour = time;
            alarmminute = minutes;
            isAlarmset = true;
            return true;


        }


        static int incrementTime()
        {
            currentminute++;
            if(currentminute == 60)
            {
                currentminute = 0;
                currenthour = currenthour + 1;
                if (currenthour == 24)
                {
                    currenthour = 0;

                }
            }
            return currentminute;


        }



        static void triggerAlarm()
        {

            Console.WriteLine("Alarm time wake up");
            isAlarmset = false;

        }


        static void checkalarm()
        {
            if(isAlarmset && currenthour == alarmhour && currentminute == alarmminute)
            {
                triggerAlarm();

            }
          
        }


        static void Main(string[] args)
        {


            while (true)
            {
                checkalarm();
            }
        }



    }
}
