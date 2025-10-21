package actividad3_05;

import android.content.Intent;
import android.content.Context;

public class DataManager {

    public void sendDataReadyBroadcast(Context context) {
        // 1. Uso de Action: Crear un Intent con la Action personalizada
        Intent broadcastIntent = new Intent(MyCustomReceiver.ACTION_CUSTOM_UPDATE);

        // 2. Uso de Extras: Adjuntar datos sobre el evento
        broadcastIntent.putExtra("STATUS_MESSAGE", "Datos procesados y listos.");
        broadcastIntent.putExtra("SUCCESS", true);

        // Enviar el Broadcast
        context.sendBroadcast(broadcastIntent);
    }
}