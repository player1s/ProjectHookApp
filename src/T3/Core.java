package T3;

import com.google.gson.Gson;

public class Core {

    public static void main(String[] args) {

        /*
        System.out.println(db.getFirstName(12346789));
        System.out.println(db.getLastName(12346789));
        System.out.println(db.getDescription(12346789));
        System.out.println(db.getGender(12346789));
        System.out.println(db.getLocY(12346789));
        System.out.println(db.getLocX(12346789));
        System.out.println(db.getOTP(12346789));
        order: cmd - pn - otp
        */

        IDatabase db = new Database();
        ISocketServer scktSrvr = new T3T2SocketServer();
        Gson gson = new Gson();
        int port = 1342;
        String OTP = "nuttin' here";
        String[] msgParts; 
        Command cmd;

        while(true) {
            cmd = (Command) scktSrvr.StartUpServer(port);
            System.out.println("is " + cmd.getOrder() + " equals to login? pc thinks " + (cmd.getOrder().equals("Login")));

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
                OTP = db.getAll(cmd.getPhoneNumber());
                LoginResponse response = new LoginResponse(OTP);
                String json = gson.toJson(response);
                System.out.println("json that gonna be sent back: " + json);
                scktSrvr.Respond(json);
            }
            scktSrvr.ShutdownServer();
        }

    }

}
