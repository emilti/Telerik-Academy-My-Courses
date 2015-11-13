using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DateTimeConverter
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class DateTimeService : IDateTimeService
    {

        public string GetDayOfWeekInBulgarian(DateTime date)
        {
            string dayOfWeekInEngish = date.ToString("ddd");


            // var culture = new System.Globalization.CultureInfo("bg-BG");
            // var day = culture.DateTimeFormat.GetDayName(date.DayOfWeek);
            string day = string.Empty;
            switch (dayOfWeekInEngish)
            {
                case "Mon": day = "Понеделник"; break;
                case "Tue": day = "Вторник"; break;
                case "Wed": day = "Сряда"; break;
                case "Thu": day = "Четвъртък"; break;
                case "Fri": day = "Петък"; break;
                case "Sat": day = "Събота"; break;
                case "Sun": day = "Неделя"; break;
            }

            return day;
        }
    }
}
