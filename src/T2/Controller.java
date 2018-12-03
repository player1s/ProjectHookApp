public class Controller {

    public static void main(String[] args) {

        int num = 23;

        IModel PNModel = new PhoneNum(num);

        System.out.println(PNModel.toString());

    }
}
