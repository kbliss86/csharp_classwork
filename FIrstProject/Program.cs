//This is a comment line
/* this is a block commend
 * 
 * 
 * 
 * */

//Program.cs is the main executable file in a C# project. It contains the Main method, which is the entry point for the application. The Main method is the first method that is called when the program is run, and it is responsible for starting the application and executing the code that is contained within it.


using System; //Give me access to basic C# libraries
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Code in C# is grouped in namespaces
// Namespaces are used to organize code and prevent naming conflicts
// The System namespace contains the core C# libraries


namespace FIrstProject
{
    // A class is a blueprint for creating objects that are used together in an application
    //Every Application has at least one class, which contains the Main method
    internal class Program //Program is the name of the class that contains the application code
    {
        //The Main method is the entry point for the application, A Method is a self contained unit of code that performs a specific task
        //Static inidicated that there is only one of these methods in the application
        //Void indicates that the method does not return a value
        //Main is the name of the method
        //The stuff you see in the parentheses is called a parameter list
        //{} are used to indicate a self contained block of code
        static void Main(string[] args)
        {//Start code
         //A Piece of data in a program is called a variable
         //A variable has a name, a type, and a value

            //Commonly used data types in C# are int, float, double, string, and bool
            //int is used to store whole numbers between +/- 2 billion
            //long is used to store whole numbers between +/- 9 quintillion
            //double is used to store decimal numbers
            //char is used to store a single character
            //string is used to store text - multiple alphanumeric characters
            //bool is used to store true or false values

            //Ex. Define a variable that stores the current year (2024)
            int thisYear = 2024;

            //Ex. define a variable that holds PI to 2-decimals
            double pi = 3.14;

            //todisplay a line on the screen used Console.WriteLine("what to display");

            //Ex. display the variable thisYear on the screen
            Console.WriteLine(thisYear);
            Console.ReadLine(); //This line is used to keep the console window open

            //Variable names and numeric values are not enclodes in a ""

        }//End code
    }
}

