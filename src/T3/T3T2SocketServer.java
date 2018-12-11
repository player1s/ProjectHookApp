package T3;

import java.io.IOException;
import java.io.PrintStream;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.Scanner;
public class T3T2SocketServer implements ISocketServer {

    ServerSocket s1 = null;
    Socket acceptConn = null;
    String[] msgParts = null;

    @Override
    public String[] StartUpServer(int port) {

        // default port: 1342;
        String text = "";

        try {

             this.s1 = new ServerSocket(port);

            System.out.println("server runnin' on port: " + port);

                this.acceptConn = s1.accept();


                Scanner sc = new Scanner(acceptConn.getInputStream());
                text = sc.nextLine();

            msgParts = text.split(" - ");

                for (int i = 0; i < msgParts.length; i++) {
                    System.out.println("some connected saying:  " + msgParts[i]);
                }

        } catch (IOException e) {
            e.printStackTrace();
        }
        return msgParts;
    }

    @Override
    public void SendLogin(String OTP) {

        PrintStream p = null;
        System.out.println("sendlogin entered");
        try {
            p = new PrintStream(acceptConn.getOutputStream());
            p.println(OTP);
            System.out.println("sent");
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    @Override
    public void ShutdownServer() {
        try {
            s1.close();
            System.out.println("Shutting down");
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}






