package T3.Control;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import static org.junit.jupiter.api.Assertions.*;

//class with a responsibility to make calls to a PostgreSQL database, stored locally
public class Database implements IDatabase {


    //every method (ecxept the last two, getall(), setupnewuser()) works the same as this one. last two individually described
    @Override
    public String getFirstName(String phoneNumber) {
        // set up password
        String name = null;
        String password = "www";

        // try to connect to the database
        try (Connection connection = DriverManager.getConnection(
                "jdbc:postgresql://localhost:5432/postgres", "postgres", password)) {


            System.out.println("Connected to PostgreSQL database!");

            // create the statement object, which later on gets executed in the connected database
           Statement statement = connection.createStatement();
            ResultSet resultSet = statement.executeQuery("SELECT * FROM public.users");

            //the result is being written to a variable, which gets returned
            while (resultSet.next()) {

                if(phoneNumber.equals(resultSet.getString("PhoneNumber")) )
                    name =  resultSet.getString("FirstName");

            }

        }  catch (SQLException e) {
            System.out.println("Connection failure.");
            e.printStackTrace();
        }

        return name;
    }

    @Override
    public String getLastName(String phoneNumber) {

        String name = null;
        String password = "www";

        try (Connection connection = DriverManager.getConnection(
                "jdbc:postgresql://localhost:5432/postgres", "postgres", password)) {

            Statement statement = connection.createStatement();
            ResultSet resultSet = statement.executeQuery("SELECT * FROM public.users");

            while (resultSet.next()) {

                if(phoneNumber.equals(resultSet.getString("PhoneNumber")) )
                    name =  resultSet.getString("LastName");

            }

        }  catch (SQLException e) {
            System.out.println("Connection failure.");
            e.printStackTrace();
        }

        return name;
    }

    @Override
    public String getGender(String phoneNumber) {

        String name = null;
        String password = "www";

        try (Connection connection = DriverManager.getConnection(
                "jdbc:postgresql://localhost:5432/postgres", "postgres", password)) {

            Statement statement = connection.createStatement();
            ResultSet resultSet = statement.executeQuery("SELECT * FROM public.users");

            while (resultSet.next()) {

                if(phoneNumber.equals(resultSet.getInt("PhoneNumber")) )
                    name =  resultSet.getString("Gender");

            }

        }  catch (SQLException e) {
            System.out.println("Connection failure.");
            e.printStackTrace();
        }

        return name;
    }

    @Override
    public String getDescription(String phoneNumber) {

        String name = null;
        String password = "www";

        try (Connection connection = DriverManager.getConnection(
                "jdbc:postgresql://localhost:5432/postgres", "postgres", password)) {

            Statement statement = connection.createStatement();
            ResultSet resultSet = statement.executeQuery("SELECT * FROM public.users");

            while (resultSet.next()) {

                if(phoneNumber.equals(resultSet.getInt("PhoneNumber")) )
                    name =  resultSet.getString("Description");

            }

        }  catch (SQLException e) {
            System.out.println("Connection failure.");
            e.printStackTrace();
        }

        return name;
    }

    @Override
    public Double getLocX(String phoneNumber) {
        Double name = null;
        String password = "www";

        try (Connection connection = DriverManager.getConnection(
                "jdbc:postgresql://localhost:5432/postgres", "postgres", password)) {

            Statement statement = connection.createStatement();
            ResultSet resultSet = statement.executeQuery("SELECT * FROM public.users");

            while (resultSet.next()) {

                if(phoneNumber.equals(resultSet.getString("PhoneNumber")) )
                    name =  resultSet.getDouble("LocX");

            }

        }  catch (SQLException e) {
            System.out.println("Connection failure.");
            e.printStackTrace();
        }

        return name;
    }


    @Override
    public Double getLocY(String phoneNumber) {
        Double name = null;
        String password = "www";

        try (Connection connection = DriverManager.getConnection(
                "jdbc:postgresql://localhost:5432/postgres", "postgres", password)) {

            Statement statement = connection.createStatement();
            ResultSet resultSet = statement.executeQuery("SELECT * FROM public.users");

            while (resultSet.next()) {

                if(phoneNumber.equals(resultSet.getString("PhoneNumber")) )
                    name =  resultSet.getDouble("LocY");

            }

        }  catch (SQLException e) {
            System.out.println("Connection failure.");
            e.printStackTrace();
        }

        return name;
    }

