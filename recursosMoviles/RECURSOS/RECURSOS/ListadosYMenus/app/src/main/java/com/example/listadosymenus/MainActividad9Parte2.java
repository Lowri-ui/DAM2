package com.example.listadosymenus;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;

import android.os.Bundle;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.widget.TextView;
import android.widget.Toast;

public class MainActividad9Parte2 extends AppCompatActivity {

    TextView textViewResultado;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.main_menu_submenu_layout);

        textViewResultado = findViewById(R.id.textViewResultadoSubmenu);
        Toolbar myToolbar = findViewById(R.id.my_toolbar);
        setSupportActionBar(myToolbar);

    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        MenuInflater inflater = getMenuInflater();
        inflater.inflate(R.menu.main_menu_with_submenus, menu); // Usamos el XML
        return true;
    }


    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        int id = item.getItemId();

        // submenú de animales fantásticos acuáticos
        if (id == R.id.animal_kelpie) {
            mostrarSeleccion("Animales Acuáticos > Kelpie: espíritu acuático que habita ríos y lagos.");
            return true;
        } else if (id == R.id.animal_merpeople) {
            mostrarSeleccion("Animales Acuáticos > Merpeople: habitantes mágicos de los lagos de Hogwarts.");
            return true;
        } else if (id == R.id.animal_goblinpez) {
            mostrarSeleccion("Animales Acuáticos > Goblin Pez: criatura mágica acuática.");
            return true;
        }
        // submenú de animales fantásticos terrestres
        else if (id == R.id.animal_unicornio) {
            mostrarSeleccion("Animales Terrestres > Unicornio: símbolo de pureza y magia.");
            return true;
        } else if (id == R.id.animal_licantropo) {
            mostrarSeleccion("Animales Terrestres > Licántropo: se transforma con la luna llena.");
            return true;
        } else if (id == R.id.animal_hipogrifo) {
            mostrarSeleccion("Animales Terrestres > Hipogrifo: mitad caballo, mitad águila.");
            return true;
        } else if (id == R.id.animal_dragon) {
            mostrarSeleccion("Animales Terrestres > Dragón: criatura poderosa que protege tesoros.");
            return true;
        } else if (id == R.id.animal_avefenix) {
            mostrarSeleccion("Animales Terrestres > Ave Fénix: renace de sus cenizas.");
            return true;
        }

        return super.onOptionsItemSelected(item);
    }


    /**
     * Método auxiliar para mostrar el resultado en el TextView y en un Toast.
     */
    private void mostrarSeleccion(String mensaje) {
        textViewResultado.setText("Has seleccionado: " + mensaje);
        Toast.makeText(this, mensaje, Toast.LENGTH_SHORT).show();
    }
}

