package T3;

public interface ISocketServer {

    String[] StartUpServer(int port);
    void SendLogin(String OTP);
    void ShutdownServer();

}
