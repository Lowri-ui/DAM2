import dao.DatabaseConnector;

import java.sql.Connection;

public static void main(String[] args) {
    try {
        DatabaseConnector connector = new DatabaseConnector();
        Connection connection = connector.connection;

        if (connection == null) {
            throw new Exception("Error al obtener la conexión a la base de datos");
        }
        System.out.println("Conectado com sucesso");
        connection.close();
    } catch (Exception e) {
        System.err.println("Erro al conectar a la base de dados");
        System.out.println(e.getMessage());
        e.printStackTrace();
    }
}

