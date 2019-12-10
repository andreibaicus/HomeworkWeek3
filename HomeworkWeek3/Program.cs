using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkWeek3
{
    class Program
    {
        public enum Genders
        {
            Male,
            Female,
            Other
        }

        static void Main(string[] args)
        {
            int year, month, day;

            Console.WriteLine("Enter your birth date");
            Console.WriteLine("year: ");
            String consoleString = Console.ReadLine();
            year = int.Parse(consoleString);

            Console.WriteLine("month: ");
            consoleString = Console.ReadLine();
            month = int.Parse(consoleString);

            Console.WriteLine("day: ");
            consoleString = Console.ReadLine();
            day = int.Parse(consoleString);

            DateTime birthDate = new DateTime(year, month, day);
            Console.WriteLine(birthDate.ToString("dd/MM/yyyy"));

            DateTime now = DateTime.Now;
            TimeSpan diff = now - birthDate;

            int age = (int)(diff.TotalDays / 365);
            
            Console.WriteLine("Gender(M/F): ");
            consoleString = Console.ReadLine();
            Genders gender;

            if (consoleString.Equals("M") || consoleString.Equals("m"))
            {
                gender = Genders.Male;
            }
            else if (consoleString.Equals("F") || consoleString.Equals("f"))
            {
                gender = Genders.Female;
            }
            else
            {
                gender = Genders.Other;
            }

            if (gender != Genders.Other)
            {
                if (gender == Genders.Male)
                {
                    if (age < 65)
                    {
                        Console.WriteLine("You will retire at 65 years old.");
                    }
                    else
                    {
                        Console.WriteLine("You are retired.");
                    }
                }

                if (gender == Genders.Female)
                {
                    if (age < 63)
                    {
                        Console.WriteLine("You will retire at 63 years old.");
                    }
                    else
                    {
                        Console.WriteLine("You are retired.");
                    }
                }
            }
                        
            Console.WriteLine($"Your age is : {age}");

        }
    }
}
