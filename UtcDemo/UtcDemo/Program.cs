using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtcDemo
{
    class Program
    {
        /// <summary>
        /// main
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string strDate = "2015-11-14T21:29:10.8400000Z";

            DateTime convertedDate = DateTime.Parse(strDate);

            var utcTime = convertedDate.ToUniversalTime();

            Console.WriteLine(convertedDate.Kind);

            DateTime date1 = new DateTime(1986, 11, 14, 3, 30, 0, DateTimeKind.Local);
            TimeZoneInfo info = TimeZoneInfo.Local;

            bool isDaylight = info.IsDaylightSavingTime(date1);

            var utcTime2 =date1.ToUniversalTime();

            DateTime convertedDate1 = DateTime.SpecifyKind(
                                        DateTime.Parse(strDate),
                                        DateTimeKind.Utc);

            Console.Read();
        }
    }
}
