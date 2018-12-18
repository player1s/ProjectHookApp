package T3.Control;

import T3.Model.Command;
import T3.Model.LoginResponse;
import com.google.gson.Gson;

public class Core {
    // main method and main class, the processes are being controlled from here
    public static void main(String[] args) {

        // instantiate the communication and the database handler, and other objects, variables
        IDatabase db = new Database();
        ISocketServer scktSrvr = new T3T2SocketServer();
        Gson gson = new Gson();
        int port = 1342;
        String OTP = "nuttin' here";
        String[] msgParts; 
        Command cmd;

        // infinite loop to simulate as an ongoing online server.
        // the program execution stops when it is waiting for a connection, so it does not rotate pointlessly
        while(true) {
            // start server, this returns the deserialized object
            cmd = (Command) scktSrvr.StartUpServer(port);
            System.out.println("is " + cmd.getOrder() + " equals to login? pc thinks " + (cmd.getOrder().equals("Login")));

            //the following if statements and the message structure is designed to let the database tier know,
            // what function was requested from the presentation tier
            if(cmd.getOrder().equals("Login"))
            {
                System.out.println("got called");
                OTP = db.getOTP(cmd.getPhoneNumber());
                LoginResponse response = new LoginResponse(OTP);
                String json = gson.toJson(response);
                System.out.println("json that gonna be sent back: " + json);
                scktSrvr.Respond(json);
            }

            if(cmd.getOrder().equals("CreateAcc"))
            {
                System.out.println("also dis got called");
                OTP = db.setupNewUser(cmd.getPhoneNumber(), cmd.getFirstName(), cmd.getLastName(), cmd.getDescription(), cmd.getAge(), cmd.getGender(), cmd.getPassword());
                LoginResponse response = new LoginResponse(OTP);
                String json = gson.toJson(response);
                System.out.println("json that gonna be sent back: " + json);
                scktSrvr.Respond(json);
            }

            if(cmd.getOrder().equals("GetAll"))
            {
                System.out.println("getall called");
                OTP = db.getAll(cmd.getPhoneNumber(), cmd.getMinAge(), cmd.getMaxAge(), cmd.getGender());
                LoginResponse response = new LoginResponse(OTP);
                String json = gson.toJson(response);
                System.out.println("json that gonna be sent back: " + json);
                scktSrvr.Respond(json);
            }
            // closes used connection, du to while true, a new connection will be opened, listening
            scktSrvr.ShutdownServer();
        }

    }
}
