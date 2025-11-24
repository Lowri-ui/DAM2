package com.example.listadosymenus;

import android.os.Bundle;
import android.view.View;
import android.widget.ListView;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

import com.example.listadosymenus.adapters.VersionAdapter;
import com.example.listadosymenus.pojos.Encapsulador;

import java.util.ArrayList;
import java.util.List;

public class MainActividad6 extends AppCompatActivity {
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.actividad6_layout);

        //1.
        ListView listViewVersiones = findViewById(R.id.listViewVersiones);
        TextView tvTituloDetalle = findViewById(R.id.textViewTituloDetalle);
        TextView tvDescripcionDetalle = findViewById(R.id.textViewDescripcionDetalle);
        TextView tvInfoInferior = findViewById(R.id.textViewInfoInferior);

        ArrayList<Encapsulador> datos = new ArrayList<>();
        datos.add(new Encapsulador(
                R.drawable.donuts,
                "DONUTS",
                "El 15 de septiembre de 2009 fue lanzado el SDK de Android 1.6 Donut, basado en el núcleo Linux 2.6.29. En la actualización se incluyeron numerosas características nuevas.",
                true
        ));

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


        cargarDatos();
        VersionAdapter adaptador = new VersionAdapter(this, datos);
        listViewVersiones.setAdapter(adaptador);

        listViewVersiones.setOnItemClickListener((parent, view, position, id) -> {
            //actualizarSeleccion(position);
            adaptador.notifyDataSetChanged();
            Encapsulador seleccion = datos.get(position);
            tvTituloDetalle.setText(seleccion.getTitulo());
            tvDescripcionDetalle.setText(seleccion.getDescripcion());
            tvInfoInferior.setText(seleccion.getDescripcion());
        });
    }

    private void cargarDatos() {

    }
}
