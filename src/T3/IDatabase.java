package T3;

import java.sql.Connection;

public interface IDatabase {

    String getFirstName(int phoneNumber);
    String getLastName(int phoneNumber);
    String getGender(int phoneNumber);
    String getDescription(int phoneNumber);
    Double getLocX(int phoneNumber);
    Double getLocY(int phoneNumber);
    String getOTP(String phoneNumber);



}
