using System;
using System.Collections.Generic;
using System.Text;

namespace Metanit_Lessons
{
    class ObjectConverting_35
    {
       
    }

    abstract class Person_35
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public Person_35(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public virtual void Display()
        {
            Console.WriteLine();
            Console.Write($"{firstName} {lastName}");
        }
    }

    class Client_35 : Person_35
    {
        public int sum { get; set; }
        public string bank { get; set; }

        public Client_35(string firstName, string lastName, int sum, string bank)
            : base(firstName, lastName)
        {
            this.sum = sum;
            this.bank = bank;
        }

        public override void Display()
        {
            base.Display();
            Console.Write($" have an account in a {bank} in the ammount {sum}");
        }
    }

    class Employee_35 : Person_35
    {
        public string position { get; set; }

        public Employee_35(string firstName, string lastName, string position)
            : base(firstName, lastName)
        {
            this.position = position;
        }

        public override void Display()
        {
            base.Display();
            Console.Write($" works on position {position}");
        }
    }
}
