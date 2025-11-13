package PracticasUD2.Ej16;

public class HiloRunnableLambda {
    private long inicio, fin;
    private Thread thread;
    public HiloRunnableLambda(long inicio, long fin) {
        this.inicio = inicio;
        this.fin = fin;

        thread = new Thread(() -> {
            for(long i = inicio; i<fin; i++) {
            }
            System.out.println("Hilo Lambda terminado:"+" desde "+ inicio+ " hasta "+ fin);
        });
    }
    //creamos el metodo start para iniciar el Lambda
    public void start() {
        thread.start();
    }
    //Generamos el metodo join()
    public void join() throws InterruptedException {
        try{
            thread.join();
        }catch(InterruptedException e){
            e.printStackTrace();
        }
    }
}
