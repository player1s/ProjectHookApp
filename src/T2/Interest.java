public class Interest implements IModel
{
    private Profile matchedWith;

    public Interest (Profile matchedWith)
    {
        this.matchedWith = matchedWith;
    }

    public Profile getMatchedWith()
    {
        return matchedWith;
    }

    public void setMatchedWith(Profile matchedWith)
    {
        this.matchedWith = matchedWith;
    }

    public String getAll() {

        String ret = matchedWith.getAll() + "";

        return ret;
    }
}
