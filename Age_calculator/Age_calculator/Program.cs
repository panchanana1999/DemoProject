using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_calculator
{
    internal class Program
    {
        class person
        {
            private string first_name;
            private string last_name;
            private DateTime dob;
            public string FirstName
            {
                get
                {
                    return first_name;
                }
                set
                {
                    first_name = value;
                }
            }
            public string LastName
            {
                get { return last_name; }
                set { last_name = value; }
            }
            public DateTime Dob
            {
                get { return dob; }
                set
                {
                    dob = value;
                }   
            }
            public int Adult()
            {
                int age = 0;
                age = DateTime.Now.Year - dob.Year;
                if (DateTime.Now.DayOfYear < dob.DayOfYear)
                    age = age - 1;

                return age;
            }
            public void details()
            {
                Console.WriteLine("First Name: " + first_name);
                Console.WriteLine("Last Name: "+last_name);
            }

        }
        static void Main(string[] args)
        {
            person p = new person();
            Console.WriteLine("Enter first name ");

            p.FirstName=Console.ReadLine();
            Console.WriteLine("Enter Last Name ");
            p.LastName=Console.ReadLine();
            Console.WriteLine("Enter Date of Birth in yyyy/mm/dd format ");
            p.Dob = DateTime.Parse(Console.ReadLine());
            p.details();
            Console.WriteLine("The age is: "+p.Adult());
            if(p.Adult()>=18)
            {
                Console.WriteLine("The person is Adult");
            }
            else
            {
                Console.WriteLine("Child");
            }
            Console.ReadKey();

        }
    }
}
