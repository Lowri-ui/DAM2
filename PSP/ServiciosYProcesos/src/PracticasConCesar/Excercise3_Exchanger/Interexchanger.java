package PracticasConCesar.Excercise3_Exchanger;

import java.util.concurrent.Exchanger;

public class Interexchanger {
    static void main(String[] args) {
        Exchanger<String> exchanger = new Exchanger<>();
        new Thread (new ClassA(exchanger)).start();
        new Thread (new ClassB(exchanger)).start();
    }
}
