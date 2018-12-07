package T3;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class Database implements IDatabase {

    @Override
    public String getFirstName(int phoneNumber) {

        String name = null;
        String password = "www";

        try (Connection connection = DriverManager.getConnection(
                "jdbc:postgresql://localhost:5432/postgres", "postgres", password)) {


            System.out.println("Connected to PostgreSQL database!");

           Statement statement = connection.createStatement();
            ResultSet resultSet = statement.executeQuery("SELECT * FROM public.users");

            while (resultSet.next()) {

                if(phoneNumber == resultSet.getInt("PhoneNumber") )
                    name =  resultSet.getString("FirstName");

            }

        }  catch (SQLException e) {
            System.out.println("Connection failure.");
            e.printStackTrace();
        }

        return name;
    }

    @Override
    public String getLastName(int phoneNumber) {

        String name = null;
        String password = "www";

        try (Connection connection = DriverManager.getConnection(
                "jdbc:postgresql://localhost:5432/postgres", "postgres", password)) {

            Statement statement = connection.createStatement();
            ResultSet resultSet = statement.executeQuery("SELECT * FROM public.users");

            while (resultSet.next()) {

                if(phoneNumber == resultSet.getInt("PhoneNumber") )
                    name =  resultSet.getString("LastName");

            }

        }  catch (SQLException e) {
            System.out.println("Connection failure.");
            e.printStackTrace();
        }

        return name;
    }

    @Override
    public String getGender(int phoneNumber) {

        String name = null;
        String password = "www";

        try (Connection connection = DriverManager.getConnection(
                "jdbc:postgresql://localhost:5432/postgres", "postgres", password)) {

            Statement statement = connection.createStatement();
            ResultSet resultSet = statement.executeQuery("SELECT * FROM public.users");

            while (resultSet.next()) {

                if(phoneNumber == resultSet.getInt("PhoneNumber") )
                    name =  resultSet.getString("Gender");

            }

        }  catch (SQLException e) {
            System.out.println("Connection failure.");
            e.printStackTrace();
        }

        return name;
    }

    @Override
    public String getDescription(int phoneNumber) {

        String name = null;
        String password = "www";

        try (Connection connection = DriverManager.getConnection(
                "jdbc:postgresql://localhost:5432/postgres", "postgres", password)) {

            Statement statement = connection.createStatement();
            ResultSet resultSet = statement.executeQuery("SELECT * FROM public.users");

            while (resultSet.next()) {

                if(phoneNumber == resultSet.getInt("PhoneNumber") )
                    name =  resultSet.getString("Description");

            }

        }  catch (SQLException e) {
            System.out.println("Connection failure.");
            e.printStackTrace();
        }

        return name;
    }

    @Override
    public Double getLocX(int phoneNumber) {
        Double name = null;
        String password = "www";

        try (Connection connection = DriverManager.getConnection(
                "jdbc:postgresql://localhost:5432/postgres", "postgres", password)) {

            Statement statement = connection.createStatement();
            ResultSet resultSet = statement.executeQuery("SELECT * FROM public.users");

            while (resultSet.next()) {

                if(phoneNumber == resultSet.getInt("PhoneNumber") )
                    name =  resultSet.getDouble("LocX");

            }

        }  catch (SQLException e) {
            System.out.println("Connection failure.");
            e.printStackTrace();
        }

        return name;
    }


    @Override
    public Double getLocY(int phoneNumber) {
        Double name = null;
        String password = "www";

        try (Connection connection = DriverManager.getConnection(
                "jdbc:postgresql://localhost:5432/postgres", "postgres", password)) {

            Statement statement = connection.createStatement();
            ResultSet resultSet = statement.executeQuery("SELECT * FROM public.users");

            while (resultSet.next()) {

                if(phoneNumber == resultSet.getInt("PhoneNumber") )
                    name =  resultSet.getDouble("LocY");

            }

        }  catch (SQLException e) {
            System.out.println("Connection failure.");
            e.printStackTrace();
        }

        return name;
    }

    @Override
    public Integer getOTP(int phoneNumber) {
        Integer name = null;
        String password = "www";

        try (Connection connection = DriverManager.getConnection(
                "jdbc:postgresql://localhost:5432/postgres", "postgres", password)) {

            Statement statement = connection.createStatement();
            ResultSet resultSet = statement.executeQuery("SELECT * FROM public.users");

            while (resultSet.next()) {

                if(phoneNumber == resultSet.getInt("PhoneNumber") )
                    name =  resultSet.getInt("OTP");

            }

        }  catch (SQLException e) {
            System.out.println("Connection failure.");
            e.printStackTrace();
        }

        return name;
    }
}
