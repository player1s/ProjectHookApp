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
    String getAge(String phoneNumber);

    String getAll(String phoneNumber, String minAge, String maxAge, String gender);

    /*
    String setFirstName();
    String setLastName();
    String setGender();
    String setDescription();
    String setAge();
*/
    String setupNewUser(String phonenumber, String firstName, String lastName, String description, String age, String gender, String pw);



}
