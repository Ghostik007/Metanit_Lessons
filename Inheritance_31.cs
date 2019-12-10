using System;
using System.Collections.Generic;
using System.Text;

namespace Metanit_Lessons
{
    class Inheritance_31
    {
        internal string _firstName;
        /* public string FirstName
         {
             get { return _firstName; }
             set { _firstName = value; }
         }*/
        internal string _lastName;
       /* public string LastName 
        { 
            get { return _lastName; } 
            set { _lastName = value; }
        }*/

        public Inheritance_31(string FirstName, string LastName)
        {
            _firstName = FirstName;
            _lastName = LastName;
        }

        public void Display()
        {
            Console.WriteLine($"{_firstName} {_lastName}");
        }
    }

    class Employee : Inheritance_31
    {
        private string _company;
        /*public string Company 
        {
            get { return _company; }
            set { _company = value; }
        }*/

        public Employee(string FirstName, string LastName, string Company)
            : base( FirstName, LastName )
        {
            _company = Company;
        }

        public void Display()
        {
            Console.WriteLine($"{_firstName} {_lastName} {_company}");
        }
    }

    
}
