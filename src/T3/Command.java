package T3;

public class Command {

    private String Order;
    private String PhoneNumber;
    private String FirstName;
    private String LastName;
    private String Gender;
    private String Age;
    private String Description;
    private String Password;
    private String MinAge;
    private String MaxAge;

    public String getOrder() {
        return Order;
    }

    public String getPassword() {
        return Password;
    }

    public String getMinAge() {
        return MinAge;
    }

    public void setMinAge(String minAge) {
        MinAge = minAge;
    }

    public String getMaxAge() {
        return MaxAge;
    }

    public void setMaxAge(String maxAge) {
        MaxAge = maxAge;
    }

    public void setPassword(String password) {
        Password = password;
    }

    public void setOrder(String order) {
        Order = order;
    }

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

    public Command(String order, String phoneNumber, String firstName, String lastName, String gender, String age, String description, String password, String minAge, String maxAge) {
        Order = order;
        PhoneNumber = phoneNumber;
        FirstName = firstName;
        LastName = lastName;
        Gender = gender;
        Age = age;
        Description = description;
        Password = password;
        MinAge = minAge;
        MaxAge = maxAge;
    }
}
