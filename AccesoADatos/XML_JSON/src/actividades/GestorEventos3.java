package actividades;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

import org.xml.sax.SAXParseException;
import org.xml.sax.helpers.DefaultHandler;

/**
 * Clase que gestiona los eventos de error, warning y error fatal que pueden
 * ocurrir durante el proceso de parsing y validación del XML.
 * Extiende DefaultHandler para sobreescribir solo los métodos necesarios.
 */
class GestorEventos3 extends DefaultHandler {

    /**
     * Se invoca cuando el parser encuentra un error recuperable.
     * Por ejemplo, una violación de las reglas de validación del DTD o Esquema.
     */
    @Override
    public void error(SAXParseException e) throws SAXParseException {
        System.err.println("Error recuperable: " + e.toString());
        // Relanza la excepción para que pueda ser capturada en el bloque try-catch del main.
        throw (e);
    }

    /**
     * Se invoca cuando el parser encuentra un error no recuperable (fatal).
     * Generalmente, se trata de un error de "well-formedness" (XML mal formado).
     * El parsing se detiene.
     */
    @Override
    public void fatalError(SAXParseException e) throws SAXParseException {
        System.err.println("Error no recuperable: " + e.toString());
        throw (e);
    }

    /**
     * Se invoca para notificar avisos del parser.
     * Suelen ser problemas que no violan las reglas del XML pero que podrían ser incorrectos.
     */
    @Override
    public void warning(SAXParseException e) throws SAXParseException {
        System.err.println("Aviso: " + e.toString());
        throw (e);
    }

}
