package PracticasUD2.Ej16;

public class HiloClaseAnonima {
    private long inicio, fin;
    private Thread thread;

    public HiloClaseAnonima(long inicio, long fin) {
        this.inicio = inicio;
        this.fin = fin;

        thread = new Thread(new Runnable() {
            @Override
            public void run() {
                for(long i = inicio; i<fin; i++) {
                }
                System.out.println("Hilo Clase Anónima terminado:"+" desde "+ inicio+ " hasta "+ fin);
            }
        });
    }
    //Generamos el metodo start()
    public void start() {
        thread.start();
    }
    //Creamos el metodo join()
    public void join() {
        try {
            thread.join();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
    }
}
