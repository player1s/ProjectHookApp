public class PhoneNum implements IModel {

    private int phoneNumber;

    public PhoneNum(int num)
    {
        this.phoneNumber = num;
    }

    public int getPhoneNumber()
    {
        return phoneNumber;
    }

    public void setPhoneNumber(int num)
    {
        this.phoneNumber = num;
    }

    @Override
    public String getAll() {

        String ret = phoneNumber + "";

        return ret;
    }
}
