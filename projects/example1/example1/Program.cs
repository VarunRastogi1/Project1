using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace example1
{
    class Person
    {
        public int MyAge(DateTime mydob)
        {
            if (Convert.ToDateTime(DateTime.Now) >= mydob)
            {
                int age = Convert.ToInt32(Convert.ToInt32(DateTime.Now.Year) - Convert.ToInt32(mydob.Year));
                if (age > 134)
                {
                    Console.WriteLine("Not Possible");
                }
                else
                {
                    if (DateTime.Now.Month == mydob.Month && DateTime.Now.Day == mydob.Day)
                    {
                        Console.WriteLine("Happy Birthday");
                    }
                    else
                    {
                        Console.WriteLine("");
                    }

                }
                return age;
            }

            else
            {
                throw new Exception("Not yet born");
            }
        }

        
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter year");
            string year = Console.ReadLine();

            Console.WriteLine("Enter month");
            string month = Console.ReadLine();

            Console.WriteLine("Enter day");
            string day = Console.ReadLine();

            DateTime dob = DateTime.Parse(month + '-' + day + '-' + year);

            Person Son = new Person();
            Console.WriteLine(Son.MyAge(dob));
            Console.ReadLine();

        }
    }
}
