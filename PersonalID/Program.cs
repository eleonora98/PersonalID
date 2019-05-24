using System;

namespace PersonalID
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("Input your ID number here to validate it: ");
                string id;
                int year;
                int month;
                int day;
                int gender;
                try
                {
                    id = Console.ReadLine();
                    Console.WriteLine(ValidationID.ValidateID(id, out year, out month, out day, out gender));

                }
                catch (FormatException)
                {
                    Console.WriteLine("Please, input only digits for your ID number!");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Please, input 10 digits for your ID number!");
                }

            }

        }

    }
}
