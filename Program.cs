using System;

namespace Metanit_Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
        //OverLoadOperators_30
            OverLoadOperators_30 box1 = new OverLoadOperators_30 { Value = 25 };
            OverLoadOperators_30 box2 = new OverLoadOperators_30 { Value = 35 };
            bool result = box1 > box2;
            OverLoadOperators_30 box3 = box1 + box2;

        //ImplicitConversion_30
            ImplicitConversion_30 ic = new ImplicitConversion_30 { Seconds = 111134 };
            int x = (int)ic;
            ImplicitConversion_30 ic2 = x;

            Timer timer1 = ic; // 134 is 2:14            
            ImplicitConversion_30 ic3 = timer1; // 2:14 is 134

            //timer1.Display();
            //ic.Display();

        //Inheritance_31            
            Employee empl = new Employee("Tom", "Stone", "SONY");           
            //empl.Display();

        //Polimorphism_32
            Polimorphism_32 p1 = new Polimorphism_32("Bill", "Gates");
            //p1.Display();

            Polimorphism_32 p2 = new Employee_32("Tom", "Smith", "Microsoft");
            //p2.Display();

            Employee_32 p3 = new Employee_32("Bob", "Thompson", "Apple");
            //p3.Display();

            Polimorphism_32 p4 = new Manager("Jack", "McDuglas", "Oracle", "Quality_Assurance(QA)");
            //p4.Display();

        //Abstract_33
            Person_33 cl = new Client_33("Jack", "Bean", 3000);
            Person_33 empl_33 = new Employee_33("Garold", "Thompson", "Manager");

            //cl.Display();
            //empl_33.Display();

        //ObjectConverting_35
            Person_35 client35 = new Client_35("Old", "Spies", 3000, "Societe General");
            Person_35 employee35 = new Employee_35("Tik", "Tok", "AccountMan");

            int sum35;// = ((Client_35)client35).sum;
            Client_35 testClient = employee35 as Client_35;
            if (testClient != null)
            {
                sum35 = testClient.sum;
                //Console.WriteLine(sum35);
            }
            
            string position35 = ((Employee_35)employee35).position;
            //Console.WriteLine(position35);

            //client35.Display();
            //employee35.Display();
        }
    }
}
