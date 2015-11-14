using IronMQ;
using System;
using System.Net;

class IronMQSender
{
    static void Main(string[] args)
    {
        Client client = new Client("564785e773d0cd0006000082",
            "ngxXUPp84i3WuJaByu2a");
        Queue queue = client.Queue("Today's demo");
        Console.WriteLine("Enter messages to be sent to the IronMQ server:");

        string hostName = Dns.GetHostName(); // Retrive the Name of HOST

        // Get the IP
        string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
        while (true)
        {
            string msg = Console.ReadLine();
            queue.Push(myIP + ": " + msg);
            Console.WriteLine("Message sent to the IronMQ server.");
        }
    }
}
