package actividad3_05;

import android.app.Service;
import android.content.Intent;
import android.os.IBinder;
import android.util.Log;

public class MyDownloadService extends Service {

    // Este método se llama cuando el Service es iniciado por startService()
    @Override
    public int onStartCommand(Intent intent, int flags, int startId) {
        if (intent != null) {
            // 1. Uso de Extras: Recuperar datos pasados en el Intent
            String url = intent.getStringExtra("URL_TO_DOWNLOAD");
            int userId = intent.getIntExtra("USER_ID", -1);

            Log.d("MyService", "Iniciando descarga de: " + url + " para usuario: " + userId);

            // Lógica de la tarea de larga duración...
        }
        return START_STICKY;
    }

    // Método requerido para Services, no relevante para startService()
    @Override
    public IBinder onBind(Intent intent) {
        return null;
    }
}
