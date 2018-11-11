public class OneTimePassword implements IModel {

    private int otp;

    public OneTimePassword(int num)
    {
        this.otp = num;
    }

    public int getOTP()
    {
        return otp;
    }

    public void setOTP(int otp)
    {
        this.otp = otp;
    }

    public String getAll() {

        String ret = otp + "";

        return ret;
    }
}