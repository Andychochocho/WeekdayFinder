using System;
using System.Collections.Generic;
namespace WeekDayFinders
{
  public class WeekDayFinder
  {
      private string _day;
      private string _month;
      private string _year;

    //constructor//
    public WeekDayFinder()
    {

    }



    public static string FindWeekDay(double month, double day, double year)
    {
       double daysSinceAnchor = ((year - 1800) * 365) + Math.Floor((year - 1800)/4) - Math.Floor((year - 1800)/100) + Math.Floor((year-1800)/400) + WeekDayFinder.findDaysAMonth(month - 1) + day;
       if (year % 400 == 0 && year % 100 == 0 || year % 4 == 0 && year % 100 != 0 && year % 400 == 0)
       {
        Console.WriteLine("This is the test month {0}", month);
        if(month >= 3)
          {
            daysSinceAnchor += 1;
          }
       }

       double weekdayNumber = daysSinceAnchor % 7;
       Console.WriteLine("Weekday Number: " + weekdayNumber);

       Dictionary<double, string> testWeek = new Dictionary<double, string> {};
       testWeek.Add(1, "Wednesday");
       testWeek.Add(2, "Thursday");
       testWeek.Add(3, "Friday");
       testWeek.Add(4, "Saturday");
       testWeek.Add(5, "Sunday");
       testWeek.Add(6, "Monday");
       testWeek.Add(0, "Tuesday");

       string output = "FAILURE";

       foreach (KeyValuePair<double, string> test in testWeek)
       {
         if( weekdayNumber == test.Key)
         {
           Console.WriteLine("Into loop!");
           output = test.Value;
         }
       }

       return output;
    }

    public static double findDaysAMonth(double month)
    {
      Dictionary<double, double> testMonth = new Dictionary<double, double> {};
      testMonth.Add(1, 31);
      testMonth.Add(2, 28);
      testMonth.Add(3, 31);
      testMonth.Add(4, 30);
      testMonth.Add(5, 31);
      testMonth.Add(6, 30);
      testMonth.Add(7, 31);
      testMonth.Add(8, 31);
      testMonth.Add(9, 30);
      testMonth.Add(10, 31);
      testMonth.Add(11, 30);
      testMonth.Add(12, 31);

      double output = 0;

      foreach ( KeyValuePair<double, double> test in testMonth)
      {
        if( month >= test.Key)
        {
          output += test.Value;
        }
      }
      return output;

    }
  }
}
