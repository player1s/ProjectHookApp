package T2.T2T3SocketClient;

import java.io.IOException;
import java.io.PrintStream;
import java.net.Socket;
import java.net.UnknownHostException;
import java.util.Scanner;
public class SocketClientTest
{
    public static void main(String[] args)
            throws UnknownHostException, IOException
    {
        int temp;
        int number;

        Scanner sc = new Scanner(System.in);
        Socket s = new Socket("127.0.0.1", 1342);
        Scanner sc1 = new Scanner(s.getInputStream());
        System.out.println("Enter a number");
        number = sc.nextInt();
        PrintStream p = new PrintStream(s.getOutputStream());
        p.println(number);
        temp = sc1.nextInt();
        System.out.print("The result is:");
        System.out.println(temp);
    }
}