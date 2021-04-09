using System;

namespace PasswordAuthentication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Password Authentication System
            bool condition = true;
            if (condition)
            {
            Console.WriteLine("-------------------------------------------------------------------- ");
            Console.WriteLine();
            Console.WriteLine("        PASSWORD AUTHENTICATION SYSTEM ");
            Console.WriteLine();
            Console.WriteLine("        Please select one option:");
            Console.WriteLine("        1. Establish an account ");
            Console.WriteLine("        2. Authenticate a user");
            Console.WriteLine("        3. Exit the system");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------");
            Console.Write("            Enter selection: ");

            
                short choice = short.Parse(Console.ReadLine());
            
            
                switch (choice)
                {
                    case 1:
                        // to do  establish an account 
                        Console.WriteLine("-------------------------------------------------------------------- ");
                        Console.WriteLine("         Establish an account ");
                        Console.WriteLine("-------------------------------------------------------------------- ");
                        break;

                    case 2:
                        //to do Athenticate a User
                        Console.WriteLine("-------------------------------------------------------------------- ");
                        Console.WriteLine("         Authenticate a user");
                        Console.WriteLine("-------------------------------------------------------------------- ");
                        break;

                    case 3:
                        //Exits enviorment.
                        Console.WriteLine("-------------------------------------------------------------------- ");
                        Console.WriteLine("         Exiting the system");
                        Console.WriteLine("-------------------------------------------------------------------- ");
                        condition = false;

                        break;
                }
            }
            // Print All Paswords entered

        }
    }
}
