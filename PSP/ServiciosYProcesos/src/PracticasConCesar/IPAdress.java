package PracticasConCesar;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

/**
 * Build a program which uses a Thread to check the IP of the computer every two minutes
 * and prompts a message if there is being some change. Use ScheduledExecutorService.
 */
public class IPAdress {
    static void main(String[] args) throws IOException {
        try{
            //setting up external command
            ProcessBuilder pb = new ProcessBuilder("cmd.exe", "/c",
                    "schtasks /create /sc minute /mo 2 /tn \"IP2Minutes Script\" /tr \"C:\\Windows\\System32\\ipconfig.exe\"");

            //deleting command process
//            ProcessBuilder pb = new ProcessBuilder("cmd.exe", "/c",
//                    "schtasks /delete /tn \"IP2Minutes Script\" /f"
//            );

            //starting the process
            Process p = pb.start();

            //reading the output
            BufferedReader br = new BufferedReader(new InputStreamReader(p.getInputStream()));
            String line;

            //printing the output lines
            while ((line = br.readLine()) != null) {
                System.out.println(line);
            }

            //closing the buffer
            br.close();

            //waits for the process to finish
            int codigo = p.waitFor();
            System.out.println("CODE SUCCESS: " + codigo);

        }catch (IOException e){
            System.out.println(e);
            throw new RuntimeException(e);
        }catch (InterruptedException e){
            System.out.println(e);
        }
    }
}
