using System;
using System.Collections.Generic;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate 3 persons (2)
            Person p1 = new Person("Syed", "Razvi", DateTime.Parse("08-08-1988"), 165);
            Person p2 = new Person("Brian", "Adams", DateTime.Parse("10-10-1970"), 180);
            Person p3 = new Person("Tony", "Stark", DateTime.Parse("12-12-1975"), 175);

            Console.WriteLine();

            // (Task 1.2.1)
            Console.WriteLine("Full Name is " + p1.GetFullName()); //(1.2.1)
            Console.WriteLine("and ID: " + p1.id);

            Console.WriteLine();
            // (Task 1.2.2)
            Console.WriteLine("Full Name is " + p2.GetFullName() + " and Height Difference from other person is " + p1.GetHeightDifference(p2) + " cm.");

            Console.WriteLine();

            // (Task 2)

            // Person 1
            Console.WriteLine("First Person Fullname: " + p1.GetFullName());
            Console.WriteLine("First Person Height is " + p1.height + " cm.");
            Console.WriteLine();

            // Person 2
            Console.WriteLine("Second Person Fullname: " + p2.GetFullName());
            Console.WriteLine("Second Person Height Difference from First Person is " + p2.GetHeightDifference(p1) + " cm.");
            Console.WriteLine();

            // Person 3
            Console.WriteLine("Third Person Fullname: " + p3.GetFullName());
            Console.WriteLine("Third Person Height Difference from First Person is " + p3.GetHeightDifference(p1) + " cm.");
            Console.WriteLine();

            p1.AddSubject("JAVASCRIPT", 2019);
            p1.AddSubject("CSHARP", 2020);
            p1.AddSubject("PROJECT MANAGEMENT", 2021);
            Console.WriteLine(p1.ShowSubject());
        }
    }


    // class person (Task 1)
    public class Person
    {
        // attributes (Task 1.1)
        public string firstname;
        public string surname;
        public DateTime dob;
        public int height;
        public int id; // (Task 3)
        public List<Subject> personSubject; //(Task 4)


        public Person()
        {
            firstname = "Syed";
            surname = "Razvi";
            dob = DateTime.Parse("08-08-1988");
            height = 165;
            id = 103219618;
        }

        // constructors
        public Person(string f, string s, DateTime d, int h)
        {
            this.firstname = f;
            this.surname = s;
            this.dob = d;
            this.height = h;

            // (3)
            var rand = new Random();
            int randomID = rand.Next(1000, 9999);
            this.id = randomID;
            this.personSubject = new List<Subject>();
        }
        // methods person (Task 1.2)
        public string GetFullName()
        {
            return this.firstname + " " + this.surname;
        }
        public int GetHeightDifference(Person Other)
        {
            return this.height - Other.height;
        }
        public void AddSubject(string subjectName, int YearOfDelivery)
        {
            Subject sname = new Subject(subjectName, YearOfDelivery);
            this.personSubject.Add(sname);
        }

        public string ShowSubject()
        {
            string name = "";
            foreach (Subject subject in this.personSubject)
            {
                name += $"{subject.subjectName} \n";
            }
            return name;
        }


        // (Task 4)
        public class Subject
        {
            public string subjectName;
            public int YearOfDelivery;
            public Subject(string sn, int yod)
            {
                this.subjectName = sn;
                this.YearOfDelivery = yod;
            }
        }
    }
}
