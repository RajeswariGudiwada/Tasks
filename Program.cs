using System;
using System.Collections.Generic;


namespace sails
{
    class Bank
    {
        public Bank(string name) //constructor
        {
            marks = new List<double>();
            this.name = name;
        }


        public void AddMark(double mark)
        {
            marks.Add(mark);
        }
       public List<double> marks;
        private string name;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var bank = new Bank("hello");
            bank.AddMark(67.5);
            bank.marks.Add(101);

            int x = 10;
            int y = 11;
            int result = x + y;
            Console.WriteLine($"Addition is {result}"); //addition

            var numbers = new [] {12.7,10.3,6.11,4.1};
            var total = 2.2;
            foreach( var no in numbers)
            {
                total += no;
            }
            Console.WriteLine($"Total is {total:N1}");//Array

            List<double> marks = new List<double>() { 12.7, 10.3, 6.11,};
            marks.Add(6.4);
            marks.Add(7.9);
            Console.WriteLine(marks.Count);//List

            if (args.Length > 0)
            {
                Console.WriteLine($"{args[0]} {args[1]}!");
            }
            else
            {
                Console.WriteLine("welcome!");
            }
        }
    }
}


