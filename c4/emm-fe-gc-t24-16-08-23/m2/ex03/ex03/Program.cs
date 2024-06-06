namespace Milestone3
{
    public class Program
    {
        static void Main(string[] args)
        {
            int hour = 0;
            int minutes = 0;
            int seconds = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"{hour:D2}:{minutes:D2}:{seconds:D2}");

                seconds++;
                if (seconds == 60)
                {
                    seconds = 0;
                    minutes++;
                    if (minutes == 60)
                    {
                        minutes = 0;
                        hour++;
                        if (hour == 24)
                        {
                            hour = 0;
                        }
                    }
                }

                Thread.Sleep(1000);
            }
        }
    }
}
