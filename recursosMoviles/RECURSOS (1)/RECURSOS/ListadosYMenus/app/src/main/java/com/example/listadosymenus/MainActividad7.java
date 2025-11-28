package com.example.listadosymenus;

import android.os.Bundle;
import android.widget.GridView;
import android.widget.TextView;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import com.example.listadosymenus.adapters.VersionAdapter;
import com.example.listadosymenus.pojos.Encapsulador;

import java.util.ArrayList;

public class MainActividad7 extends AppCompatActivity {
    // Metodo que crea y devuelve la lista de versiones de Android
    // Cada Encapsulador tiene imagen, título, descripción y estado de selección
    private ArrayList<Encapsulador> cargarDatos() {
        ArrayList<Encapsulador> datos = new ArrayList<>();

        // Primer elemento seleccionado por defecto (true)
        datos.add(new Encapsulador(
                R.drawable.donuts,
                "DONUTS",
                "El 15 de septiembre de 2009 fue lanzado el SDK de Android 1.6 Donut, basado en el núcleo Linux 2.6.29. En la actualización se incluyeron numerosas características nuevas.",
                true
        ));

        // Los demás elementos no seleccionados al inicio (false)
        datos.add(new Encapsulador(
                R.drawable.froyo,
                "FROYO",
                "El 20 de mayo de 2010 fue lanzado el SDK de Android 2.2 Froyo (Yogur helado), basado en el núcleo Linux 2.6.32.",
                false
        ));

        datos.add(new Encapsulador(
                R.drawable.gingerbread,
                "GINGERBREAD",
                "El 6 de diciembre de 2010 fue lanzado el SDK de Android 2.3 Gingerbread (Pan de Jengibre), basado en el núcleo Linux 2.6.35.",
                false
        ));

        datos.add(new Encapsulador(
                R.drawable.honeycomb,
                "HONEYCOMB",
                "El 22 de febrero de 2011 salió el SDK de Android 3.0 Honeycomb (Panal de Miel). Fue la primera actualización exclusiva para TV y tabletas.",
                false
        ));

        datos.add(new Encapsulador(
                R.drawable.icecream,
                "ICE CREAM",
                "El SDK para Android 4.0 Ice Cream Sandwich (Sándwich de Helado), basado en el núcleo Linux 3.0.1, fue lanzado públicamente el 12 de octubre de 2011.",
                false
        ));

        datos.add(new Encapsulador(
                R.drawable.jellybean,
                "JELLY BEAN",
                "Google anunció Android 4.1 Jelly Bean (Gomita Confitada) el 30 de junio de 2012, basado en el núcleo Linux 3.0.31.",
                false
        ));

        datos.add(new Encapsulador(
                R.drawable.kitkat,
                "KITKAT",
                "Su nombre se debe a la chocolatina KitKat de Nestlé. Incluye impresión mediante WiFi y WebViews basadas en el motor de Chromium.",
                false
        ));

        datos.add(new Encapsulador(
                R.drawable.lollipop,
                "LOLLIPOP",
                "Incluye Material Design, un diseño colorido y adaptable que ofrece experiencias coherentes e intuitivas en todos los dispositivos.",
                false
        ));

        return datos; // devolvemos la lista completa
    }
    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.actividad7_layout); // cargamos el layout principal

        // 1. Referencias a los elementos del layout
        GridView gv = findViewById(R.id.gridViewVersiones);
        TextView tvTituloDetalle = findViewById(R.id.textViewTituloDetalle);
        TextView tvDescripcionDetalle = findViewById(R.id.textViewDescripcionDetalle);

        // 2. Cargamos los datos de versiones de Android
        ArrayList<Encapsulador> datos = cargarDatos();

        // 3. Creamos el adaptador personalizado y lo asignamos al ListView
        VersionAdapter adaptador = new VersionAdapter(this, datos);
        gv.setAdapter(adaptador);

        // 4. Listener para detectar cuando se selecciona un elemento de la lista
        gv.setOnItemClickListener((parent, view, position, id) -> {
            // Aquí podríamos actualizar el estado de selección, pero de momento solo refrescamos
            adaptador.notifyDataSetChanged(); // refresca la lista para que se marque/desmarque

            // Obtenemos el elemento seleccionado
            Encapsulador seleccion = datos.get(position);

            // Actualizamos los TextViews con los detalles de la versión seleccionada
            tvTituloDetalle.setText(seleccion.getTitulo());
            tvDescripcionDetalle.setText(seleccion.getDescripcion());
        });

    }
}
