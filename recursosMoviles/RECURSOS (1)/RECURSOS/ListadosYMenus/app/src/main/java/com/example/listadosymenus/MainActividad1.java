package com.example.listadosymenus;

import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.TextView;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

public class MainActividad1 extends AppCompatActivity {
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.actividad1_layout);

        ListView listView = findViewById(R.id.listViewPlanetas);

        String[] planetas = {"Tierra","Marte","Urano","Neptuno","Júpiter","Venus","Saturno","Mercurio","Planeta Laura"};

        ArrayAdapter<String> adapter = new ArrayAdapter<>(this, R.layout.list_item_planetas,planetas);
        listView.setAdapter(adapter);
        listView.setOnItemClickListener((parent, view, position, id) -> {
            String seleccionado = planetas[position];

        });
    }
}
