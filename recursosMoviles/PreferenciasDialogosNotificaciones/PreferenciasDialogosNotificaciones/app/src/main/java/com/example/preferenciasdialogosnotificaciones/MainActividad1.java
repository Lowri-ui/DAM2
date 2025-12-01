package com.example.preferenciasdialogosnotificaciones;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.SeekBar;
import android.widget.TextView;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

public class MainActividad1 extends AppCompatActivity implements View.OnClickListener {
    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.layout_actividad1);

        //Asignamos las vistas del layout
        TextView tv = findViewById(R.id.textViewTitulo);
        TextView tv2 = findViewById(R.id.textViewTitulo2);
        Button btn = findViewById(R.id.btnDefinir);
        Button btn2 = findViewById(R.id.btnRecuperar);
    }

    @Override
    public void onClick(View v) {

    }

}
