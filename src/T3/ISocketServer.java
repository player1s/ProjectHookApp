package T3;

public interface ISocketServer {

    Object StartUpServer(int port);
    void SendLogin(String OTP);
    void ShutdownServer();

}
