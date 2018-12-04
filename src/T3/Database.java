package T3;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class Database {
    public static void main(String[] args) {
        try (Connection connection = DriverManager.getConnection(
                "jdbc:postgresql://localhost:5432/postgres", "postgres", "www")) {

            System.out.println("Connected to PostgreSQL database!");
            Statement statement = connection.createStatement();

            System.out.println("Reading records...");
            ResultSet resultSet = statement.executeQuery("SELECT * FROM public.users");

            while (resultSet.next()) {
                System.out.println(resultSet.getInt("UserID") + " | "
                        + resultSet.getString("FirstName") + " | "
                        + resultSet.getString("LastName") + " | "
                        + resultSet.getString("gender") + " | "
                        + resultSet.getString("Description") + " | "
                        + resultSet.getString("LocX") + " | "
                        + resultSet.getString("LocY") + " | "
                        + resultSet.getString("PhoneNumber") + " | "
                        + resultSet.getString("OTP"));
            }

        }  catch (SQLException e) {
            System.out.println("Connection failure.");
            e.printStackTrace();
        }
    }
}