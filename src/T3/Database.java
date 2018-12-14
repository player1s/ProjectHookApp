package T3;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class Database implements IDatabase {

    @Override
    public String getFirstName(String phoneNumber) {

        String name = null;
        String password = "www";

        try (Connection connection = DriverManager.getConnection(
                "jdbc:postgresql://localhost:5432/postgres", "postgres", password)) {


            System.out.println("Connected to PostgreSQL database!");

           Statement statement = connection.createStatement();
            ResultSet resultSet = statement.executeQuery("SELECT * FROM public.users");

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
                    name =  resultSet.getString("userPassword");

            }

        }  catch (SQLException e) {
            System.out.println("Connection failure.");
            e.printStackTrace();
        }

        return name;
    }
}
