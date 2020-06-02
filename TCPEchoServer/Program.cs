using System;
using System.IO;
using System.Net.Sockets;
using FupLib;

namespace TCPEchoServer
{
    class Program
    {
        static void Main(string[] args)
        {
            // opsætning af tcplistener på port 6789
            TcpListener serverSocket = new TcpListener(6789);
            // starter at lytte til klient anmodninger
            serverSocket.Start();

            TcpClient connectionSocket = serverSocket.AcceptTcpClient();
            //Socket connectionSocket = serverSocket.AcceptSocket();
            Console.WriteLine("Server activated");

            Stream ns = connectionSocket.GetStream();
            // Stream ns = new NetworkStream(connectionSocket);

            // aflæse 
            StreamReader sr = new StreamReader(ns);
            // skrive
            StreamWriter sw = new StreamWriter(ns);
            sw.AutoFlush = true; // enable automatic flushing

            string message = sr.ReadLine();
            string answer = "";
            while (message != null && message != "")
            {

                Console.WriteLine("Client: " + message);
                // answer = message.ToUpper(); 
                //A = average
                //T = total
                string[] array = message.Split(" ");
                if (array[0] == "A")
                {
                    answer = "Average: " + TransportCalc.Gennemsnit(int.Parse(array[1]), double.Parse(array[2]));
                }
                // Sender total metoden tilbagen
                else if (array[0] == "T")
                {
                    string toCalc = message.Remove(0, message.IndexOf(" ") + 1);
                    answer = "Total: " + TransportCalc.Total(toCalc);
                }
                else
                {
                    // Den sender metoden tilbage
                    answer = "For Total start with 'T', And for Average start with 'A'";
                }
                sw.WriteLine(answer);
                message = sr.ReadLine();

            }

            ns.Close();
            connectionSocket.Close();
            serverSocket.Stop();

        }
    }

}
