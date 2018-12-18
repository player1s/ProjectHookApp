package T3;

//A model class, to contain the object based on which a new user is created in the database
public class MCreateAcc {
    private String PhoneNumber;
    private String FirstName;
    private String LastName;
    private String Gender;
    private String Age;
    private String Description;

    public String getPassword() {
        return Password;
    }

    public void setPassword(String password) {
        Password = password;
    }

    public MCreateAcc(String phoneNumber, String firstName, String lastName, String gender, String age, String description, String password) {
        PhoneNumber = phoneNumber;
        FirstName = firstName;
        LastName = lastName;
        Gender = gender;
        Age = age;
        Description = description;
        Password = password;
    }

    private String Password;

    public String getPhoneNumber() {
        return PhoneNumber;
    }

    public void setPhoneNumber(String phoneNumber) {
        PhoneNumber = phoneNumber;
    }

    public String getFirstName() {
        return FirstName;
    }

    public void setFirstName(String firstName) {
        FirstName = firstName;
    }

    public String getLastName() {
        return LastName;
    }

    public void setLastName(String lastName) {
        LastName = lastName;
    }

    public String getGender() {
        return Gender;
    }

    public void setGender(String gender) {
        Gender = gender;
    }

    public String getAge() {
        return Age;
    }

    public void setAge(String age) {
        Age = age;
    }

    public String getDescription() {
        return Description;
    }

    public void setDescription(String description) {
        Description = description;
    }
}
