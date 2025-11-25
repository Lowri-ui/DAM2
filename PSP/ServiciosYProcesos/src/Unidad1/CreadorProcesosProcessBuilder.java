//
// Source code recreated from a .class file by IntelliJ IDEA
// (powered by FernFlower decompiler)
//

package Unidad1;

import java.io.File;
import java.io.IOException;

public class CreadorProcesosProcessBuilder {
    public static void main(String[] args) {
        try {
            ProcessBuilder pBuilder = new ProcessBuilder(new String[]{"notepad.exe", "prueba.txt"});
            pBuilder.directory(new File("\"C:\\Users\\DAM2_Diurno\\Desktop\\DirectorioLaura\""));
            System.out.println(pBuilder.environment());
            Process proceso = pBuilder.start();
            int valorRetorno = proceso.waitFor();
            if (valorRetorno == 0) {
                System.out.println("El proceso ha terminado bien.");
            } else {
                System.out.println("El proceso ha fallado. Código de error: " + valorRetorno);
            }
        } catch (InterruptedException | IOException e) {
            ((Exception)e).printStackTrace();
        }

    }
}
