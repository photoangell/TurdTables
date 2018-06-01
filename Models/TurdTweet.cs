using System;

namespace TurdTables {

    public class TurdTweet {

        public bool DoTweet(TurdMail turdMail) {
            System.Console.WriteLine("poo found at {0} at {1}", turdMail.Location, turdMail.Time);
            return true;
        }
    }

}