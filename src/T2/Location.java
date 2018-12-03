public class Location implements IModel {

    private double xCoords;
    private double yCoords;

    public Location(int xCoords, int yCoords)
    {
        this.xCoords = xCoords;
        this.yCoords = yCoords;
    }

    public double getXCoords ()
    {
        return xCoords;
    }

    public void setXCoords (int xCoords)
    {
        this.xCoords = xCoords;
    }

    public double getYCoords ()
    {
        return yCoords;
    }

    public void setYCoords (int yCoords)
    {
        this.yCoords = yCoords;
    }

    @Override
    public String getAll() {

        String ret = "";
        ret += xCoords + " ";
        ret += yCoords + " ";

        return ret;
    }
}
