using System;

namespace String_Manipulation_Project
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Yourname");
           
            string name=Console.ReadLine();
            Console.WriteLine("Enter Contact Numbers");
            string contactNum =Console.ReadLine();

            
            if ((contactNum.Length==10  ))
            {//string manipulations 
                Console.WriteLine($"The name is: {name.Length} characters longs");
                Console.WriteLine($"Index of a character is: {name.IndexOf("w")}");
                Console.WriteLine($"Returning first four characters: {name.Substring(4, 3)}");
                string newContact = contactNum.Remove(2);
                Console.WriteLine($"Removed didgits in the conttact:{newContact}");
                Console.WriteLine($"Your phone number with SA Code:+27{contactNum.Substring(1)}");
               
            }
            else {
                Console.WriteLine("invalid contact");
            }
            
        }
    }
}
