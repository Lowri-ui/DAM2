package Unidad1;
//2. Proceso con ProcessBuilder
//        Crea un programa en Java que lance el comando ping a una dirección web (por
//        ejemplo, google.com) usando la clase ProcessBuilder. Haz que tu programa espere a
//        que el proceso termine con waitFor() y, al finalizar, muestre el código de salida
//        (exitCode) indicando si ha finalizado correctamente o con error.

import java.io.IOException;

public class actividad2 {
    public static void main(String[] args) throws IOException {
        try{
            ProcessBuilder pb = new ProcessBuilder("ping","google.com");
            Process process = pb.start();
            int codigo = process.waitFor();
            System.out.println("Código de salida: " + codigo);

        } catch (IOException e) {
            throw new RuntimeException(e);
        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        }
    }
}
