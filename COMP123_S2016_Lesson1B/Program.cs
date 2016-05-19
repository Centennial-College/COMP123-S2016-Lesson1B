using System;
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

    Version: 0.3 - Updated comments for driver class Program
 */

namespace COMP123_S2016_Lesson1B
{
    /**
     * This is a driver class for our program
     * 
     * @class Program
     */
    class Program
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

            Console.Write("Enter Username: ");
            UserName = Console.ReadLine();

            Console.WriteLine("/n==========================");
            Console.WriteLine("You Entered: " + UserName);

            return UserName;
        }
    }
}