    @Override
    public String getOTP(String phoneNumber) {
        String name = null;
        String password = "www";

        try (Connection connection = DriverManager.getConnection(
                "jdbc:postgresql://localhost:5432/postgres", "postgres", password)) {

            Statement statement = connection.createStatement();
            ResultSet resultSet = statement.executeQuery("SELECT * FROM public.users");

            while (resultSet.next()) {

                if(phoneNumber.equals(resultSet.getString("PhoneNumber")) )
                    name =  resultSet.getString("otp");

            }

        }  catch (SQLException e) {
            System.out.println("Connection failure.");
            e.printStackTrace();
        }

        return name;
    }

    @Override
    public String getAge(String phoneNumber) {
        String name = null;
        String password = "www";

        try (Connection connection = DriverManager.getConnection(
                "jdbc:postgresql://localhost:5432/postgres", "postgres", password)) {

            Statement statement = connection.createStatement();
            ResultSet resultSet = statement.executeQuery("SELECT * FROM public.users");

            while (resultSet.next()) {

                if(phoneNumber.equals(resultSet.getString("PhoneNumber")) )
                    name =  resultSet.getString("Age");

            }

        }  catch (SQLException e) {
            System.out.println("Connection failure.");
            e.printStackTrace();
        }

        return name;
    }

    // until the resultset, same process
    @Override
    public String getAll(String phoneNumber, String minAge, String maxAge, String gender) {

            String name = "";
            String password = "www";

                try (Connection connection = DriverManager.getConnection(
                    "jdbc:postgresql://localhost:5432/postgres", "postgres", password)) {


                System.out.println("Connected to PostgreSQL database!");

                Statement statement = connection.createStatement();
                ResultSet resultSet = statement.executeQuery("SELECT * FROM public.users");

                //here the difference is that we need to decide whether the search preference is male, or female, or both.
                    // i opted for creating an if-else when both genders are being searched for, then gender is not a criteria
                    //and when a specific gender is being searched for then the passed down variable is indeed a criteria.
                while (resultSet.next()) {

                    if(gender.equals("no preference set")) {
                        if ((!(phoneNumber.equals(resultSet.getString("PhoneNumber"))))
                                && Integer.parseInt(minAge) < Integer.parseInt(resultSet.getString("Age"))
                                && Integer.parseInt(maxAge) > Integer.parseInt(resultSet.getString("Age")))
                            name += resultSet.getString("FirstName") + ",";
                    }

                    else
                    {
                        if ((!(phoneNumber.equals(resultSet.getString("PhoneNumber"))))
                                && Integer.parseInt(minAge) < Integer.parseInt(resultSet.getString("Age"))
                                && Integer.parseInt(maxAge) > Integer.parseInt(resultSet.getString("Age"))
                                && gender.equals(resultSet.getString("Gender")))
                            name += resultSet.getString("FirstName") + ",";
                    }
                }

            }  catch (SQLException e) {
                System.out.println("Connection failure.");
                e.printStackTrace();
            }

           // assertEquals("Any other name,", name);

            return name;
        }

        // also the same process but until the statement
    @Override
    public String setupNewUser(String phonenumber, String firstName, String lastName, String description, String age, String gender, String pw) {
        String name = "added";
        String password = "www";

        try (Connection connection = DriverManager.getConnection(
                "jdbc:postgresql://localhost:5432/postgres", "postgres", password)) {

            // this is the only statement that is not SELECT, as we are creating an account with this method
            Statement statement = connection.createStatement();
            statement.executeQuery("INSERT INTO users VALUES('" + firstName + "', '"+ lastName + "', '"+gender+"', '"+description+"', 0, 0, '"+phonenumber+"', '"+pw+"', '"+age+"');");
        }  catch (SQLException e) {
            System.out.println("Connection failure.");
            e.printStackTrace();
        }

        return name;
    }

}
