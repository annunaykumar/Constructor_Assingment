using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Assingment
{
    internal class Person
    {
        // private backing fields for properties
        private String FirstName;
        private string LastName;
        private string Email;
        private DateTime Dob;

        public string SetfirstName
        {
            get
            {
                return FirstName;
            }
            set
            {
                FirstName = value;
            }
        }
        public string SetLastName
        {
            get
            {
                return LastName;
            }
            set
            {
                LastName = value;
            }
        }


        public string SetEmail
        {
            set
            {
                Email = value;
            }
        }
        public DateTime SetDob
        {
            set
            {
                Dob = value;
            }
        }
        public Person(String First, String Last, String email, DateTime DOfB)
        {
            FirstName = First;
            LastName = Last;
            Email = email;
            Dob = DOfB;
        }

        public Person(String First, String Last, String email)
        {
            FirstName = First;
            LastName = Last;
            Email = email;
        }

        public Person(String First, String Last, DateTime DOfB)
        {
            FirstName = First;
            LastName = Last;
            Dob = DOfB;
        }

        public int age(DateTime dtDOB)
        {
            TimeSpan ts = DateTime.Now.Subtract(dtDOB);
            int years = ts.Days / 365;
            return years;

        }
        public static void Main()
        {
            Console.WriteLine("Enter details for a person\n");
            Console.Write(" First name : ");
            string FirstName = Console.ReadLine();
            Console.Write(" Last name : ");
            string LastName = Console.ReadLine();
            Console.Write(" Email address : ");
            string Email = Console.ReadLine();
            Console.Write(" Date of birth : ");
            string Dob = Console.ReadLine();
            DateTime dateofbirth = DateTime.Parse(Dob);
            Person p = new Person(FirstName, LastName, Email, dateofbirth);
            Console.WriteLine();
            Console.WriteLine("The person entered is : {0} {1}", p.FirstName,p.LastName);
            Console.WriteLine("Email address is: {0}", p.Email);
            Console.WriteLine("Date of birth is: {0}", p.Dob.ToShortDateString());
            Console.ReadKey();
        }
    }

    
}
