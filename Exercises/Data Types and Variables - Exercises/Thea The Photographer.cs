using System;

namespace TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int N = int.Parse(Console.ReadLine());
            int FT = int.Parse(Console.ReadLine());
            byte FF = byte.Parse(Console.ReadLine());
            int UT = int.Parse(Console.ReadLine());

            //Calculations
            var filterPictures =(long)Math.Ceiling(N*FF/100d);
            var filterPictures_Time = (long)filterPictures * UT;
            var totalFilterTime = (long)N * FT;
            var total = totalFilterTime + filterPictures_Time;
            TimeSpan time = TimeSpan.FromSeconds((double)total);

            //Output
            Console.WriteLine("{0}:{1:D2}:{2:D2}:{3:D2}", time.Days, time.Hours, time.Minutes, time.Seconds);
        }
    }
}