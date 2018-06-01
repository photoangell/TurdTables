using System;

namespace TurdTables {

    public class TurdTweet {

        public bool DoTweet(TurdMail turdMail) {
            System.Console.WriteLine("poo found at " + turdMail.Location);
            return true;
        }
    }

}