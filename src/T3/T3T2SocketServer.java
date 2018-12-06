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
        int number;
        int temp;
        ServerSocket s1 = new ServerSocket(1342);
        Socket acceptConn = s1.accept();
        Scanner sc = new Scanner(acceptConn.getInputStream());
        number = sc.nextInt();
        temp = number*10;
        PrintStream p = new PrintStream(acceptConn.getOutputStream());
        p.println(temp);
    }
}




