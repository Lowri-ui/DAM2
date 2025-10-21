package actividades.actividad3_3;

import com.fasterxml.jackson.databind.ObjectMapper;
import com.fasterxml.jackson.databind.SerializationFeature;

import java.io.File;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        // Crear productos
        producto p1 = new producto("P001", "Laptop", 1200.50, 5);
        producto p2 = new producto("P002", "Teclado", 25.75, 20);
        producto p3 = new producto("P003", "Mouse", 15.99, 30);

        // Crear lista de productos
        List<producto> listaProductos = new ArrayList<>();
        listaProductos.add(p1);
        listaProductos.add(p2);
        listaProductos.add(p3);

        // Crear inventario
        inventario inventario = new inventario("Mi Tienda", listaProductos);

        // Crear ObjectMapper
        ObjectMapper mapper = new ObjectMapper();
        mapper.enable(SerializationFeature.INDENT_OUTPUT); // Pretty print

        // Serializar a JSON
        try {
            mapper.writeValue(new File("inventario.json"), inventario);
            System.out.println("Inventario guardado en inventario.json");
        } catch (IOException e) {
            e.printStackTrace();
        }

        // Deserializar desde JSON
        try {
            inventario inventarioLeido = mapper.readValue(new File("inventario.json"), inventario.class);
            System.out.println("\nInventario deserializado:");
            System.out.println("Tienda: " + inventarioLeido.getNombreTienda());
            for (producto prod : inventarioLeido.getProductos()) {
                System.out.println(prod);
            }
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
