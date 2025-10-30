package Unidad2.InterfazRunnable;

public class MiRunnable implements Runnable {

    @Override
    public void run() {
        System.out.println("Ejecutando Hilo"+Thread.currentThread().getName());
    }
}
