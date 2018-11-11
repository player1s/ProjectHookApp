public class SearchPreferences implements IModel {

    private int agemin;
    private int agemax;
    private int distance;
    private String gender;

    public SearchPreferences(int agemin, int agemax, int distance, String gender)
    {
        this.agemin = agemin;
        this.agemax = agemax;
        this.distance = distance;
        this.gender = gender;
    }

    public int getagemin()
    {
        return agemin;
    }

    public void setagemin(int agemin)
    {
        this.agemin = agemin;
    }

    public int getagemax()
    {
        return agemax;
    }

    public void setagemax(int agemax)
    {
        this.agemax = agemax;
    }

    public int getdistance()
    {
        return distance;
    }

    public void setdistance(int distance)
    {
        this.distance = distance;
    }

    public String getGender()
    {
        return gender;
    }

    public void setGender(String gender)
    {
        this.gender = gender;
    }

    @Override
    public String getAll() {

        String ret = "";
        ret += agemin + " ";
        ret += agemax + " ";
        ret += distance + " ";
        ret += gender + "";

        return ret;
    }
}
