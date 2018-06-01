using System;

namespace TurdTables
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = new TurdMail();
            //var 
            email.CheckMail();
            if (email.Notification) {
                //do a tweet
                System.Console.WriteLine("poo found at " + email.Location);
            }
        }
    }
}
