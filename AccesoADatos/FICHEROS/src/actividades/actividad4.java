  package actividades;
public class actividad4 {
    //Crea un programa que, a partir de un fichero de texto codificado en UTF-8,
    // genere un fichero de texto codificado en ISO-8859-1 y otro en UTF-16
    static void main(String[] args) {
        //LECTURA DEL FICHERO
        try {
            FileReader fr = new  FileReader("" +
                    "input.txt");
            BufferedReader br = new BufferedReader(fr);

            String linea;
            while ((linea = br.readLine())!=null){
                System.out.println(linea);
            }

            br.close();

        } catch (IOException e) {
            System.out.println("ERROR al leer el archivo."+e.getMessage());
        }
    }
}
