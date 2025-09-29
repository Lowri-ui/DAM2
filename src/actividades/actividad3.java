package actividades;

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.util.Scanner;

public class actividad3 {
    public static void main(String[] args) {
        //Crea un programa que busque un texto dado en un fichero de texto, y que muestre
        // para cada aparición la línea y la columna.
        // Se recomienda leer el fichero línea a línea y, dentro de cada línea, buscar las
        // apariciones del texto utilizando de la clase String un métodoo.

        // Verifica que se haya pasado el nombre del archivo como argumento de línea de comandos.
        if (args.length < 1) {
            System.out.println("Indicar por favor nombre de fichero.");
            return;
        }

        // Almacena el nombre del archivo pasado como argumento.
        String nomFich = args[0];

        //Pedimos al usuario que introduzca la palabra que busca
        System.out.println("Introduzca la palabra a buscar:");
        Scanner sc = new Scanner(System.in);
        String word = sc.nextLine();

        // Se usa un bloque try-with-resources para asegurar que el BufferedReader se cierre automáticamente.
        try (BufferedReader fbr = new BufferedReader(new FileReader(nomFich))) {
            int i = 0;
            String linea = fbr.readLine(); // Lee la primera línea del archivo.

            // Bucle que se ejecuta mientras haya líneas para leer (hasta que readLine() devuelva null).
            while (linea != null) {
                // Formatea e imprime el número de línea (incrementado) y el contenido de la línea.
                System.out.format("[%5d] %s", ++i, linea);
                System.out.println();
                linea = fbr.readLine(); // Lee la siguiente línea.

                int posicion = linea.indexOf(word);
                while(posicion != -1) {
                    System.out.println("La palabra " + word + "está en la línea " + i + ", columna " + posicion+1);
                    // Buscar la siguiente aparición en la misma línea
                    posicion = linea.indexOf(word, posicion + 1);
                }
            }
        }
        // Captura la excepción si el archivo no se encuentra.
        catch (FileNotFoundException e) {
            System.out.println("No existe fichero " + nomFich);
        }
        // Captura otras excepciones de E/S.
        catch (IOException e) {
            System.out.println("Error de E/S: " + e.getMessage());
        }
        // Captura cualquier otra excepción no especificada.
        catch (Exception e) {
            e.printStackTrace();
        }
    }
}
