﻿using System;
using System.Collections.Generic;
using System.IO;
using Console = System.Console;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Need to refactor the code I made in Lesson 2.
            // Use functions to achieve DRY (as little duplicate code as possible).

            // Name input
            string name = PromptString("Enter your name: ");

            // Surname input
            string surname = PromptString("Enter your surname: ");

            // Age input
            int age = PromptInt("Enter your age: ");

            // Weight input
            float weight = PromptFloat("Enter your weight(in kg): ");

            // Height input
            float height = PromptFloat("Enter your height(in cm): ");

            // BMI calculation
            float bmi = CalculateBMI(weight, height);

            // User profile output
            PrintUserProfile(name, surname, age, weight, height, bmi);
        }

        static string PromptString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        static int PromptInt(string message)
        {
            Console.Write(message);
            int input = Convert.ToInt32(Console.ReadLine());
            return input;
        }

        static float PromptFloat(string message)
        {
            Console.Write(message);
            float input = float.Parse(message);
            return input;
        }

        static float CalculateBMI(float weight, float height)
        {
            float bmi = (weight) / ((height / 100) * (height / 100));
            return bmi;
        }

        static void PrintUserProfile(string name, string surname, int age, float weight, float height, float bmi)
        {
            Console.WriteLine("{0} is {1} years old, his weight is {2} kg and his height is {3} cm\nBMI: {4}",
                name + " " + surname,
                age,
                weight,
                height,
                string.Format("{0:F1}", bmi)
                );
        }
    }
}
