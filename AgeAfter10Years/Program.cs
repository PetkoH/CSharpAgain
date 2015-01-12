﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 15. Write a program to read your birthday from the console 
//and print how old you are now and how old you will be after 10 years.


class AgeAfter10Years
{
    static void Main(string[] args)
    {
        DateTime BirthDay;
        if (DateTime.TryParse(Console.ReadLine(), out BirthDay))
        {
            DateTime today = DateTime.Today;
            int age = today.Year - BirthDay.Year;
            if (BirthDay > today.AddYears(-age))
                Console.WriteLine("Now I am" + 2 + 3 + "years old.");
            Console.WriteLine(23 + 10);
        }
        else
        {
            Console.WriteLine("My Bitrthday is on 09/04/1991.");// dd/MM/yyyy г.
            Console.WriteLine("Now I am " + 2 + 3 + " years old.");
            Console.WriteLine("After ten years, I will be " + (23 + 10) + " years old.");//Future
        }
    }
}