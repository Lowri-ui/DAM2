package com.example.listadosymenus;

import android.os.Bundle;
import android.view.Menu;
import android.widget.TextView;
import androidx.appcompat.widget.Toolbar;
import androidx.appcompat.app.AppCompatActivity;



public class MainActividad9 extends AppCompatActivity {

    TextView tv;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.actividad9_layout);

        tv = findViewById(R.id.textViewResultado);
        Toolbar tb = findViewById(R.id.my_toolbar);
        setSupportActionBar(tb);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Cargar el menú desde XML
        getMenuInflater().inflate(R.menu.main_menu, menu);
        return true;
    }

}
