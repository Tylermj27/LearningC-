using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC
{
    class Program
    {
        static void Main(string[] args)
        {
            byte sample1 = 0x3A;
            byte sample2 = 58;
            int heartRate = 85;
            double deposits = 135002796;
            const float acceleration = 9.800F;
            float mass = 14.6F;
            double distance = 129.763001;
            bool lost = true;
            bool expensive = true;
            int choice = 2;
            char integral = '\u222B';
            string greeting = "Hello";
            string name = "Karen";

            if (sample1 == sample2)
            {
                Console.WriteLine("The samples are equal.");
            }
            if (sample1 != sample2)
            {
                Console.WriteLine("The samples are not equal.");
            }

            if (heartRate >= 40 && heartRate <= 80)
            {
                Console.WriteLine("Heart rate is normal");
            }
            if (heartRate <= 40 && heartRate >= 80) 
            {
                Console.WriteLine("Heart rate is not normal");
            }
            if (deposits >= 100000000)
            {
                Console.WriteLine("You are exceedingly wealthy.");
            }
            if (deposits <= 100000000)
            {
                Console.WriteLine("Sorry you are so poor.");
            }
            float force = mass * acceleration;
            Console.WriteLine("Force = {0}", force);
            Console.WriteLine("{0} is the distance.", distance);
            if (lost == true && expensive == true)
            {
                Console.WriteLine("I am really sorry! I will get the manager.");
            }
            if (lost == true && expensive == false)
            {
                Console.WriteLine("Here is a coupon for 10% off.");
            }
            switch (choice)
            {
                case '1':
                    Console.WriteLine("You chose 1.");
                    break;
                case '2':
                    Console.WriteLine("You chose 2.");
                    break;
                case '3':
                    Console.WriteLine("You chose 3.");
                    break;
                default:
                    Console.WriteLine("You made an unknown choice.");
                    break;
            }
            Console.WriteLine("{0} is an integral", integral);
            int i;
            for(i = 5; i <= 10; i++)
            {
                Console.WriteLine("i = {0}", i);
            }
            int age;
            age = 0;
            while(age < 6)
            {
                Console.WriteLine("age = {0}", age);
                age++;
            }
            Console.WriteLine("{0} {1}", greeting, name);

            Console.ReadLine();
        }
    }
}
