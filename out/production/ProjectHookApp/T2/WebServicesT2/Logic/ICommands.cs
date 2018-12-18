using System;

namespace Logic
{
    interface ICommands
    {
        String toLogIn(String command, String phonenumber, String password);
        String toCreateAccount(String command, String phonenumber, String firstName, String lastName, String description, String age, String gender, String password);
        String toGetAllPeople(String command, String phonenumber, String minAge, String maxAge, String gender);
    }
}
