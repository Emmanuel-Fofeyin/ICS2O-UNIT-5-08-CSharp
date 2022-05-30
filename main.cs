// Created by: Emmanuel_Fofeyin 
// Created on: May 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function does division
        int firstInteger;
        int secondInteger;
        int remainder;
        int total = 0;

        // input
        Console.WriteLine("This program does long division");

        Console.WriteLine("");
        Console.Write("Please enter the first integer: ");
        firstInteger = Convert.ToInt32(Console.ReadLine());
        remainder = firstInteger;

        Console.WriteLine("");
        Console.Write("Please enter the second integer: ");
        secondInteger = Convert.ToInt32(Console.ReadLine());

        // process
        if ((firstInteger > 0) && (secondInteger > 0))
        {
            while (remainder >= secondInteger)
            {
                remainder = remainder - secondInteger;
                total++;
            }
        }
        else if ((firstInteger < 0) && (secondInteger < 0))
        {
            remainder = Math.Abs(remainder);
            secondInteger = Math.Abs(secondInteger);
            while (remainder >= secondInteger)
            {
                remainder = remainder - secondInteger;
                total++;
            }

            secondInteger = -Math.Abs(secondInteger);
        }
        else
        {
            remainder = Math.Abs(remainder);
            secondInteger = Math.Abs(secondInteger);
            while (remainder >= secondInteger)
            {
                remainder = remainder - secondInteger;
                total++;
            }

            total = -Math.Abs(total);
        }

        Console.WriteLine("");
        Console.WriteLine(firstInteger + " ÷ " + secondInteger + " = " + total + " R " + remainder);
        Console.WriteLine("\nDone.");
    }
}