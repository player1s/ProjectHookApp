using System;  
using System.Net;  
using System.Net.Sockets;  
using System.Text;  
  
// Client app is the one sending messages to a Server/listener.   
// Both listener and client can send messages back and forth once a   
// communication is established.  
public class SocketClient  
{  

    public static int Main(String[] args)  
    {  
        StartClient();  
        return 0;  
    }  
  
  
    public static void StartClient()  
    {  
        byte[] bytes = new byte[1024];  
  
        try  
        {  
           IPHostEntry host = Dns.GetHostEntry("localhost");  
           IPAddress ipAddress = host.AddressList[0];  
           for (int i = 0; i < host.AddressList.Length; i++)
           {
                Console.WriteLine(host.AddressList[i]);
           }
           String thehost = "localhost";
           int port = 1342;
  
            // Create a TCP/IP  socket.    
            Socket sender = new Socket(ipAddress.AddressFamily,  
                SocketType.Stream, ProtocolType.Tcp);  
  
            // Connect the socket to the remote endpoint. Catch any errors.    
            try  
            {  
                // Connect to Remote EndPoint  
                sender.Connect(thehost, port);  
  
                Console.WriteLine("Socket connected to {0}",  
                    sender.RemoteEndPoint.ToString());  
  
                // Encode the data string into a byte array.    
                byte[] msg = Encoding.ASCII.GetBytes("MSG1");  
                Console.WriteLine("msg encoded");
                
                // Send the data through the socket.    
                int bytesSent = sender.Send(msg);  
                Console.WriteLine("msg sent");

                // Encode the data string into a byte array.    
                byte[] msg2 = Encoding.ASCII.GetBytes("MSG2");  
                Console.WriteLine("msg2 encoded");
                
                // Send the data through the socket.    
                int bytesSent2 = sender.Send(msg2);  
                Console.WriteLine("msg2 sent");
                // Receive the response from the remote device.  
                /*  
                int bytesRec = sender.Receive(bytes);  
                Console.WriteLine("Echoed test = {0}",  
                    Encoding.ASCII.GetString(bytes, 0, bytesRec));  
                Console.WriteLine("srvr replied");
                */
                // Release the socket.    
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
    }  
}