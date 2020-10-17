using System;
using CarLib;

namespace PersonLib
{
    public class Person
    {
        public string Name;
        public int YearOfBirth;
        public Car MyCar;

        public int CalcAge() {
            if (this.YearOfBirth < 1900) {
                throw new Exception("You are too old to be alive!");
            }
            return DateTime.Now.Year - YearOfBirth;
        }
    }
}
