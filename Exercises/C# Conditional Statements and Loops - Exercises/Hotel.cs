using System;

class Hotel
{
    static void Main(string[] args)
    {
        var month = Console.ReadLine();
        var nights = int.Parse(Console.ReadLine());

        if (month == "May" || month == "October")
        {
            if (nights > 7)
            {
                if (month == "October") Console.WriteLine("Studio: {0:f2} lv.", (nights - 1) * 50 * 0.95);
                else Console.WriteLine("Studio: {0:f2} lv.", nights * 50 * 0.95);
            }
            else
            {
                Console.WriteLine("Studio: {0:f2} lv.", nights * 50);
            }
            Console.WriteLine("Double: {0:f2} lv.", nights * 65);
            Console.WriteLine("Suite: {0:f2} lv.", nights * 75);
        }
        else if (month == "June" || month == "September")
        {
            if (nights > 7 && month == "September") Console.WriteLine("Studio: {0:f2} lv.", (nights - 1) * 60);
            else Console.WriteLine("Studio: {0:f2} lv.", nights * 60);

            if (nights > 14) Console.WriteLine("Double: {0:f2} lv.", nights * 72 * 0.9);
            else Console.WriteLine("Double: {0:f2} lv.", nights * 72);


            Console.WriteLine("Suite: {0:f2} lv.", nights * 82);
        }
        else if (month == "July" || month == "August" || month == "December")
        {
            Console.WriteLine("Studio: {0:f2} lv.", nights * 68);
            Console.WriteLine("Double: {0:f2} lv.", nights * 77);

            if (nights > 14) Console.WriteLine("Suite: {0:f2} lv.", nights * 89 * 0.85);
            else Console.WriteLine("Suite: {0:f2} lv.", nights * 89);

        }

    }
}