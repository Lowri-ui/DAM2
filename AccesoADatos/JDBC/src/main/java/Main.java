import dao.Dao;
import dao.DatabaseConnector;
import pojos.Cliente;
import print.ImprimirResultados;

import java.sql.Connection;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Main {
    public static String CATALOGO = "hr_database";
    public static String WORLD = "world";
    public static String NOMBRE_TABLA = "CLIENTES";
    public static String T_FACTURAS = "FACTURAS";
    public static String T_LINEAS_FACTURA = "LINEAS_FACTURA";
    public static String INSERT_CLIENTES = "INSERT INTO CLIENTES(DNI,APELLIDOS,CP) VALUES "
            + "('78901234X','NADALES','44126'),"
            + "('89012345E','HOJAS', null),"
            + "('56789012B','SAMPER','29730'),"
            + "('09876543K','LAMIQUIZ', null);";

    public static void main(String[] args) {
        try {
            DatabaseConnector connector = new DatabaseConnector();
            Connection connection = connector.connection;

            if (connection == null) {
                throw new Exception("Error al obtener la conexión a la base de datos");
            }
            System.out.println("Conectado con éxito");
            System.out.println("Hemos obtenido la conexión a la base de datos");
            Dao dao = new Dao(connection);
            ImprimirResultados print = new ImprimirResultados();
            /**
             * Ejecutamos una sentencia DDL para crear una tabla
             */
            //dao.crearTablaClientesSiNoExiste();
             //Imprimimos los resultados
            //print.imprimirTablas(connection, CATALOGO);

            // Insertamos registros en la tabla clientes
           // dao.insertarDatosConStatement(connection, INSERT_CLIENTES);
           // Sacamos por consola los registros insertados
            //print.imprimirRegistros(connection, CATALOGO, NOMBRE_TABLA);

            /**-- ACTIVIDAD 4.1. UPDATE Y DELETE ('78901234X', 'NADALES', '44126'),
             * ('89012345E', 'ROJAS', null), ('56789012B', 'SAMPER', '29730').*/
           //ACTUALIZAMOS ESTOS 3 CLIENTES:
//            List<Cliente> actualizarLista = Arrays.asList(
//                    new Cliente("78901234X", "NADALES",44126),
//                    new Cliente("89012345E", "ROJAS",0), //null=0
//                    new Cliente("56789012B", "SAMPER",29730)
//
//            );
//            dao.actualizarClientes(connection, actualizarLista);
//            System.out.println("Clientes actualizados:");
           //print.imprimirRegistros(connection,CATALOGO,NOMBRE_TABLA);

            /** ACTIVIDAD 4.2. PRINT con int.*/
//            //ELIMINAMOS UN CLIENTE --> ('09876543K','LAMIQUIZ', null)
//            List<Cliente> eliminarClientesLista = Arrays.asList(
//                    new Cliente("09876543K","LAMIQUIZ",0)
//            );
//            dao.eliminarClientes(connection, eliminarClientesLista);
//            System.out.println("Clientes eliminados:");
//            print.imprimirRegistros(connection,CATALOGO,NOMBRE_TABLA);

//            // --- Datos de los 5 nuevos clientes a insertar ---
//            List<Cliente> nuevosClientes = Arrays.asList(
//                    new Cliente("12345678A", "Pérez Gómez", 28001),
//                    new Cliente("23456789B", "López Martín", 41002),
//                    new Cliente("34567890C", "Sánchez Ruiz", 46003),
//                    new Cliente("45678901D", "Fernández Díaz", 98004),
//                    new Cliente("56789012E", "Moreno Jiménez", 50005)
//            );
//
////            dao.insertarClientes(connection, nuevosClientes);
            //print.imprimirRegistros2(connection, CATALOGO, NOMBRE_TABLA);

            /** ACTIVIDAD 4.3.
             * Haz un metodo en Java que muestre los resultados de la siguiente consulta de
             * SQL “SELECT CONCAT(first_name, ' ', last_name) AS name FROM employees;”
             * pero en orden inverso, del último al primero.
             * La consulta de SQL debe ser la misma, sin ningún cambio.*/
           // List<Cliente> ordenInversoLista = new ArrayList<>();
           // dao.ordenInverso(connection, ordenInversoLista);

            /**
             * ACTIVIDAD 4.4.
             * ¿Cómo se podría averiguar el número de filas obtenidas por una consulta utilizando los métodos de ResultSet,
             * pero sin recorrer sus contenidos para contarlas? Escribe un programa que lo haga.
             * Puedes emplear cualquier consulta.
             */
            //Dao dao3 = new Dao(connection);
            //dao3.verCliente(connection);

            /**
             * ACTIVIDAD 4.5
             * Escribe un metodo en Java que reciba una conexión muestre los datos
             * de varios clientes, o todos, de la tabla CLIENTES.
             * El programa debe utilizar una sentencia preparada para la consulta
             * SELECT * FROM CLIENTES WHERE DNI=?
             * Debe realizarse una consulta para cada cliente, especificando su DNI, y
             * obtener los datos del ResultSet resultante, que solo tendrá una fila, al ser el acceso por clave primaria.
             * Haz comentarios al código.
             */
            Dao dao3 = new Dao(connection);
            List<String> listaDnis = Arrays.asList("78901234X", "89012345E", "56789012B");
            dao3.obtenerCliente(connection, listaDnis);
//            List<Cliente> nuevosClientes2 = Arrays.asList(
//                    new Cliente("15345678A", "Ana Gómez", 28001),
//                    new Cliente("26456789B", "Jose Martín", 41002),
//                    new Cliente("37567890C", "Ramon Ruiz", 46003),
//                    new Cliente("48678901D", "Lucia Díaz", 98004),
//                    new Cliente("59789012E", "Amalia Jiménez", 50005)
//            );
////            dao.insertarClientesBatchConTransaccion(connection, nuevosClientes2);
////            print.imprimirRegistros(connection, CATALOGO, NOMBRE_TABLA);
//
//            // Preparamos los datos para las nuevas facturas
//            List<String> dnis = Arrays.asList(
//                    "78901234X",
//                    "09876543K",
//                    "15345678A",
//                    "INVALIDO", // DNI que podría causar un error para probar el rollback
//                    "59789012E"
//            );
//
//            List<LineaFactura> lineas = Arrays.asList(
//                    new LineaFactura("TORNILLOS", 10),
//                    new LineaFactura("TUERCAS", 50),
//                    new LineaFactura("ARANDELAS", 100),
//                    new LineaFactura("TACOS", 150)
//            );
//
//            // Llamamos a nuestro metodo para procesar el lote de facturas
////            Map<String, Integer> resultados = dao.crearFacturas(connection, dnis, lineas);
////
////            System.out.println("\n--- RESUMEN DEL PROCESO ---");
////            System.out.println("Facturas creadas exitosamente: " + resultados.size() + " de " + dnis.size());
////            resultados.forEach((dni, numFactura) ->
////                    System.out.println("  - DNI: " + dni + " -> Factura Nº: " + numFactura)
////            );
////            print.imprimirRegistros(connection, CATALOGO, T_FACTURAS);
////            print.imprimirRegistros(connection, CATALOGO, T_LINEAS_FACTURA);
//
//            // La lógica de negocio ahora es una simple llamada a un método.
////            String dniBusqueda = "78901234X";
////            ResultadoListado resultado = dao.llamarListadoClientes(connection, dniBusqueda);
////
////            // La responsabilidad de mostrar los datos se queda en el main.
////            System.out.println("=> Valor del parámetro INOUT devuelto: " + resultado.getContadorInOut());
////            System.out.println("Clientes encontrados:");
////
////            int nCli = 0;
////            for (Cliente cliente : resultado.getClientes()) {
////                System.out.println(" [" + (++nCli) + "] " + cliente.toString());
////            }
//
////            dao.obtenerYMostrarApellidosAlternativo("78901234X", connection);
//
////// == INICIO DE LA TRANSACCIÓN ==
////            // La responsabilidad de la transacción se queda en el método principal.
////            connection.setAutoCommit(false);
////
////            // Preparamos los datos para la operación
////            String nuevoCp = "02568";
////            ClienteNuevo nuevoCliente = new ClienteNuevo("24862486S", "ZURITA", "33983");
////
////            System.out.println("Iniciando operación de modificación de clientes...");
////            // Llamamos a nuestro método de lógica de negocio
////            dao.modificarClientesConResultSet(connection, nuevoCp, nuevoCliente);
////
////            // Si el método termina sin lanzar una excepción, confirmamos la transacción.
////            connection.commit();
////            System.out.println("\nTransacción confirmada (COMMIT) con éxito. ✅");
////
////            print.imprimirRegistros(connection, CATALOGO, NOMBRE_TABLA);
//
//            // Los datos ahora son una lista de objetos, mucho más legible y segura.
//            List<Cliente> clientesNuevos = Arrays.asList(
//                    new Cliente("13579135G", "Maria Torres", 32564),
//                    new Cliente("24680246G", "Pedro Marin", 25865),
//                    new Cliente("96307418R", "Blanca Fernandez", 19273)
//            );
//            // == INICIO DE LA TRANSACCIÓN ==
//            // La gestión de la transacción (commit/rollback) se queda en el método 'main'.
//            connection.setAutoCommit(false);
//
//            try {
//                // Llamamos a nuestro metodo reutilizable.
//                int[] resultados = dao.insertarClientesEnLote(connection, clientesNuevos);
//
//                // == FIN DE LA TRANSACCIÓN (ÉXITO) ==
//                connection.commit();
//
//                System.out.println("Transacción confirmada (COMMIT) con éxito. ✅");
//                System.out.println("Resultados del lote: " + Arrays.toString(resultados));
//                // Un resultado de 1 (o Statement.SUCCESS_NO_INFO) por cada inserción indica éxito.
//                Arrays.stream(resultados).sequential().forEach(r -> System.out.println("Resultado: " + r));
//
//            } catch (SQLException e) {
//                System.err.println("Error de SQL, se desharán los cambios (ROLLBACK).");
//                e.printStackTrace(System.err);
//                // Si algo falla, hacemos rollback
//                connection.rollback();
//                System.err.println("Rollback realizado.");
//            }
//            connection.setAutoCommit(true);
//
//            print.imprimirRegistros(connection, CATALOGO, NOMBRE_TABLA);

            // Cerramos la conexion
            connection.close();
        } catch (Exception e) {
            System.err.println("Erro al conectar a la base de dados");
            System.out.println(e.getMessage());
            e.printStackTrace();
        }
    }
}


