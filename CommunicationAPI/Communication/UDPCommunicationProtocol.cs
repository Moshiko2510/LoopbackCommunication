using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace CommunicationAPI.Communication
{
    public class UDPCommunicationProtocol
    {
        public static string serverIP = "10.100.102.13";
        public UDPCommunicationProtocol()
        {

        }



        public static void Connect()
        {
            
            UdpClient udpClient = new UdpClient(11000);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(serverIP), 0);
            udpClient.Connect(endPoint);

            udpClient.Close();


        }

        public static void Send()
        {
            //string serverIP = "10.100.102.13";
            UdpClient udpClient = new UdpClient(11000);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(serverIP), 0);
            udpClient.Connect(endPoint);

            Thread tread = new Thread( ()=>
            {
                Byte[] sendBytes = Encoding.ASCII.GetBytes("Is anybody there?"); ;
                Thread.Sleep(100);
                udpClient.Send(sendBytes, 2);
                udpClient.Close();

                //System.Console.WriteLine();
            });

            tread.Start();
            
        }

        public static void Recieve()
        {
            IPEndPoint remoteIpEndPoint = new IPEndPoint(IPAddress.Parse(serverIP), 0);
            UdpClient udpClient = new UdpClient(10101);
            byte[] buffer;

            while (true)
            {
                buffer = udpClient.Receive(ref remoteIpEndPoint);

                {
                    foreach (var el in buffer)
                        System.Console.Write((char)el);
                    if (buffer[0] == 'c')
                    {
                        UdpClient udpClientt = new UdpClient();
                        Thread.Sleep(100);


                    }
                }

                System.Console.WriteLine();
            }
        }

        //public static void DoWork()
        //{
        //    while (true)
        //    {
        //        Byte[] sendBytes = Encoding.ASCII.GetBytes("Is anybody there?"); ;
        //        Thread.Sleep(100);
        //        udpClient.Send(sendBytes, 2);
        //        udpClient.Close();

        //        System.Console.WriteLine();
        //    }
        //}


    }
}
