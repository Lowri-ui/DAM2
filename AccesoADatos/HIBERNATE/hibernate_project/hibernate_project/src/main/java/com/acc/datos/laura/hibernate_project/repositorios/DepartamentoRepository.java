package com.acc.datos.laura.hibernate_project.repositorios;

import com.acc.datos.laura.hibernate_project.pojos.Departamento;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;
@Repository
public interface DepartamentoRepository extends JpaRepository<Departamento, Integer> {
// JpaRepository<Departamento, Integer> -> Manejará objetos 'Departamento'
// cuya clave primaria ('id_depto') es de tipo 'Integer'.
}
