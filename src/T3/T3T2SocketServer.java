package T3;

import com.google.gson.*;

import java.io.IOException;
import java.io.PrintStream;
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
        Command cmd = new Command("base", 127);

        try {

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






