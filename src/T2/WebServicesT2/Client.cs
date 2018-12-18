using Newtonsoft.Json;
using System;  
using System.Net;  
using System.Net.Sockets;  
using System.Text;  

public class Client  
{  

    public Client()
    {}  
    // the method that is responsible for communicating with the database tier via sockets
    public static String Listen(String toSend)  
    {  
        byte[] bytes = new byte[1024];  
        int bytesRec = 0;
        toSend = toSend + "\n";

        try
        {  
           String hostEntry = "localhost";
           IPHostEntry host = Dns.GetHostEntry(hostEntry);  
           IPAddress ipAddress = host.AddressList[0];  

            // identifying possible host ip addressres
           for (int i = 0; i < host.AddressList.Length; i++)
           {
                Console.WriteLine(host.AddressList[i]);
           }

           int port = 1342;
  
            // Create a TCP/IP  socket.    
            Socket sender = new Socket(ipAddress.AddressFamily,  
                SocketType.Stream, ProtocolType.Tcp);  
            
            try  
            {  
                // Connect to Remote EndPoint  
                sender.Connect(hostEntry, port);  
  
                Console.WriteLine("Socket connected to {0}",  
                    sender.RemoteEndPoint.ToString());  
  
                // Encode the data string into a byte array.    
                byte[] msg = Encoding.ASCII.GetBytes(toSend);  
                Console.WriteLine("msg encoded");
                
                // Send the data through the socket.    
                int bytesSent = sender.Send(msg);  
                Console.WriteLine("msg sent");

                // receive response from database tier
                bytesRec = sender.Receive(bytes);  
                Console.WriteLine("Echoed test = {0}",  
                    Encoding.ASCII.GetString(bytes, 0, bytesRec)); 

                // close the connection
                sender.Shutdown(SocketShutdown.Both);  
                sender.Close();  
                Console.WriteLine("released");
  
            }  
            catch (ArgumentNullException ane)  
            {  
                Console.WriteLine("ArgumentNullException : {0}", ane.ToString());  
            }  
            catch (SocketException se)  
            {  
                Console.WriteLine("SocketException : {0}", se.ToString());  
            }  
            catch (Exception e)  
            {  
                Console.WriteLine("Unexpected exception : {0}", e.ToString());  
            }  
  
        }  
        catch (Exception e)  
        {  
            Console.WriteLine(e.ToString());  
        }  
        //return the answer of the database tier to the request before
        return Encoding.ASCII.GetString(bytes, 0, bytesRec);
    }   
}