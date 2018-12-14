package T3;

public class Command {

    private String Order;
    private String PhoneNumber;

    public Command(String Order, String phonenumber)
    {
        this.Order = Order;
        this.PhoneNumber = phonenumber;
    }

    public String getOrder()
    {
        return Order;
    }

    public String getPhoneNumber()
    {
        return PhoneNumber;
    }

    public void setOrder(String Order)
    {
        this.Order = Order;
    }

    public void setPhoneNumber(String PhoneNumber)
    {
        this.PhoneNumber = PhoneNumber;
    }
}
