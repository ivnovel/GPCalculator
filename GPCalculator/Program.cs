using System;

namespace GPCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tCGPA Calculator");
            Console.WriteLine("\t\t\t----------------");

            Console.Write("\t\t\tEnter the course unit : ");
            int unit = int.Parse(Console.ReadLine());
            Console.Write("\t\t\tEnter the mark score : ");
            Double score = Double.Parse(Console.ReadLine());
            int gp = 5;
            double gpa;
            if (score >= 70 && score <= 100)
            {
                Console.WriteLine("\t\t\tYour Grade is A");
                gpa = (double)(unit * 5) / gp;
                Console.WriteLine("\t\t\tYour GP unit is " + gpa);
            }
            else if (score >= 50 && score <= 69.99)
            {
                Console.WriteLine("\t\t\tYour Grade is B");
                gpa = (double)(unit * 4) / gp;
                Console.WriteLine("\t\t\tYour GP unit is " + gpa);
            }
            else if (score >= 40 && score <= 49.99)
            {
                Console.WriteLine("\t\t\tYour Grade is C");
                gpa = (double)(unit * 3) / gp;
                Console.WriteLine("\t\t\tYour GP unit is " + gpa);
            }
            else if (score >= 30 && score <= 39.99)
            {
                Console.WriteLine("\t\t\tYour Grade is D");
                gpa = (double)(unit * 2) / gp;
                Console.WriteLine("\t\t\tYour GP unit is " + gpa);
            }
            else if (score >= 20 && score <= 29.99)
            {
                Console.WriteLine("\t\t\tYour Grade is E");
                gpa = (double)(unit * 1) / gp;
                Console.WriteLine("\t\t\tYour GP unit is " + gpa);
            }
            else if (score >= 0 && score <= 19.99)
            {
                Console.WriteLine("\t\t\tYour Grade is F");
                gpa = (double)(unit * 0) / gp;
                Console.WriteLine("\t\t\tYour GP unit is " + gpa);
            }
            else
            {
                Console.WriteLine("\t\t\tInvalid entries");
            }
            Console.ReadKey();
        }
    }
}
