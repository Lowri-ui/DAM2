package Unidad1;

import java.io.IOException;

public class actividad1 {
//    1. Proceso con Runtime
//    Escribe un programa en Java que utilice la clase Runtime y el metodo exec() para
//    lanzar una aplicación externa sencilla, como el Bloc de Notas en Windows o el editor
//    gedit en Linux.
//    Comprueba que el proceso se abre de manera independiente al programa Java y que,
//    al cerrarlo, el programa Java continúa su ejecución normal.

    static void main(String[] args) {
        //Lanzamos un try-with resources , este recoge IOException
        try{
            //Creamos el objeto Proceso y ejecutamos la clase Runtime con su metodo exec().

            /**
             * String[] procesoNotepadFile = ("Notepad.exe","Entrar_SQL_Laura.txt")
             * Process p = Runtime.getRuntime().exec(procesoNotepadFile);
             */

            Process p = Runtime.getRuntime().exec("Notepad.exe \"C:\\Users\\DAM2_Diurno\\Desktop\\Entrar_SQL_Laura.txt\"");
            //Mostramos un mensaje de confirmación
            System.out.printf("Proceso lanzado correctamente\n");
        } catch (IOException e) {
            throw new RuntimeException(e);
        }
    }
}
