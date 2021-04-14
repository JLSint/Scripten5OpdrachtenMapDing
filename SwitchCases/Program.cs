using System;

namespace SwitchCases
{
    class Program
    {
        #region DaysOfTheWeek
        enum WeekDays { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
        #endregion
        static void Main(string[] args)
        {
            WeekDays today;

            today = WeekDays.Thursday;

            switch (WeekDays)
            {
                case WeekDays.Monday:
                    {
                        Console.WriteLine("Today, it's monday");
                        break;
                    }
                case WeekDays.Tuesday:
                    {

                        break;
                    }
                case WeekDays.Wednesday:
                    {

                        break;
                    }
                case WeekDays.Thursday:
                    {

                        break;
                    }
                case WeekDays.Friday:
                    {

                        break;
                    }
                case WeekDays.Saturday:
                    {

                        break;
                    }
                case WeekDays.Sunday:
                    break;
                default:
                    break;
            }

        }
    }
}
