package T3;

import com.google.gson.*;

import javax.net.ServerSocketFactory;
import javax.net.ssl.SSLServerSocket;
import javax.net.ssl.SSLServerSocketFactory;
import javax.net.ssl.SSLSocket;
import javax.net.ssl.SSLSocketFactory;
import java.io.*;
import java.lang.reflect.Type;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.Scanner;

public class T3T2SocketServer implements ISocketServer {

    ServerSocket s1 = null;
    Socket acceptConn = null;
    String[] msgParts = null;



    @Override
    public Object StartUpServer(int port) {

        // default port: 1342;
        String text = "";
        Gson gson = new Gson();
        Command cmd = null;

        try {
/*
            ServerSocketFactory factory = SSLServerSocketFactory.getDefault();

            try (ServerSocket listener = factory.createServerSocket(port)) {
                ((SSLServerSocket) listener).setNeedClientAuth(true);
                ((SSLServerSocket) listener).setEnabledCipherSuites(
                        new String[] { "TLS_DHE_DSS_WITH_AES_256_CBC_SHA256"});
                ((SSLServerSocket) listener).setEnabledProtocols(
                        new String[] { "TLSv1.2"});
                System.out.println("server runnin' on port: " + port);
                while (true) {
                    try (Socket socket = listener.accept()) {
                        PrintWriter out = new PrintWriter(socket.getOutputStream(), true);
                        out.println("Hello World!");
                    }
                }
            }
*/

             this.s1 = new ServerSocket(port);

            System.out.println("server runnin' on port: " + port);

                this.acceptConn = s1.accept();

                Scanner sc = new Scanner(acceptConn.getInputStream());
                text = sc.nextLine();
                System.out.println("incoming json: " + text);
//----------------------------------------------------
                 cmd = gson.fromJson(text, Command.class);



        } catch (IOException e) {
            e.printStackTrace();
        }
        return cmd;
    }

    @Override
    public void Respond(String Response) {

        PrintStream p = null;
        try {
            p = new PrintStream(acceptConn.getOutputStream());
            p.println(Response);
            System.out.println("sent: " + Response);
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






