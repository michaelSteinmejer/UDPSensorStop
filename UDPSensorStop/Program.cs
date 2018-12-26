using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace UDPSensorStop
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpClient udpClient = new UdpClient();


            //Creates an IPEndPoint to record the IP Address and port number of the sender.  
            IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Broadcast, 11111);

            try
            {
                // Blocks until a message is received on this socket from a remote host (a client).
                Console.WriteLine("Server is blocked");
                
                    //Console.WriteLine("Received from: " + clientName.ToString() + " " + text.ToString());


                    Byte[] sendBytes = Encoding.ASCII.GetBytes("stop");

                    udpClient.Send(sendBytes, sendBytes.Length, RemoteIpEndPoint);

                    Thread.Sleep(100);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());

            }
        }
    }
}
