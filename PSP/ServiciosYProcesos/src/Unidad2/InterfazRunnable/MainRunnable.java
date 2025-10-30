package Unidad2.InterfazRunnable;

public class MainRunnable {
    static void main() {
        Thread thread = new Thread(new MiRunnable());
        thread.start();
    }
}
