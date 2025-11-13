package PracticasUD2.Ej16;

public class MainEjercicio16 {
    public static void main(String[] args) throws InterruptedException {

        //Primeros 10 hilos con Thread
        HiloThread h1 = new HiloThread(1,5000000);
        HiloThread h2 = new HiloThread(5000001,10000000);
        HiloThread h3 = new HiloThread(10000001,15000000);
        HiloThread h4 = new HiloThread(15000001,20000000);
        HiloThread h5 = new HiloThread(20000001,25000000);
        HiloThread h6 = new HiloThread(25000001,30000000);
        HiloThread h7 = new HiloThread(30000001,35000000);
        HiloThread h8 = new HiloThread(35000001,40000000);
        HiloThread h9 = new HiloThread(40000001,45000000);
        HiloThread h10 = new HiloThread(45000001,50000000);

        //5 Hilos con Lambda
        HiloRunnableLambda h11 = new HiloRunnableLambda(50000001,55000000);
        HiloRunnableLambda h12 = new HiloRunnableLambda(55000001,60000000);
        HiloRunnableLambda h13 = new HiloRunnableLambda(60000001,65000000);
        HiloRunnableLambda h14 = new HiloRunnableLambda(65000001,70000000);
        HiloRunnableLambda h15 = new HiloRunnableLambda(70000001,75000000);

        //5 Hilos con Clase Anónima
        HiloClaseAnonima h16 = new HiloClaseAnonima(75000001,80000000);
        HiloClaseAnonima h17 = new HiloClaseAnonima(80000001,85000000);
        HiloClaseAnonima h18 = new HiloClaseAnonima(85000001,90000000);
        HiloClaseAnonima h19 = new HiloClaseAnonima(90000001,95000000);
        HiloClaseAnonima h20 = new HiloClaseAnonima(95000001,100000000);

        /**
         * CREAREMOS 3 ARRAYS para cada tipo de hilo, que después recorreremos para iniciar cada hilo 
         * y realizar el join, con el objetivo de que se ejecuten cada uno de forma organizada.
         */
        HiloThread[] hilosThreads = {h1,h2,h3,h4,h5,h6,h7,h8,h9,h10};
        HiloRunnableLambda[] hilosRunnables = {h11,h12,h13,h14,h15};
        HiloClaseAnonima[] hilosClases = {h16,h17,h18,h19,h20};

        //Iniciamos los 10 primeros hilos con Thread
        for(HiloThread h:hilosThreads){
            h.start();
            h.join();
        }

        //Iniciamos los 5 hilos Lambda
        for(HiloRunnableLambda h:hilosRunnables){
            h.start();
            h.join();
        }

        //Iniciamos los últimos 5 hilos Clase Anónima
        for(HiloClaseAnonima h:hilosClases){
            h.start();
            h.join();
        }

    }
}
