package Unidad1;

import java.io.IOException;

public class actividad1 {
//    1. Proceso con Runtime
//    Escribe un programa en Java que utilice la clase Runtime y el método exec() para
//    lanzar una aplicación externa sencilla, como el Bloc de Notas en Windows o el editor
//    gedit en Linux.
//    Comprueba que el proceso se abre de manera independiente al programa Java y que,
//    al cerrarlo, el programa Java continúa su ejecución normal.

    static void main(String[] args) {
        try{
            Process p = Runtime.getRuntime().exec("notepad");
            System.out.printf("Proceso lanzado correctamente\n");
        } catch (IOException e) {
            throw new RuntimeException(e);
        }
    }
}
