package actividades;

import accesoaleatorio.FicheroAccesoAleatorio;
import javafx.util.Pair;
import java.io.File;
import java.io.IOException;
import java.io.RandomAccessFile;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class actividad7 {
//    Completa la clase FicheroAccesoAleatorio con un metodo que permita obtener el valor de un campo de un registro,
//    dada la posición del registro y el nombre del campo.
//    Por ejemplo: se podría acceder al valor del campo "Nombre" del registro situado en la posición 5 con obtenValorCampo(4, "Nombre").
//    Por coherencia con la manera en que se ha implementado el metodo insertar(), la posición del primer registro debe entenderse que es 0, no 1.
//    String debe tener el mismo formato que en la línea siguiente. Se recomienda utilizar el constructor String(byte[] bytes, Charset charset) de String.
//    Muestra el resultado de la ejecución del programa.

    public class FicheroAccesoAleatorio {

        private File f;
        private List<Pair<String, Integer>> campos;
        private long longReg;
        private long numReg = 0;

        /**
         * Constructor para inicializar la clase y el archivo de acceso aleatorio.
         * @param nomFich El nombre del archivo a utilizar.
         * @param campos  Una lista de pares (nombre del campo, longitud del campo)
         * @throws IOException Si ocurre un error al acceder al archivo.
         */
        FicheroAccesoAleatorio(String nomFich, List<Pair<String, Integer>> campos)
                throws IOException {
            this.campos = campos;
            this.f = new File(nomFich);
            longReg = 0;
            // Calcula la longitud total de un registro sumando las longitudes de todos los campos.
            for (Pair<String, Integer> campo: campos) {
                this.longReg += campo.getValue();
            }
            // Si el archivo ya existe, calcula el número de registros que contiene.
            if (f.exists()) {
                this.numReg=f.length()/this.longReg;
            }
        }

        /**
         * Devuelve el número de registros en el archivo.
         * @return El número de registros.
         */
        public long getNumReg() {
            return numReg;
        }

        /**
         * Inserta un nuevo registro al final del archivo.
         * @param reg Un mapa con los datos del registro (nombre del campo, valor).
         * @throws IOException Si ocurre un error de E/S.
         */
        public void insertar(Map<String, String> reg) throws IOException {
            insertar(reg, this.numReg++);
        }

        /**
         * Inserta un registro en una posición específica del archivo.
         * @param reg Un mapa con los datos del registro (nombre del campo, valor).
         * @param pos La posición (índice) donde se debe insertar el registro.
         * @throws IOException Si ocurre un error de E/S.
         */
        public void insertar(Map<String, String> reg, long pos) throws IOException {

            // Utiliza un bloque try-with-resources para asegurar el cierre automático del RandomAccessFile.
            try (RandomAccessFile faa = new RandomAccessFile(f, "rws")) {

                // Posiciona el puntero de escritura en el lugar correcto.
                // La posición se calcula multiplicando la posición del registro por la longitud de cada registro.
                faa.seek(pos * this.longReg);

                // Itera sobre los campos definidos para el registro.
                for (Pair<String, Integer> campo: this.campos) {
                    String nomCampo=campo.getKey();
                    Integer longCampo = campo.getValue();
                    String valorCampo = reg.get(nomCampo);

                    // Si el valor del campo no se encuentra en el mapa, se usa una cadena vacía.
                    if (valorCampo == null) {
                        valorCampo = "";
                    }

                    // Formatea el valor del campo para que tenga la longitud fija.
                    // %1$-... s significa que se alinea a la izquierda y se rellena con espacios.
                    String valorCampoForm = String.format("%1$-" + longCampo + "s",
                            valorCampo);

                    // Escribe los bytes del valor formateado en el archivo.
                    faa.write(valorCampoForm.getBytes("UTF-8"), 0, longCampo);
                }
            }
        }

        public void obtenerValor (int posicion, String campo) throws IOException {
            //Abrimos el fichero en modo lectura

            try (RandomAccessFile faa = new RandomAccessFile(f, "rws")) {
                //calculamos la posicion base del registro, multiplicamos la posicion que queremos buscar
                // por la longitud del registro (46 bytes)
                long posicionReg = posicion * this.longReg;

                //calculamos el desplazamiento que debemos hacer para llegar al valor del registro
                for (Pair<String, Integer> parCampo: campos) {
                    this.longReg += parCampo.getValue();

                }
            }
        }

        public static void main(String[] args) {

            // Define la estructura de los campos para los registros.
            List campos = new ArrayList();
            campos.add(new Pair("DNI", 9));
            campos.add(new Pair("NOMBRE", 32));
            campos.add(new Pair("CP", 5));

            try {
                // Instancia la clase para trabajar con el archivo "fic_acceso_aleat.dat".
                accesoaleatorio.FicheroAccesoAleatorio faa = new accesoaleatorio.FicheroAccesoAleatorio("fic_acceso_ aleat.dat", campos);

                // Crea e inserta el primer registro (SAMPER).
                Map reg = new HashMap();
                reg.put("DNI", "56789012B");
                reg.put("NOMBRE", "SAMPER");
                reg.put("CP", "29730");
                faa.insertar(reg);

                // Limpia el mapa y crea e inserta el segundo registro (ROJAS).
                // Notar que el campo "CP" no se incluye, se usará el valor por defecto (vacío).
                reg.clear();
                reg.put("DNI", "89012345E");
                reg.put("NOMBRE", "ROJAS");
                faa.insertar(reg);

                // Limpia el mapa y crea e inserta el tercer registro (DORCE).
                reg.clear();
                reg.put("DNI", "23456789D");
                reg.put("NOMBRE", "DORCE");
                reg.put("CP", "13700");
                faa.insertar(reg);

                // Limpia el mapa y crea e inserta un registro en la posición 1, sobreescribiendo el registro de ROJAS.
                reg.clear();
                reg.put("DNI", "78901234X");
                reg.put("NOMBRE", "NADALES");
                reg.put("CP", "44126");
                faa.insertar(reg, 1);

            } catch (IOException e) {
                // Maneja errores de entrada/salida.
                System.err.println("Error de E/S: " + e.getMessage());
            } catch (Exception e) {
                // Maneja cualquier otra excepción.
                e.printStackTrace();
            }
        }
    }
}
