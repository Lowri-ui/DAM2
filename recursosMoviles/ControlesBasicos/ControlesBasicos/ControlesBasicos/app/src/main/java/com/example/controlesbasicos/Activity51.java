package com.example.controlesbasicos;

import static android.graphics.Typeface.BOLD;
import static android.graphics.Typeface.ITALIC;

import android.graphics.Color;
import android.graphics.Typeface;
import android.os.Bundle;
import android.os.PersistableBundle;
import android.widget.TextView;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.content.res.ResourcesCompat;

public class Activity51 extends AppCompatActivity {
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        setContentView(R.layout.activity_5_1);

        /*
        Actividad 5.1.1
         */

//        TextView tvContenido = (TextView) findViewById(R.id.tvContenido);
//        Typeface typeface = ResourcesCompat.getFont(this, R.font.milky_candy);
//        tvContenido.setTypeface(typeface);
//        tvContenido.setText("Texto construido desde el XML. Tamaño 20dp, Bold y color Red. Laura Pinel.");
//        tvContenido.setTextColor(Color.RED);

        /*
        Actividad 5.1.2
         */

        TextView tvContenido = (TextView) findViewById(R.id.tvContenido);
        Typeface typeface = ResourcesCompat.getFont(this, R.font.licorice_regular);
        tvContenido.setTypeface(typeface,ITALIC);
        tvContenido.setText("Texto construido desde el XML. Tamaño 20dp, Bold y color Red. Laura Pinel.");
        tvContenido.setTextColor(Color.BLUE);



    }
}
