package PracticasConCesar;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.concurrent.Executors;
import java.util.concurrent.ScheduledExecutorService;
import java.util.concurrent.TimeUnit;

/**
 * Build a program which uses a ScheduledExecutorService to check the IPv4 address of the computer
 * every two minutes and prompts a message only if it changes.
 */

public class Excercise2_ExecutorScheduled {

    // variable to store the old IPv4 address in case it changes
    private static String oldIPv4 = "";

    public static void main(String[] args) {

        // create the scheduler with one thread
        ScheduledExecutorService scheduler = Executors.newScheduledThreadPool(1);

        Runnable task = () -> {
            try {
                // setting up external command to get IP information
                ProcessBuilder pb = new ProcessBuilder("cmd.exe", "/c", "ipconfig");
                pb.redirectErrorStream(true);

                // start the process
                Process process = pb.start();

                // read the output of the command
                BufferedReader br = new BufferedReader(new InputStreamReader(process.getInputStream()));
                String line;
                String currentIPv4 = "";

                // iterate through the output lines
                while ((line = br.readLine()) != null) {

                    // Check if the line contains the "IPv4"
                    if (line.contains("IPv4")) {

                        // extracting the IPv4
                        String[] parts = line.split(":");
                        if (parts.length > 1) {
                            currentIPv4 = parts[1].trim();
                            break; // we only need the first IPv4 found
                        }
                    }
                }

                // close the buffer
                br.close();

                // wainting until the process finishes
                process.waitFor();

                // compare with the previous IP and send a message if it has changed
                if (!currentIPv4.isEmpty() && !currentIPv4.equals(oldIPv4)) {
                    System.out.println("New IPv4 detected -> " + currentIPv4);
                    oldIPv4 = currentIPv4; // updates the IP
                }

            } catch (IOException | InterruptedException e) {
                e.printStackTrace();
            }
        };

        // Schedule the task to run every 2 minutes (120 seconds)
        scheduler.scheduleAtFixedRate(task, 0, 120, TimeUnit.SECONDS);
    }
}
