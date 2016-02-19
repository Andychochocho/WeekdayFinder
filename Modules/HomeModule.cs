using Nancy;
using System.Collections.Generic;
using WeekDayFinders;
using System;

namespace WeekdayFinders
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
          string model = "";
          return View["index.cshtml", model];
        };
        Post["/"] = _ =>
        {
          return View["index.cshtml", WeekDayFinder.FindWeekDay(Request.Form["month"], Request.Form["day"], Request.Form["year"])];
        };
    }
  }
}
