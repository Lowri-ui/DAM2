package PracticasConCesar.Excercise3_Exchanger;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.concurrent.Exchanger;

public class ClassB implements Runnable{
    private Exchanger<String> exchanger;
    public ClassB(Exchanger<String> exchanger) {
        this.exchanger = exchanger;
    }
    public void run(){
        String macip = "";
        try{
            ProcessBuilder pb = new ProcessBuilder("cmd.exe", "/c", "ipconfig" , "/all");
            pb.redirectErrorStream(true);

            // start the process
            Process process = pb.start();

            // read the output of the command
            BufferedReader br = new BufferedReader(new InputStreamReader(process.getInputStream()));
            String line;

            // iterate through the output lines
            while ((line = br.readLine()) != null) {
                line = line.trim(); //deletes spaces

                // Check if the line has "Dirección física"
                if (line.contains("sica") || line.contains("Physical Address")){
                    String[] parts = line.split(":");
                    if (parts.length > 1) {
                        macip = parts[1].trim();
                        break; // iterates once
                    }
                }
            }

            String receivedIP = exchanger.exchange(macip);
            System.out.println("\n-- Original MAC IP: "+ macip + "\n" +
                    "IP received:"+ receivedIP);

        } catch (InterruptedException |  IOException e) {
            e.printStackTrace();
        }
    }
}
