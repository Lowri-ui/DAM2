package actividades;

import org.w3c.dom.*;
import javax.xml.parsers.*;
import javax.xml.transform.*;
import javax.xml.transform.dom.DOMSource;
import javax.xml.transform.stream.StreamResult;
import org.xml.sax.SAXException;
import java.io.File;
import java.io.IOException;
import java.util.Scanner;

/*
Crea un programa en Java que, a partir de los contenidos del fichero XML como
el del ejemplo, con los datos de varios clientes, muestre un nuevo documento de
XML que sea el resultado de añadir los datos de un nuevo cliente al principio,
antes de todos los clientes que puedan existir. Debe utilizarse un parser DOM y
las interfaces de DOM para añadir los datos del nuevo cliente, incluyendo DNI,
apellidos y CP. La salida debe ser a salida estándar (System.out) y en formato
XML, y debe generarse utilizando la clase Transformer. El fichero se debe
especificar mediante un argumento de línea de comandos. Si el fichero no es un
fichero XML correcto, o si lo es pero no tiene un único elemento con nombres de
clientes en el nivel más alto, se debe terminar la ejecución inmediatamente, y
mostrar mensajes de error apropiados.
 */

public class actividad3_2 {

    public static void main(String[] args) {
        // Comprobamos que se haya pasado el nombre del fichero XML como argumento
        if (args.length < 1) {
            System.err.println("Uso: java actividad3_2 <clientes.xml>");
            return;
        }

        String nombreFichero = args[0];

        try {
            // Creamos una fábrica para construir el parser DOM
            DocumentBuilderFactory dbf = DocumentBuilderFactory.newInstance();
            dbf.setIgnoringComments(true); // Ignora los comentarios del XML
            dbf.setIgnoringElementContentWhitespace(true); // Ignora los espacios en blanco innecesarios

            // Creamos el parser
            DocumentBuilder db = dbf.newDocumentBuilder();
            // Parseamos el XML y lo cargamos en memoria como un árbol DOM
            Document doc = db.parse(new File(nombreFichero));
            doc.getDocumentElement().normalize(); // Limpia espacios o nodos vacíos

            // Comprobamos que el XML tenga una raíz <clientes>
            Element raiz = doc.getDocumentElement();
            if (!"clientes".equals(raiz.getNodeName())) {
                System.err.println("Error: el documento debe tener una raíz <clientes>.");
                return;
            }

            // --- Pedimos los datos del nuevo cliente ---
            Scanner sc = new Scanner(System.in);
            System.out.print("Introduce el DNI del nuevo cliente: ");
            String dni = sc.nextLine().trim();

            System.out.print("Introduce los apellidos: ");
            String apellidos = sc.nextLine().trim();

            System.out.print("Introduce el código postal: ");
            String cp = sc.nextLine().trim();
            sc.close();

            // Creamos el nuevo cliente con los datos introducidos
            Element nuevoCliente = crearCliente(doc, dni, apellidos, cp);

            // Insertamos el nuevo cliente al principio de la lista
            Node primerCliente = raiz.getFirstChild();
            raiz.insertBefore(nuevoCliente, primerCliente);

            // --- Preparamos el objeto Transformer para mostrar el XML formateado ---
            TransformerFactory tf = TransformerFactory.newInstance();
            Transformer transformer = tf.newTransformer();

            // Ajustamos la salida para que quede bonita y legible
            transformer.setOutputProperty(OutputKeys.INDENT, "yes");
            transformer.setOutputProperty("{http://xml.apache.org/xslt}indent-amount", "2");
            transformer.setOutputProperty(OutputKeys.OMIT_XML_DECLARATION, "no");
            transformer.setOutputProperty(OutputKeys.METHOD, "xml");
            transformer.setOutputProperty(OutputKeys.ENCODING, "UTF-8");

            // Mostramos el nuevo XML por pantalla
            transformer.transform(new DOMSource(doc), new StreamResult(System.out));

        } catch (SAXException e) {
            System.err.println("Error: el fichero no es un XML válido o está mal formado.");
        } catch (IOException e) {
            System.err.println("Error: no se puede leer el fichero " + nombreFichero);
        } catch (ParserConfigurationException e) {
            System.err.println("Error al configurar el parser: " + e.getMessage());
        } catch (TransformerException e) {
            System.err.println("Error al transformar el XML: " + e.getMessage());
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    /**
     * Crea un nuevo elemento <cliente> con sus etiquetas
     * <cliente DNI="...">
     *     <apellidos>...</apellidos>
     *     <CP>...</CP>
     * </cliente>
     */
    private static Element crearCliente(Document doc, String dni, String apellidos, String cp) {
        // Creamos el nodo <cliente> con el atributo DNI
        Element cliente = doc.createElement("cliente");
        cliente.setAttribute("DNI", dni);

        // Creamos los subelementos <apellidos> y <CP>
        Element elemApellidos = doc.createElement("apellidos");
        elemApellidos.setTextContent(apellidos);

        Element elemCP = doc.createElement("CP");
        elemCP.setTextContent(cp);

        // Añadimos los subelementos dentro del cliente
        cliente.appendChild(elemApellidos);
        cliente.appendChild(elemCP);

        return cliente;
    }
}

