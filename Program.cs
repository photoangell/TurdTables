using System;

namespace TurdTables
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = new TurdMail();
            var tweet = new TurdTweet();
            //var 
            email.CheckMail();
            if (email.Notification) {
                //do a tweet
                tweet.DoTweet(email);
            }

        }
    }
}
