package PracticasUD2.Ej16;

public class HiloThread extends Thread {
    private long inicio, fin;
    public HiloThread(long inicio, long fin) {
        this.inicio = inicio;
        this.fin = fin;

    }
    public void run() {
        for(long i = inicio; i<fin; i++) {
        }
        System.out.println("Hilo Thread terminado:"+" desde "+ inicio+ " hasta "+ fin);
    }
}
