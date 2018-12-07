package T3;

import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.Scanner;
public class T3T2SocketServer
{
    public static void main(String[] args) throws IOException
    {
        int port = 1342;
        ServerSocket s1 = new ServerSocket(port);
        String text = "";

        System.out.println("server runnin' on port: " + port);

        while(true) {

            Socket acceptConn = s1.accept();
            Scanner sc = new Scanner(acceptConn.getInputStream());
            text = sc.nextLine();
            System.out.println("some connected saying:  " + text);

        }
    }
}




