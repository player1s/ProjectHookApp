package T3;

import java.io.IOException;
import java.io.PrintStream;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.Scanner;
public class T3T2SocketServer
{
    public static void main(String[] args) throws IOException
    {
        int port = 1342;
        String text;
        while(true) {
            ServerSocket s1 = new ServerSocket(port);
            System.out.println("server runnin' on port: " + port);
            Socket acceptConn = s1.accept();
            System.out.println("someone knockin'");
            Scanner sc = new Scanner(acceptConn.getInputStream());
            System.out.println("someone knockin'");
            text = sc.nextLine();
            System.out.println("some connected saying:  " + text);
          //  PrintStream p = new PrintStream(acceptConn.getOutputStream());
          //  p.println(text);
            s1.close();
        }
    }
}




