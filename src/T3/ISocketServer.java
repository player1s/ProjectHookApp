package T3;

public interface ISocketServer {

    Object StartUpServer(int port);
    void Respond(String Response);
    void ShutdownServer();

}
