using System;

namespace Comments
{
    class Program
    {
        /// XML Comments are used to help provide documentation
        /// They start with triple-slashes and have a special syntax

        /// <summary>
        ///This is the main sample application function
        /// </summary>

        /// <param name='args'> An array of strings arguments from the command line</param>
        /// <returns>
        /// No return value
        /// </returns>
        
        static void Main(string[] args)
        {
            //Single line comments start with two slashes
            //you can have as many of these as you want
            Console.WriteLine("Hello World!");
            /* Multiple line comments start with a slash and a star
            and you can continue for several lines
            until closing star and slash are encountered */

        }
    }
}
