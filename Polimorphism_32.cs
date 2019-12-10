using System;
using System.Collections.Generic;
using System.Text;

namespace Metanit_Lessons
{
    class Polimorphism_32
    {
        internal string _firstName;       
        internal string _lastName;
       

        public Polimorphism_32(string FirstName, string LastName)
        {
            _firstName = FirstName;
            _lastName = LastName;
        }

        public virtual void Display()
        {
            Console.WriteLine();
            Console.Write($"{_firstName} {_lastName}");
        }
    }

    class Employee_32 : Polimorphism_32
    {
        internal string _company;

        public Employee_32(string FirstName, string LastName, string Company)
            : base(FirstName, LastName)
        {
            _company = Company;
        }

        public override void Display()
        {
            base.Display();
            Console.Write($" {_company}");
        }
    }

    class Manager : Employee_32
    {
        internal string _department;

        public Manager(string name, string surname, string company, string department)
            : base(name,surname, company)
        {
            _firstName = name;
            _lastName = surname;
            _company = company;
            _department = department;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($" {_department}");
        }


    }
}
