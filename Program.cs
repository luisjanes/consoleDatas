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
        }
    }
}
