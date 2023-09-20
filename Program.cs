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
        }
    }
}
