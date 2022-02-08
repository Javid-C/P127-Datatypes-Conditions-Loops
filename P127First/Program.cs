using System;
using System.Collections.Generic;

namespace P127First
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = 5;
            //num = num + 5;
            //int small = num;
            //string name = "Avaz";
            //char character = 'A';
            //string surname = "Mammadli";
            //char space = ' ';
            //var fullname = name + space + surname;
            //Console.WriteLine(fullname);

            //string name = Console.ReadLine();
            //string surname = Console.ReadLine();
            //int age = Convert.ToInt32(Console.ReadLine());
            //string fullname = name + " " + surname + " " + age;

            //if (fullname == "Oruc Dostuyev 16")
            //{
            //    Console.WriteLine("Data duzgundur");
            //}
            //else
            //{
            //    Console.WriteLine("Data yanlishdir");
            //}

            //int number = Convert.ToInt32(Console.ReadLine());

            //if(number == 0)
            //{
            //    Console.WriteLine("Sistemden cixildi");
            //}else if (number == 1)
            //{
            //    Console.WriteLine("Operator");
            //}else if (number ==2)
            //{
            //    Console.WriteLine("Mushteri");
            //}
            //else
            //{
            //    Console.WriteLine("Duzgun reqem secin");
            //}

            //int num = 5;
            //Console.WriteLine(++num);
            //Console.WriteLine(num);
            string name = "okay";
            //num += 8;
            decimal num2 = 5.04m;
            float num3 = 99.99f;
            double num4 = 199.99d;
            //Console.WriteLine(num);
            int num = 14;
            //if (num<14)
            //{
            //    Console.WriteLine("kicikdir");
            //}else if (num == 14)
            //{
            //    Console.WriteLine("beraberdir");
            //}
            //else
            //{
            //    Console.WriteLine("boyukdur");
            //}

            //bool isStudent = false;


            //bool isBigger = num < 15;
            //if (!isStudent && isBigger)
            //{
            //    Console.WriteLine("oxundu?");
            //}
            //if (!isStudent)
            //{
            //    Console.WriteLine("telebedir");
            //}
            //else
            //{
            //    Console.WriteLine("Telebe deyil");
            //}

            //for (int i =0;i<100;i++ )
            //{
            //    Console.WriteLine(i);
            //}


            bool isFull = false;
            int count=0;
            while (!isFull)
            {
                count++;
                if (count == 20)
                {
                    break;
                }
            }
            Console.WriteLine(count);

            List<int> numbers = new List<int>();

            numbers.Add(1);
            numbers.Add(9);
            numbers.Add(5);
            numbers.Add(2);
            numbers.Add(3);


            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            int lastNumber = 20;
            do
            {
                Console.WriteLine("Ders bitdi");
            } while (lastNumber>10);
        }
    }
}
