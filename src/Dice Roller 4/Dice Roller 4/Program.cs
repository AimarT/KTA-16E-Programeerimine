﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Roller
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("> /roll 3d6 2d8");
            Console.WriteLine(" ");


            var random = new Random();
            var total = 0;

            for (var i = 0; i < 3; i++)
            {
                var roll = random.Next(1, 7);
                total += roll;

                Console.WriteLine($"1d6 {roll}");
            }for (var i =0; i<2; i++)




            Console.WriteLine("id6: 5 " + new Random().Next(1, 6));
            Console.WriteLine("id6: 3 " + new Random().Next(1, 6));
            Console.WriteLine("id6: 2 " + new Random().Next(1, 6));
            Console.WriteLine("id6: 6 " + new Random().Next(1, 6));
            Console.WriteLine("id6: 4 " + new Random().Next(1, 6));
            Console.WriteLine(" ");
            Console.WriteLine("Roll total: 20");
            Console.WriteLine(" ");
            Console.WriteLine("> ");
            Console.ReadLine();
        }
    }
}

