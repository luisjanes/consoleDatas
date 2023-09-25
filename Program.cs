using System.Globalization;

namespace consoleDatas
{
    class Program
    {
        private static void Main(string[] args)
        {
            var data = new DateTime();
            Console.WriteLine(data);
            data = DateTime.Now;
            Console.WriteLine(data);
            data = DateTime.UtcNow;
            Console.WriteLine(data);

            data = new DateTime(1995, 03, 23, 16, 45, 00);
            Console.WriteLine(data);
            Console.WriteLine(data.Year);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Day);
            Console.WriteLine(data.DayOfYear);
            Console.WriteLine(data.DayOfWeek);
            Console.WriteLine((int)data.DayOfWeek);

            data = DateTime.UtcNow;

            var newDate = data.ToUniversalTime();
            Console.WriteLine(newDate);



            //you can use y for a month and year, yy for the two last numbers, yyyy for a full year
            var formatData = String.Format("{0:y}", data);
            Console.WriteLine(formatData);

            //also you can use M for the day and month

            formatData = String.Format("{0:M}", data);
            Console.WriteLine(formatData);

            //Also can use d for full data, without hour
            formatData = String.Format("{0:d}", data);
            Console.WriteLine(formatData);

            formatData = String.Format("{0:yyyy/MM/dd}", data);
            Console.WriteLine(formatData); 
            
            formatData = String.Format("{0:dd/MM/yyyy hh:mm:ss:ff zzz}", data);
            Console.WriteLine(formatData);

            formatData = String.Format("{0:t}", data);
            Console.WriteLine(formatData);

            formatData = String.Format("{0:d}", data);
            Console.WriteLine(formatData);

            formatData = String.Format("{0:T}", data);
            Console.WriteLine(formatData);

            formatData = String.Format("{0:D}", data);
            Console.WriteLine(formatData);

            formatData = String.Format("{0:f}", data);
            Console.WriteLine(formatData);

            formatData = String.Format("{0:g}", data);
            Console.WriteLine(formatData);

            formatData = String.Format("{0:r}", data);
            Console.WriteLine(formatData);

            formatData = String.Format("{0:R}", data);
            Console.WriteLine(formatData);

            formatData = String.Format("{0:s}", data);
            Console.WriteLine(formatData);

            formatData = String.Format("{0:u}", data);
            Console.WriteLine(formatData);


            //Add hours, months, years
            Console.WriteLine("Data controle");
            Console.WriteLine(data);
            Console.WriteLine(data.AddDays(12));
            Console.WriteLine(data.AddMonths(12));
            Console.WriteLine(data.AddYears(12));
            Console.WriteLine(data.AddHours(12));
            Console.WriteLine(data.AddDays(-12));

            var datePlus = data.AddDays(12);
            Console.WriteLine(datePlus);

            //Compare datas
            if(data.Year == DateTime.Now.Year)
            {
                Console.WriteLine("Is equal");
            } else
            {
                Console.WriteLine("Is different");
            }

            //CultureInfo

            var pt = new CultureInfo("pt-PT");
            var br = new CultureInfo("pt-BR");
            var en = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");
            var atual = CultureInfo.CurrentCulture;
            Console.WriteLine(DateTime.Now.ToString("D", pt));
            Console.WriteLine(DateTime.Now.ToString("D", br));
            Console.WriteLine(DateTime.Now.ToString("D", en));
            Console.WriteLine(DateTime.Now.ToString("D", de));
            Console.WriteLine(DateTime.Now.ToString("D", atual));

            //timeZone
            var dateTime = DateTime.UtcNow;
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(dateTime);
            Console.WriteLine(dateTime.ToLocalTime());

            var timeZoneTokyo = TimeZoneInfo.FindSystemTimeZoneById("Asia/Tokyo");
            Console.WriteLine(timeZoneTokyo);

            var hourTokyo = TimeZoneInfo.ConvertTimeFromUtc(dateTime, timeZoneTokyo);
            Console.WriteLine(hourTokyo);

            //var timezones = TimeZoneInfo.GetSystemTimeZones();
            //foreach ( var timezone in timezones )
            //{
            //    Console.WriteLine(timezone.Id);
            //    Console.WriteLine(timezone);
            //    Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dateTime, timezone));
            //    Console.WriteLine("------------");
            //}

            //timeSpan

            var timeSpan = new TimeSpan(3, 10, 10, 10);
            Console.WriteLine(timeSpan);

            var timeSpan2 = new TimeSpan(2, 08, 5 , 6);
            Console.WriteLine(-timeSpan2+timeSpan);
            Console.WriteLine(timeSpan2);
            Console.WriteLine(timeSpan2.Add(new TimeSpan(20,0,0)));


            //Métodos
            Console.WriteLine(DateTime.DaysInMonth(2020, 2));
            Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));
            Console.WriteLine(DateTime.Now.IsDaylightSavingTime());

            //Verificar se é dia da semana
            static bool IsWeekend(DayOfWeek today)
            {
                return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
            }
        }
    }
}
