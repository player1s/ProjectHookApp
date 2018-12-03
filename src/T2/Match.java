public class Match implements IModel
{
    private int distance;
    private Profile matchedWith;

    public Match (int distance, Profile matchedWith)
    {
        this.distance = distance;
        this.matchedWith = matchedWith;
    }

    public int getDistance()
    {
        return distance;
    }

    public void setDistance(int distance)
    {
        this.distance = distance;
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

        String ret = distance + " ";
         ret += matchedWith.getAll() + "";

        return ret;
    }
}
