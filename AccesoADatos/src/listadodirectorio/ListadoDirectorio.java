package listadodirectorio;

import java.io.File;
import java.text.SimpleDateFormat;

public class ListadoDirectorio {
    public static void main(String[] args) {
        //inicializar la variable "ruta" con un punto "."
        // que representa el directorio actual "C:\Users\DAM2_Diurno\IdeaProjects\FICHEROS.
        String ruta= ".";
        if (args.length >= 1) ruta = args[0];
        //Creación del objeto File. Crea una instancia de la clase File
        File fich = new File(ruta);

        if (!fich.exists()) { //Verificación de la existencia
            // del fichero o del directorio
            System.out.println("No existe el fichero o directorio" + ruta);
        }else {
            if (fich.isFile()){
                System.out.println("Es un fichero" + ruta);
            }else{
                System.out.println(ruta + "es un directorio. Contenidos: ");
                //Creamos un array con los objetos File
                File[] ficheros = fich.listFiles(); //Ficheros o directorios
                // Recorremos el array y añadimos un prefijo para mostrar
                // si el objeto es un fichero o diretorio
                for (File f: ficheros){
                    // Mostramos si es fichero o directorio
                    String textoDescr = f.isDirectory() ? "/" : f.isFile() ? "_" : "?";
                    // Enseñamos los permisos que contiene, en formato Linux (ejecución "x", lectura "r",
                    // escritura "w")
                    String permisos = (f.canExecute() ? "x" : "-") + (f.canRead() ? "r" : "-") + (f.canWrite() ? "w" : "-");
                    // Mostramos el tamaño que ocupa en bytes
                    Long tamaño = (f.length());
                    // Señalamos la fecha de última modificación del archivo
                    String fechaMod = new SimpleDateFormat("dd/MM/yyyy").format(f.lastModified());
                    // Imprimimos por pantalla la información de cada fichero o directorio correspondiente
                    System.out.println("Tipo: " + "(" + textoDescr + ")" +
                            " // Permisos: " + "(" + permisos + ") " +
                            " // Nombre: " + f.getName() +
                            " // Tamaño: " + "(" + tamaño + " bytes)" +
                            " // Última modificación: " + "(" + fechaMod + ")");
                }
            }
        }
    }
}
