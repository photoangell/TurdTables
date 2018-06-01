using System;
using Google.Apis.Gmail;

namespace TurdTables {
    public class TurdMail {
        public DateTime Time {get; set;}
        public string Location {get; set;}
        public string Flow {get; set;}
        public bool Notification {get; set;}
        public static readonly string Hammersmith = "Hammersmith Pumping Station";
        public static readonly string Mogden = "Mogden Sewage Works";
        public Boolean CheckMail() {
            //check mail here

            //if we find a mail which hasn't been tweeted
            this.Time = DateTime.Now; //or time from email
            this.Location = Hammersmith;
            this.Notification = true;

            return true; //false if it errors
        }

    }
}
