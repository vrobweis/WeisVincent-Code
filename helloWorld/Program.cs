//1.0 predefined namespace
using System;

//1.1 custom defined namespace
namespace helloWorld
{
    class Program
    {
        //execution starts here
        static void Main(string[] args)
        {

            string name;
            string firstname;
            string lastname;
            
            Console.WriteLine("Please enter your first name.");
            firstname = Console.ReadLine(); // takes user's input in string form
            Console.WriteLine("Please enter your last name.");
            lastname = Console.ReadLine(); // takes user's input in string form

            name = firstname + lastname;
            
            Console.WriteLine("Welcome " + name + "! The time is " + DateTime.Now); /* This is String concatenation. 
            It sucks, because Strings are immutable, 
            so all this really does is make multiple strings and put them together for the output. 
            It's not as good as Interpolation for memory.*/


            Console.WriteLine($"Welcome {name}! The time is {DateTime.Now}"); /* This is String Interpolation. 
            //By doing this, instead of making multiple strings and shoving them together, 
            it makes one and subs in the variables you insert. Better for memory. */
        }
    }
}
