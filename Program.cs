namespace Playing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initializing DateTime object
            DateTime myBirth = new DateTime(2003, 08, 10);
            Console.WriteLine("My birthday: " + myBirth);

            // Current date and time
            DateTime timeNow = DateTime.Now;
            Console.WriteLine("\nNow: " + timeNow);

            // Current date
            DateTime today = DateTime.Today;
            Console.WriteLine("\nTodays date: " + today);

            // Timespan(hrs, mins, secs)
            TimeSpan ts = new TimeSpan(24,0,0);
            DateTime newDate = myBirth.Add(ts);
            Console.WriteLine("\nMy birtday + 24 hrs: " + newDate);

            //________________________________________________

            // Calculating my age
            DateTime todayDate = DateTime.Now;
            int todayYear = todayDate.Year;
            DateTime myBday = new DateTime(2003, 08, 10);
            int bdayYear = myBday.Year;

            int age = todayYear - bdayYear;
            Console.WriteLine("\nMy age: " + age);
            //________________________________________________

            // DATE WITHOUT ANNOYING TIME
            DateOnly birthday = new DateOnly(2003, 08, 10);
            Console.WriteLine("\nAlso my birthday but date only: " + birthday);

            // You can subtract dates
            DateTime date = new DateTime(502, 04, 02);
            TimeSpan dateSubtracted = myBirth.Subtract(date);
            Console.WriteLine("\nMy birthday subtracted by an amount of time: " + dateSubtracted);

            //_______________________________________________

            // Program that triggers output every 2 seconds until the given time
            
            DateTime pasttime = new DateTime(2024, 11, 18, 11, 11, 0);

            var timer = new System.Timers.Timer();
            timer.Interval = 2000;
            timer.Elapsed += TriggerEvent;

            static void TriggerEvent(object source, System.Timers.ElapsedEventArgs e)
            {
                Console.WriteLine("\nIT'S NOT 11:11 YET", e.SignalTime);
            }

            while (DateTime.Now < pasttime)
            {
                timer.Start();
            }
            timer.Stop();
            Console.WriteLine("\nIT'S 11:11! YAAAAAAYY!");

                












        }
    }
}

