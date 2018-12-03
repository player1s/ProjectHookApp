public class Profile implements IModel{

    private String name;
    private int age;
    private String gender;
    private String description;
    // private int photo;

    public Profile(String name, int age, String gender, String description)
    {
        this.name = name;
        this.age = age;
        this.gender = gender;
        this.description = description;
    }

    public String getName()
    {
        return name;
    }

    public void setName(String name)
    {
        this.name = name;
    }

    public int getage()
    {
        return age;
    }

    public void setage(int age)
    {
        this.age = age;
    }

    public String getGender()
    {
        return gender;
    }

    public void setGender(String gender)
    {
        this.gender = gender;
    }

    public String getDescription()
    {
        return description;
    }

    public void setDescription(String description)
    {
        this.description = description;
    }

    @Override
    public String getAll() {

        String ret = "";
        ret += name + " ";
        ret += age + " ";
        ret += gender + " ";
        ret += description + " ";

        return ret;
    }



}
