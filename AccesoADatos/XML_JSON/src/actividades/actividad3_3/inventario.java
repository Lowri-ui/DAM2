package actividades.actividad3_3;

import java.util.List;

public class inventario {
    private String nombreTienda;
    private List<producto> productos;

    public inventario() {}

    public inventario(String nombreTienda, List<producto> productos) {
        this.nombreTienda = nombreTienda;
        this.productos = productos;
    }

    public String getNombreTienda() { return nombreTienda; }
    public void setNombreTienda(String nombreTienda) { this.nombreTienda = nombreTienda; }

    public List<producto> getProductos() { return productos; }
    public void setProductos(List<producto> productos) { this.productos = productos; }

    @Override
    public String toString() {
        return "Inventario{" +
                "nombreTienda='" + nombreTienda + '\'' +
                ", productos=" + productos +
                '}';
    }
}
