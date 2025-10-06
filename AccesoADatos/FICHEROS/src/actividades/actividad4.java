package actividades;
import java.io.*;
import java.nio.charset.StandardCharsets;

public class actividad4 {
    public static void main(String[] args) {
        String archivoEntrada = args[0];
        String archivoSalidaISO = "salida_iso8859-1.txt";
        String archivoSalidaUTF16 = "salida_utf16.txt";

        try {
            // Leer el archivo UTF-8 línea a línea
            BufferedReader reader = new BufferedReader(new InputStreamReader(new FileInputStream(archivoEntrada), StandardCharsets.UTF_8));

            String linea;
            System.out.println("Contenido leído del archivo UTF-8:");
            while ((linea = reader.readLine()) != null) {
                System.out.println(linea);
                // Escribir en ISO-8859-1
                escribirLinea(archivoSalidaISO, linea, "ISO-8859-1");
                // Escribir en UTF-16
                escribirLinea(archivoSalidaUTF16, linea, "UTF-16");
            }
            reader.close();

            System.out.println("\nArchivos generados:");
            System.out.println("- " + archivoSalidaISO + " (ISO-8859-1)");
            System.out.println("- " + archivoSalidaUTF16 + " (UTF-16)");
            System.out.println("Verifica los archivos con un editor hexadecimal para ver diferencias.");

        } catch (IOException e) {
            System.err.println("Error: " + e.getMessage());
        }
    }

    private static void escribirLinea(String archivoSalida, String linea, String charset) throws IOException {
        BufferedWriter writer = new BufferedWriter(new OutputStreamWriter(new FileOutputStream(archivoSalida, true), charset));
        writer.write(linea);
        writer.newLine();
        writer.close();
    }
}
