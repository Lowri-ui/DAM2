package com.acc.datos.laura.hibernate_project.servicios;

import com.acc.datos.laura.hibernate_project.pojos.Departamento;
import com.acc.datos.laura.hibernate_project.pojos.Empleado;
import com.acc.datos.laura.hibernate_project.pojos.Sede;
import com.acc.datos.laura.hibernate_project.repositorios.DepartamentoRepository;
import com.acc.datos.laura.hibernate_project.repositorios.EmpleadoRepository;
import com.acc.datos.laura.hibernate_project.repositorios.SedeRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional; // El import correcto
@Service
public class SetupInicialService {
    @Autowired
    private SedeRepository sedeRepository;
    @Autowired
    private DepartamentoRepository departamentoRepository;
    @Autowired
    private EmpleadoRepository empleadoRepository;
    @Transactional

//    public void crearDatosDeEjemplo() {
//        System.out.println("--- CREANDO DATOS INICIALES DE FORMA EXPLÍCITA ---");
//
//// 1. Creamos y guardamos la Sede para obtener su ID.
//        Sede sedeCentral = new Sede();
//        sedeCentral.setNomSede("Madrid Central");
//
//// Usamos saveAndFlush para forzar el INSERT y obtener el ID generado.
//        Sede sedeGuardada = sedeRepository.saveAndFlush(sedeCentral);
//        System.out.println("Sede creada con ID: " + sedeGuardada.getIdSede());
//
//// 2. Creamos el Departamento, lo asociamos con la Sede (que ya tiene ID) y lo guardamos.
//        Departamento deptoIT = new Departamento();
//        deptoIT.setNomDepto("Tecnologías de la Información");
//        deptoIT.setSede(sedeGuardada); // La relación se establece en el lado "dueño".
//        Departamento deptoGuardado = departamentoRepository.saveAndFlush(deptoIT);
//        System.out.println("Departamento creado con ID: " + deptoGuardado.getIdDepto());
//
//// 3. Creamos el Empleado, lo asociamos con el Departamento (que ya tiene ID) y lo guardamos.
//        Empleado nuevoEmpleado = new Empleado();
//        nuevoEmpleado.setDni("12345678A");
//        nuevoEmpleado.setNomEmp("Ana López");
//        nuevoEmpleado.setDepartamento(deptoGuardado); // La relación se establece en el lado "dueño".
//        empleadoRepository.save(nuevoEmpleado); // Para el último, un .save() es suficiente.
//        System.out.println("Empleado creado con DNI: " + nuevoEmpleado.getDni());
//        System.out.println("--- DATOS INICIALES CREADOS CON ÉXITO ---");
//
//    }

    /**
     * ACTIVIDAD 5.5.
     * Haz un programa que cree una nueva sede, dos departamentos para esta nueva sede y dos empleados para cada uno de estos departamentos.
     * Verifica que los datos se crean correctamente comprobando el contenido de las tablas creando un metodo en el service llamado “verificarDatosCreados”
     * y que sea llamado desde el runner. Comprueba también los datos conectándote a un cliente MySQL.
     */
    public void actividad55(){

        Sede sede1 = new Sede();
        sede1.setNomSede("Barcelona Tech Hub");
        Sede sede1Guardada = sedeRepository.saveAndFlush(sede1);
        System.out.println("Sede creada con ID: " + sede1.getIdSede());

        Departamento depto1 = new Departamento();
        depto1.setNomDepto("Desarrollo de Software");
        depto1.setSede(sede1Guardada);
        Departamento depto1Guardado = departamentoRepository.saveAndFlush(depto1);
        System.out.println("Departamento creado con ID: " + depto1Guardado.getIdDepto());

        Departamento depto2 = new Departamento();
        depto2.setNomDepto("Marketing Digital");
        depto2.setSede(sede1Guardada);
        Departamento depto2Guardado = departamentoRepository.saveAndFlush(depto2);
        System.out.println("Departamento creado con ID: " + depto2Guardado.getIdDepto());


        Empleado nuevoEmpleado1 = new Empleado();
        nuevoEmpleado1.setDni("49123456C");
        nuevoEmpleado1.setNomEmp("Javier Ruiz");
        nuevoEmpleado1.setDepartamento(depto1Guardado); // La relación se establece en el lado "dueño".
        empleadoRepository.save(nuevoEmpleado1); // Para el último, un .save() es suficiente.
        System.out.println("Empleado creado con DNI: " + nuevoEmpleado1.getDni());

        Empleado nuevoEmpleado2 = new Empleado();
        nuevoEmpleado2.setDni("50678901D");
        nuevoEmpleado2.setNomEmp("Elena Torres");
        nuevoEmpleado2.setDepartamento(depto1Guardado); // La relación se establece en el lado "dueño".
        empleadoRepository.save(nuevoEmpleado2); // Para el último, un .save() es suficiente.
        System.out.println("Empleado creado con DNI: " + nuevoEmpleado2.getDni());

        Empleado nuevoEmpleado3 = new Empleado();
        nuevoEmpleado3.setDni("51234567E");
        nuevoEmpleado3.setNomEmp("Sergio Vidal");
        nuevoEmpleado3.setDepartamento(depto2Guardado); // La relación se establece en el lado "dueño".
        empleadoRepository.save(nuevoEmpleado3); // Para el último, un .save() es suficiente.
        System.out.println("Empleado creado con DNI: " + nuevoEmpleado3.getDni());

        Empleado nuevoEmpleado4 = new Empleado();
        nuevoEmpleado4.setDni("52789012F");
        nuevoEmpleado4.setNomEmp("Laura Pinel");
        nuevoEmpleado4.setDepartamento(depto2Guardado); // La relación se establece en el lado "dueño".
        empleadoRepository.save(nuevoEmpleado4); // Para el último, un .save() es suficiente.
        System.out.println("Empleado creado con DNI: " + nuevoEmpleado4.getDni());

    }
    public void verificarDatosCreados() {
        System.out.println("\n==== VERIFICACIÓN DE DATOS ====\n");

        System.out.println("-- SEDES --");
        sedeRepository.findAll().forEach(s -> System.out.println(s.getIdSede() + " - " + s.getNomSede()));

        System.out.println("\n-- DEPARTAMENTOS --");
        departamentoRepository.findAll().forEach(d -> System.out.println(d.getIdDepto() + " - " + d.getNomDepto()));

        System.out.println("\n-- EMPLEADOS --");
        empleadoRepository.findAll().forEach(e -> System.out.println(e.getDni() + " - " + e.getNomEmp()));
    }


}