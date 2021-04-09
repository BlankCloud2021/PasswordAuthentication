using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PasswordAuthentication
{
    class Passwords
    {
        public Dictionary<string, string> UserPasswords = new Dictionary<string, string>();
       
        public Passwords()
        {
            UserPasswords.Add("Admin", "Plus" +
                "Ultra");
        }
        // Checks array for password 
        public void Authentication(Dictionary<string, string> Dictionary, string username, string password)
        {
            //TO Do
            //Add do while loop
          if(Dictionary.ContainsKey(username))
            {
                if(Dictionary[username] == password)
                {
                    Console.WriteLine("Account Authenticatied, Welcome");
                }
                else
                {
                    Console.WriteLine("Incorrect Password");
                }
                
            }

        }

        //Create new User and Password pair
        public void NewUser(Dictionary<string, string> Dictionary, string username, string password) 
        {
            //To Do
            if (Dictionary.ContainsKey(username))
            {
                Console.WriteLine($"Account already exist for ({username}) \n You might try logging in");
            }
            else
            {
                Dictionary.Add(username, password);
            }
          
        }

        //Print All passowrds
        public void Print(Dictionary<string, string> Dictionary)
        {
            //To Do
            Dictionary<string, string> keyValuePairs = Dictionary;
            foreach(KeyValuePair<string,string> kvp in keyValuePairs)
            {
                Console.WriteLine($"Username = {kvp.Key} Password= {kvp.Value} ");
            }
        }
    }
}
