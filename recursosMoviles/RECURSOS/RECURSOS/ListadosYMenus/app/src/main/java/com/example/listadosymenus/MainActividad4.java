package com.example.listadosymenus;

import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Spinner;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

public class MainActividad4 extends AppCompatActivity {
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.actividad4_layout);

        Spinner spinner = findViewById(R.id.spinnerPaises);
        TextView textViewSeleccion = findViewById(R.id.textViewPaisSeleccionado);

        String[] paises = {"España", "Francia", "Italia", "Portugal", "Alemania", "Bélgica",
                "Países Bajos", "Suiza", "Austria", "Suecia", "Laura Pinel García"};

        ArrayAdapter<String> adapter = new ArrayAdapter<>( this,
                R.layout.list_item_paises,
                R.id.textViewItemPais,
                paises);
        spinner.setAdapter(adapter);
        spinner.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> parent, View view, int position, long id) {
                String seleccionado = paises[position];
                textViewSeleccion.setText("Has seleccionado: " + seleccionado);
            }
            @Override
            public void onNothingSelected(AdapterView<?> parent) {
                textViewSeleccion.setText("No se ha seleccionado ningún país");
            }
        });
    }
}
