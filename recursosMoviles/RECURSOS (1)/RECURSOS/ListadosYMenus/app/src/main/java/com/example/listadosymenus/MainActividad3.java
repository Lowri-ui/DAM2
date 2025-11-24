package com.example.listadosymenus;

import android.os.Bundle;
import android.widget.ArrayAdapter;
import android.widget.GridView;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

public class MainActividad3 extends AppCompatActivity {
//    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.actividad3_layout);

        GridView gridView = findViewById(R.id.gridViewPaises);
        TextView textViewSeleccion = findViewById(R.id.textViewPaisSeleccionado);

        String[] paises = {"España", "Francia", "Italia", "Portugal", "Alemania", "Bélgica",
                "Países Bajos", "Suiza", "Austria", "Suecia", "Laura Pinel García"};

        ArrayAdapter<String> adapter = new ArrayAdapter<>( this,
                R.layout.list_item_paises,
                R.id.textViewItemPais,
                paises);
        gridView.setAdapter(adapter);
        gridView.setOnItemClickListener((parent, view, position, id) -> {
            String seleccionado = paises[position];
            textViewSeleccion.setText("Has seleccionado: " + seleccionado);
        });
    }
}
