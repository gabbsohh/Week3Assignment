using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //setting variables
            int speedLimit;
            int demerit;

            //ask for user input for speed limit
            Console.WriteLine("Enter the speed limit: ");
            speedLimit = Convert.ToInt32(Console.ReadLine());  

            //info for first car
            Car a = new Car();

            Console.WriteLine("Enter the make for car 1: ");
            a.make = Console.ReadLine();

            Console.WriteLine("Enter the model for car 1: ");
            a.model = Console.ReadLine();

            Console.WriteLine("Enter the MPH for car 1: ");
            a.mph = Convert.ToInt32(Console.ReadLine());

            //info for second car
            Car b = new Car();

            Console.WriteLine("Enter the make for car 2: ");
            b.make = Console.ReadLine();

            Console.WriteLine("Enter the model for car 2: ");
            b.model = Console.ReadLine();

            Console.WriteLine("Enter the MPH for car 2: ");
            b.mph = Convert.ToInt32(Console.ReadLine());

            //info for car 3
            Car c = new Car();

            Console.WriteLine("Enter the make for car 3: ");
            c.make = Console.ReadLine();

            Console.WriteLine("Enter the model for car 3: ");
            c.model = Console.ReadLine();

            Console.WriteLine("Enter the MPH for car 3: ");
            c.mph = Convert.ToInt32(Console.ReadLine());

            //display speed limit
            Console.WriteLine("Speed Limit: " + speedLimit + " MPH");

            //going into if statements for cars
            
            //car a
            if (a.mph <= speedLimit)
            {
                Console.WriteLine(a.model + " " + a.make + " " + a.mph + " MPH: OK");
            }

            else
            {
                demerit = (a.mph - speedLimit ) / 5;

                if(demerit < 10)
                {
                    Console.WriteLine(a.make + " " + a.model + " " + a.mph + " MPH: " + demerit + " demerit(s)");
                }

                else if(demerit >= 10)
                {
                    Console.WriteLine(a.make + " " + a.model + " " + a.mph + " MPH: " + demerit + " demerits <LICENSE SUSPENDED>");
                }
            }

            //car b if statement
            if (b.mph <= speedLimit)
            {
                Console.WriteLine(b.make + " " + b.model + " " + b.mph + " MPH: OK");
            }

            else
            {
                demerit = (b.mph - speedLimit) / 5;

                if (demerit < 10)
                {
                    Console.WriteLine(b.make + " " + b.model + " " + b.mph + " MPH: " + demerit + " demerit(s)");
                }

                else if (demerit >= 10)
                {
                    Console.WriteLine(b.make + " " + b.model + " " + b.mph + " MPH: " + demerit + " demerits <LICENSE SUSPENDED>");
                }
            }

            //car c if statment
            if (c.mph <= speedLimit)
            {
                Console.WriteLine(c.make + " " + c.model + " " + c.mph + " MPH: OK");
            }

            else
            {
                demerit = (c.mph - speedLimit) / 5;

                if (demerit < 10)
                {
                    Console.WriteLine(c.make + " " + c.model + " " + c.mph + " MPH: " + demerit + " demerit(s)");
                }

                else if (demerit >= 10)
                {
                    Console.WriteLine(c.make + " " + c.model + " " + c.mph + " MPH: " + demerit + " demerits <LICENSE SUSPENDED>");
                }
            }
        }
    }

    public class Car
    {
        public string make;
        public string model;
        public int mph;
    }
}
