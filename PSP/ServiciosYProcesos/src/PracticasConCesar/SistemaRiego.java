package PracticasConCesar;

import java.util.Timer;
import java.util.TimerTask;

public class SistemaRiego extends TimerTask {
    @Override
    public void run() {
        System.out.println("Regado");
    }
    public static void main(String[] args) throws InterruptedException {
        Timer timer = new Timer();
        timer.schedule(new SistemaRiego(), 0, 1000);
        Thread.sleep(2000);
        timer.cancel();
    }
}
