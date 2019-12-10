using System;
using System.Collections.Generic;
using System.Text;

namespace Metanit_Lessons
{
    abstract class Abstract_33
    {
        public string Name { get; set; }
    }

    abstract class Person_33
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public Person_33(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void Display()
        {
            Console.WriteLine($"{firstName} {lastName}");
        }
    }

    class Client_33 : Person_33
    {     
        public int sum { get; set; }
        
        public Client_33(string firstName, string lastName, int sum)
            :base(firstName,lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.sum = sum;
        }
    }

    class Employee_33 : Person_33
    {      
        public string position { get; set; }

        public Employee_33(string firstName, string lastName, string position)
            :base(firstName,lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = position;
        }      
    }
}
