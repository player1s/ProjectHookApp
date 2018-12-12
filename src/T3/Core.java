package T3;

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
        int port = 1342;
        String OTP = "nuttin' here";
        String[] msgParts;
        Command cmd = new Command("base", 127);

        while(true) {
            cmd = (Command) scktSrvr.StartUpServer(port);

            if(cmd.getOrder().equals("Login"));
            {
                OTP = db.getOTP(cmd.getPhoneNumber());
                System.out.println("Sending back this as OTP: " + OTP);
            }
            scktSrvr.ShutdownServer();
        }

    }

}
