using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library;
using HRLibrary;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
             Person p1 = new Person();
          

            Person p2 = new Person("Gourav","Gavali","gouravgavali@gmail.com",25,"874512452");
           

            Person p3 = new Person();
            p3.fname = "Nihal";
            p3.lname = "Kulkarni";
            p3.email = "Nihalkul@gmail.com";
            p3.age = 25;
            p3.contactnumber = "745842155";

            //Property initializer syntax
            Person p4 = new Person()
            {
                fname = "Pruthvi",
                lname = "bhandare",
                age = 25,
                email = "pruthvirajb@gmail.com",
                contactnumber = "25412536"
            };

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(p4);

            Point po1 = new Point(50, 10);
            Console.WriteLine(po1);

            DateTime jdate = new DateTime(2021, 11, 25, 09, 12, 10);
            Employeecs emp = new SalesManeger(1001,"Shivam Dalvi",jdate,"Developement",26,"Pune",1500,50000,150000,10000);
            double salessalary = emp.ComputePay();

            Console.WriteLine(emp);
            Console.WriteLine(" Sales Person Salary is "+salessalary+"RS.");

            DateTime jdate1 = new DateTime(2021, 11, 25, 09, 12, 10);
            Employeecs dev = new SoftwareDeveloper(1010, "Rushi Chougule", jdate1, "Production", 26, "Solapur","Manufacturing",800,0.5);
            double devsalary = dev.ComputePay();
            Console.WriteLine(dev);
            Console.WriteLine(" Developer Salary is " +devsalary + "RS.");
            Console.ReadLine( );

        }
    }
}