package T3;

import java.sql.Connection;

public interface IDatabase {

    String getFirstName(String phoneNumber);
    String getLastName(String phoneNumber);
    String getGender(String phoneNumber);
    String getDescription(String phoneNumber);
    Double getLocX(String phoneNumber);
    Double getLocY(String phoneNumber);
    String getOTP(String phoneNumber);



}
