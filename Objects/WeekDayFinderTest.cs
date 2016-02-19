using Xunit;
using WeekDayFinders;
using System;
using System.Collections.Generic;


namespace WeekDayFinderTest
{
  public class WeekDayFinderTester
  {
    [Fact]
    public void IsDate_forDateBeingJanSecond1800_thursday()
    {
      double year = 1800;
      double month = 1;
      double day = 2;
      Assert.Equal("Thursday", WeekDayFinder.FindWeekDay(month, day, year));
    }
    [Fact]
    public void IsDate_forDateBeingMarchFirst1800_saturday()
    {
      double year = 1800;
      double month = 3;
      double day = 1;
      Assert.Equal("Saturday", WeekDayFinder.FindWeekDay(month, day, year));
    }

    [Fact]
    public void IsDate_forDateBeingDecTwentyFifth1804_tuesday()
    {
      double year = 1804;
      double month = 12;
      double day = 25;
      Assert.Equal("Tuesday", WeekDayFinder.FindWeekDay(month, day, year));
    }

    [Fact]
    public void IsDate_forDateBeingDecTwentyFifth1900_tuesday()
    {
      double year = 1900;
      double month = 12;
      double day = 25;
      Assert.Equal("Tuesday", WeekDayFinder.FindWeekDay(month, day, year));
    }
    [Fact]
    public void IsDate_forDateBeing_wednesday()
    {
      double year = 2000;
      double month = 3;
      double day = 1;
      Assert.Equal("Wednesday", WeekDayFinder.FindWeekDay(month, day, year));
    }

  }
}
