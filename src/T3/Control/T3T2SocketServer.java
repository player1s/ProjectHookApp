package T3.Control;

import T3.Model.Command;
import com.google.gson.*;

import java.io.*;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.Scanner;

//class with the responsibility to communicate with the logic layer via sockets and deserialize the incoming json
public class T3T2SocketServer implements ISocketServer {

    ServerSocket s1 = null;
    Socket acceptConn = null;
    String[] msgParts = null;


    //this method starts the socket server
    //works as:
    //1, initialize required variables
    //2, establish the serversocket on the specified port
    //3, listen for incoming requests
    //4, accept it
    //5, deserialize the incoming json
    @Override
    public Object StartUpServer(int port) {

        // default port: 1342;
        String text = "";
        Gson gson = new Gson();
        Command cmd = null;

        try {
             this.s1 = new ServerSocket(port);

            System.out.println("server runnin' on port: " + port);

                this.acceptConn = s1.accept();

                Scanner sc = new Scanner(acceptConn.getInputStream());
                text = sc.nextLine();
                System.out.println("incoming json: " + text);
                 cmd = gson.fromJson(text, Command.class);



        } catch (IOException e) {
            e.printStackTrace();
        }
        return cmd;
    }

    //this method is responsible for sending messages via the previously established (the server) socket connection
    // socket connection s1 was not closed so after initializing the right objects,
    // the communication channel  can be alive once again
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

    //method that is responsible for terminating the socket connection, once the request was completed
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






