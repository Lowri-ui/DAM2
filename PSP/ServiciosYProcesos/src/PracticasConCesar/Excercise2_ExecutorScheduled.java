package PracticasConCesar;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.concurrent.Executors;
import java.util.concurrent.ScheduledExecutorService;
import java.util.concurrent.TimeUnit;

/**
 * Build a program which uses a Thread to check the IP of the computer every two minutes
 * and prompts a message if there is being some change. Use ScheduledExecutorService.
 */

public class Excercise2_ExecutorScheduled {
    public static void main(String[] args) {

        //create the schedule
        ScheduledExecutorService scheduler = Executors.newScheduledThreadPool(1);

        Runnable tarea = () ->{ try{
            //setting up external command
            ProcessBuilder pb = new ProcessBuilder( "cmd.exe", "/c", "ipconfig");

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

        }catch (IOException | InterruptedException e){
            System.out.println(e);
        }
    };

        // executes every 2 minutes (120secs)
        scheduler.scheduleAtFixedRate(tarea, 0, 120, TimeUnit.SECONDS);
    }
}

