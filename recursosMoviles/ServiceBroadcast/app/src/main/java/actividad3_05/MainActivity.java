package actividad3_05;

import android.content.Intent;
import android.app.Activity;

public class MainActivity extends Activity {

    private void startMyService() {
        // 1. Uso de Component Name: Intent Explícito
        Intent serviceIntent = new Intent(this, MyDownloadService.class);

        // 2. Uso de Extras: Agregar la URL y un ID de usuario
        serviceIntent.putExtra("URL_TO_DOWNLOAD", "https://api.ejemplo.com/data.json");
        serviceIntent.putExtra("USER_ID", 456);

        // Iniciar el Service
        startService(serviceIntent);
    }
}