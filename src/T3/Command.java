package T3;

public class Command {

    private String Order;
    private int PhoneNumber;

    public Command(String Order, int phonenumber)
    {
        this.Order = Order;
        this.PhoneNumber = phonenumber;
    }

    public String getOrder()
    {
        return Order;
    }

    public int getPhoneNumber()
    {
        return PhoneNumber;
    }

    public void setOrder(String Order)
    {
        this.Order = Order;
    }

    public void setPhoneNumber(int PhoneNumber)
    {
        this.PhoneNumber = PhoneNumber;
    }
}
