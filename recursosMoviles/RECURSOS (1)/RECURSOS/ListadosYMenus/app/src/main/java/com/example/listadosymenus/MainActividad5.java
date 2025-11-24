package com.example.listadosymenus;

import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.widget.ListView;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;
import com.example.listadosymenus.adapters.PlanetaAdapter;
import com.example.listadosymenus.pojos.Planeta;
import java.util.ArrayList;
import java.util.List;

public class MainActividad5 extends AppCompatActivity {
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.actividad5_layout);

        ListView listView = findViewById(R.id.listViewComplejo);
        ArrayList listaPlanetas = new ArrayList<>();
        listaPlanetas.add(new Planeta("Mercurio",
                "El más cercano al Sol",
                R.drawable.mercurio,
                false,
                "https://es.wikipedia.org/wiki/Mercurio_(planeta)"));

        listaPlanetas.add(new Planeta("Venus",
                "El planeta más caliente del sistema solar",
                R.drawable.venus,
                false,
                "https://es.wikipedia.org/wiki/Venus_(planeta)"));

        listaPlanetas.add(new Planeta("Tierra",
                "Nuestro hogar, el único con vida conocida",
                R.drawable.tierra,
                false,
                "https://es.wikipedia.org/wiki/Tierra"));

        listaPlanetas.add(new Planeta("Marte",
                "El planeta rojo, posible destino de futuras misiones",
                R.drawable.marte,
                false,
                "https://es.wikipedia.org/wiki/Marte_(planeta)"));

        listaPlanetas.add(new Planeta("Júpiter",
                "El planeta más grande del sistema solar",
                R.drawable.jupiter,
                false,
                "https://es.wikipedia.org/wiki/J%C3%BApiter_(planeta)"));

        listaPlanetas.add(new Planeta("Saturno",
                "Famoso por sus impresionantes anillos",
                R.drawable.saturno,
                false,
                "https://es.wikipedia.org/wiki/Saturno_(planeta)"));

        listaPlanetas.add(new Planeta("Urano",
                "Un gigante helado con rotación inclinada",
                R.drawable.urano,
                false,
                "https://es.wikipedia.org/wiki/Urano_(planeta)"));

        listaPlanetas.add(new Planeta("Neptuno",
                "El planeta más lejano del sistema solar",
                R.drawable.neptuno,
                false,
                "https://es.wikipedia.org/wiki/Neptuno_(planeta)"));

        PlanetaAdapter adaptador = new PlanetaAdapter(this,listaPlanetas);
        listView.setAdapter(adaptador);

        listView.setOnItemClickListener((parent,view,position,id)-> {
            //Obtenemos el planeta que ha sido pulsado
            Planeta planetaSeleccionado = (Planeta) listaPlanetas.get(position);
            Intent intentWeb = new Intent(Intent.ACTION_VIEW, Uri.parse(planetaSeleccionado.getUrlInfo()));
           if (intentWeb.resolveActivity(getPackageManager())!=null){
               startActivity(intentWeb);
           }else {
               Toast.makeText(this, "No se encontró un navegador web", Toast.LENGTH_SHORT).show();
           }
        });
    }
}
