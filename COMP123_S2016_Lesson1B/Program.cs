﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Author: Kevin Ma
    Date Created: May 18, 2016
    Date Modified: May 18, 2016
    Student ID: 300867968

    Description: This program demonstrates GitHub and version control best practices.
    We also explore Unit Testing

    Version: 0.6 - Refactored OutputStringToConsole
 */

namespace COMP123_S2016_Lesson1B
{
    /**
     * This is a driver class for our program
     * 
     * @class Program
     */
    public class Program
    {
        /**
         * Main Method for class Program
         * 
         * @param {string[]} args
         * @constructor Main
         */
        static void Main(string[] args)
        {
            GetUserName();
        }

        /**
         * This method reads the UserName from the Console
         * 
         * @method GetUserName
         * @return {string} UserName
         */
        public static string GetUserName()
        {
            // Initialize Variables
            string UserName = "";

            OutputStringToConsole("Enter UserName: ", false);
            UserName = Console.ReadLine();

            Console.WriteLine("\n==========================\n");
            Console.WriteLine("You Entered: " + UserName + "\n");

            return UserName;
        }

        /**
         * This method writes a string to the console. Parameters allow the user to
         * choose to add a newLine character.
         * 
         * @method OutputStringToConsole
         * @param {string} outputString
         * @param {bool} hasNewLine
         * @return {string} outputString
         */
        public static string OutputStringToConsole(string outputString, bool hasNewLine)
        {
            // Refactored using the ternary operator
            string suffixString = hasNewLine  ? "\n" : "";
            Console.Write(outputString + suffixString);

            return outputString;
        }
    }
}
