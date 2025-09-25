package listadodirectorio;

import java.io.File;

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
                    String textoDescr = f.isDirectory() ? "/" : f.isFile() ? "_" : "?";
                    String permisos = (f.canExecute() ? "x" : "-") + (f.canRead() ? "r" : "-") + (f.canWrite() ? "w" : "-");
                    Long tamaño = (f.length());
                    System.out.println("(" + textoDescr + ")" + "(" + permisos + ") " + f.getName() + " Tamaño:" + "(" + tamaño + " bytes)");
                }
            }
        }
    }
}
