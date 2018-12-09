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
        String[] msgParts;

        while(true) {
            msgParts = scktSrvr.StartUpServer(port);

            if(msgParts[0].equals("Login"))
            {
                scktSrvr.SendLogin(db.getOTP(msgParts[1]));
                scktSrvr.ShutdownServer();

            }
        }

    }

}
