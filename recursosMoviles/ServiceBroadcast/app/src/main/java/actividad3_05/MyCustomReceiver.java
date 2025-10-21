package actividad3_05;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.util.Log;

public class MyCustomReceiver extends BroadcastReceiver {

    // Uso de Action: Definición de una Acción Personalizada
    public static final String ACTION_CUSTOM_UPDATE = "com.myapp.ACTION_DATA_READY";

    @Override
    public void onReceive(Context context, Intent intent) {
        // Comprobar la Action para asegurarse de que es la esperada
        if (ACTION_CUSTOM_UPDATE.equals(intent.getAction())) {
            // 1. Uso de Extras: Recuperar el mensaje
            String message = intent.getStringExtra("STATUS_MESSAGE");
            boolean success = intent.getBooleanExtra("SUCCESS", false);

            Log.i("Receiver", "Broadcast Recibido. Estado: " + message + ", Éxito: " + success);
        }
    }
}
