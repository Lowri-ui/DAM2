package com.acc.datos.laura.hibernate_project.util;

import com.acc.datos.laura.hibernate_project.servicios.SetupInicialService;
import com.acc.datos.laura.hibernate_project.servicios.SetupService55;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.CommandLineRunner;
import org.springframework.dao.DataIntegrityViolationException;
import org.springframework.stereotype.Component;

@Component
public class AppRunner55 implements CommandLineRunner {
    @Autowired
    private SetupService55 setupService55;
    @Override
    public void run(String... args) throws Exception {
        System.out.println("====================================================================");
                System.out.println("APLICACIÓN ARRANCADA. EJECUTANDO LÓGICA INICIAL...");
        System.out.println("====================================================================");
        try {
// Intentamos ejecutar el metodo transaccional.
            setupService55.actividad55();
            setupService55.verificarDatosCreados();
            
        } catch (DataIntegrityViolationException e) {
// Si algo falla dentro del metodo (ej. un DNI duplicado),
// Spring primero hará ROLLBACK de la transacción.
// Después, la excepción llegará hasta aquí y podremos manejarla.
            System.err.println("\n!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! !!!!!!!!!");
            System.err.println("ERROR DE INTEGRIDAD DE DATOS: No se pudieron guardar los datos.");
            System.err.println("Causa: " + e.getMostSpecificCause().getMessage());
            System.err.println("Acción: La transacción ha sido deshecha (ROLLBACK) por Spring.");
            System.err.println("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! !!!!!!!");
        }
        System.out.println("\n====================================================================");
        System.out.println("LÓGICA INICIAL FINALIZADA. La aplicación está lista.");
        System.out.println("====================================================================");
    }
}
