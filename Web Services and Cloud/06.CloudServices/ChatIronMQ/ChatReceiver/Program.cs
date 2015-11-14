using System;
using System.IO;

using System.Threading;
using IronMQ;
using IronMQ.Data;

class IronMQReceiver
{
    static void Main()
    {
        Client client = new Client("564785e773d0cd0006000082",
             "ngxXUPp84i3WuJaByu2a");
        Queue queue = client.Queue("Today's demo");
        Console.WriteLine("Listening for new messages from IronMQ server:");
        while (true)
        {
            Message msg = queue.Get();
            if (msg != null)
            {
                Console.WriteLine(msg.Body);
                queue.DeleteMessage(msg);
            }
            Thread.Sleep(100);
        }
    }
}
