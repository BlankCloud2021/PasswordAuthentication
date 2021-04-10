using System;

namespace PasswordAuthentication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Password Authentication System
            Passwords passwords = new Passwords();
            Encryption encryption = new Encryption();
            
            bool condition = true;
            do
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
                        
                        Console.WriteLine("-------------------------------------------------------------------- ");
                        Console.WriteLine("         Establish an account ");
                        Console.WriteLine("-------------------------------------------------------------------- ");
                     
                        Console.Write("UserName: ");
                        string Username = Console.ReadLine();

                        Console.Write("Password: ");
                        string password = Console.ReadLine();
                        string ePassword = encryption.PasswordEncryption(password);
                        passwords.NewUser(passwords.UserPasswords, Username, ePassword, password);

                       

                        break;

                    case 2:
                        
                        Console.WriteLine("-------------------------------------------------------------------- ");
                        Console.WriteLine("         Authenticate a user");
                        Console.WriteLine("-------------------------------------------------------------------- ");
                        Console.Write("UserName: ");
                        string aUsername = Console.ReadLine();

                        Console.Write("Password: ");
                        string aPassword = Console.ReadLine();
                        string aEPassword = encryption.PasswordEncryption(aPassword);
                        passwords.Authentication(passwords.UserPasswords, aUsername, aEPassword);

                        break;

                    case 3:
                        //Exits enviorment.
                        Console.WriteLine("-------------------------------------------------------------------- ");
                        Console.WriteLine("         Exiting the system");
                        Console.WriteLine("-------------------------------------------------------------------- ");
                        condition = false;

                        break;
                }
            } while (condition);

            // Print All Paswords entered
            passwords.Print(passwords.UserPasswords);
        }
    }
}
