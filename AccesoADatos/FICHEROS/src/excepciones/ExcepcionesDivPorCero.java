package excepciones;

public class ExcepcionesDivPorCero {
    static void main() {
        int a,b;
        a = 5;
        b = 2;
        try{
            System.out.println(a + "/" + b + "=" + a / b);
            b = 0;System.out.println(a + "/" + b + "=" + a / b);
            b = 3; System.out.println(a + "/" + b + "=" + a / b);
        } catch (ArithmeticException e) {
            System.out.println("Error of division: " + a + "/" + b + "=" + a / b);
        }
    }
}
