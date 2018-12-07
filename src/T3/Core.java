package T3;

public class Core {

    public static void main(String[] args) {

        IDatabase db = new Database();
        System.out.println(db.getFirstName(12346789));
        System.out.println(db.getLastName(12346789));
        System.out.println(db.getDescription(12346789));
        System.out.println(db.getGender(12346789));
        System.out.println(db.getLocY(12346789));
        System.out.println(db.getLocX(12346789));
        System.out.println(db.getOTP(12346789));

    }

}
