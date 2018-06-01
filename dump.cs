//https://www.codeproject.com/Articles/742774/Cancel-a-Loop-in-a-Task-with-CancellationTokens

using System;
using System.Threading;
using System.Threading.Tasks;

namespace TurdTables
{
    class Program2
    {
        static void Main2(string[] args)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            var token = cts.Token;
    
            Task t = Task.Factory.StartNew( 
                () => {
                    MainLoop(token);
                }, 
                token, 
                TaskCreationOptions.LongRunning, 
                TaskScheduler.Default
            );    
    
            Console.ReadLine();
            
            cts.Cancel();
    
            try 
            {
                t.Wait();
            }
            catch( AggregateException ae )
            {
                // catch inner exception 
            }
            catch( Exception crap )
            {
                // catch something else
            }


        }

        static void MainLoop( CancellationToken token )
        {
            while( true )
            {
                // do something here.
                var email = new TurdMail();
                var tweet = new TurdTweet();
                //var 
                email.CheckMail();
                if (email.Notification) {
                    //do a tweet
                    tweet.DoTweet(email);
                }
                
                Thread.Sleep(1000 * 5);
                
                // Poll on this property if you have to do 
                // other cleanup before throwing. 
                
                if (token.IsCancellationRequested)
                {
                    // Clean up here, then...
                    //"cleanup".Dump();
                    token.ThrowIfCancellationRequested();
                }
            }
        }
    }
}
