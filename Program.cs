using System;
using System.Collections.Generic;


namespace sails
{
    class Bank
    {
        public Bank(string name)
        {
            marks = new List<double>();

        }
        public void AddMark(double mark)
        {
            marks.Add(mark);
        }
        public void showMarks()
        {
            int x = 10;
            int y = 11;
            int result = x + y;
            Console.WriteLine($"Addition is {result}");

            var numbers = new[] { 12.7, 10.3, 6.11, 4.1 };
            var total = 2.2;
            var highMark = double.MinValue;
            var lowMark = double.MaxValue;

            foreach (var no in numbers)
            {
                lowMark = Math.Min(no, lowMark);
                highMark = Math.Max(no, highMark);
                total += no;
            }
            Console.WriteLine($"lowest grade is {lowMark}");
            Console.WriteLine($"highest grade is {highMark}");
            Console.WriteLine($"Total is {total:N1}");

            List<double> marks = new List<double>() { 12.7, 10.3, 6.11, };
            marks.Add(6.4);
            marks.Add(7.9);
            Console.WriteLine(marks.Count);

        }
        public List<double> marks;

    }
    class Program
    {
        static void Main(string[] args)
        {
            var bank = new Bank("hello");
            bank.AddMark(82.5);
            bank.AddMark(23.5);
            bank.AddMark(6.5);
            bank.showMarks();
        }
    }
}

    

   
