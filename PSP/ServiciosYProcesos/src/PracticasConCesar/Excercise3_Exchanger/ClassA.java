package PracticasConCesar.Excercise3_Exchanger;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.concurrent.Exchanger;

public class ClassA implements Runnable{
    private Exchanger<String> exchanger;
    public ClassA(Exchanger<String> exchanger) {
        this.exchanger = exchanger;
    }
    public void run(){
        String ip = "";

        try{
            // setting up external command to get IP information
            ProcessBuilder pb = new ProcessBuilder("cmd.exe", "/c", "ipconfig","/all");
            pb.redirectErrorStream(true);

            // start the process
            Process process = pb.start();

            // read the output of the command
            BufferedReader br = new BufferedReader(new InputStreamReader(process.getInputStream()));
            String line;

            // iterate through the output lines
            while ((line = br.readLine()) != null) {

                // Check if the line contains the "IPv4"
                if (line.contains("IPv4")) {

                    // extracting the IPv4
                    String[] parts = line.split(":");
                    if (parts.length > 1) {
                        ip = parts[1].trim();
                        break; // we only need the first IPv4 found
                    }
                }
            }
            String receivedMac = exchanger.exchange(ip);
            System.out.println("\n-- Original IP: "+ ip + "\n" +
                    "MAC IP received:"+ receivedMac);

        } catch (InterruptedException | IOException e) {
            e.printStackTrace();
        }
    }
}
