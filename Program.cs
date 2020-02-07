using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;   //first name
            string favMovie;    //movie
            string PersonalizedGreeting;
            string CapsPhrase;          
            string ReplacePhrase;

            Console.Write(" SSS ");
            Console.WriteLine(" DDDD ");
            Console.Write("S   S");
            Console.WriteLine(" D   D");
            Console.Write("S    ");
            Console.WriteLine(" D   D");
            Console.Write(" SSS ");
            Console.WriteLine(" D   D");
            Console.Write("    S");
            Console.WriteLine(" D   D");
            Console.Write("S   S");
            Console.WriteLine(" D   D");
            Console.Write(" SSS ");
            Console.WriteLine(" DDDD ");

            firstName = ("Sean");
            favMovie = ("Iron Man");

            PersonalizedGreeting = ($"My name is {firstName} and my favourite movie is {favMovie}.");
            PersonalizedGreeting = PersonalizedGreeting.ToLower();
            Console.WriteLine(PersonalizedGreeting);

            favMovie = favMovie.ToUpper();
            Console.WriteLine(favMovie);
            bool ContainPhrase = favMovie.Contains("The");
            Console.WriteLine(ContainPhrase);

            Console.WriteLine(favMovie.Replace("A", "@"));
            Console.WriteLine(favMovie.Replace("E", "3"));

            Console.ReadLine();       
        }
    }
}
