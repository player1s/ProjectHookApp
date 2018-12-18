package T3;
// interface to create abstraction from core to socket communication class
public interface ISocketServer {

    Object StartUpServer(int port);
    void Respond(String Response);
    void ShutdownServer();

}
