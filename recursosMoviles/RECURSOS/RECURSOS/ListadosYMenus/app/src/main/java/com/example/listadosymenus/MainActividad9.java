package com.example.listadosymenus;

import android.os.Bundle;
import android.widget.TextView;
import android.widget.Toolbar;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

public class MainActividad9 extends AppCompatActivity {
    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.actividad9_layout);

        Toolbar tb = findViewById(R.id.my_toolbar);
        TextView tv = findViewById(R.id.textViewResultado);
        
    }
}
