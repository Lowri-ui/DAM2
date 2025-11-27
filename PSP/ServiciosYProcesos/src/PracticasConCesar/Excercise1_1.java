package PracticasConCesar;

import java.io.IOException;
/**1. Create a java program that:
 a) executes a process which launches a command in the OS in order to get network
 información
 b) waits for this process to end
 c) writes in the console whether it has finished successfully or not
 */

public class Excercise1_1 {

    //declares 'throws IOException' because starting an external process can fail
    static void main(String[] args) throws IOException {

        try{
            //1. CONFIGURATION: Setting up the external command.
            // ProcessBuilder is the standard way to configure and start new OS processes.
            // We tell it to run the "ipconfig" command
            ProcessBuilder pb = new ProcessBuilder("ipconfig");

            // 2. EXECUTION: Launching the process.
            // start() executes the command and returns a 'Process' object,
            // which represents the running 'ipconfig' program
            Process process = pb.start();

            // 3. SYNCHRONIZATION: Waiting for the external program to finish.
            // waitFor() pauses the Java program right here until 'ipconfig' is done running.
            // It returns the Exit Code of the external process
            int codigo = process.waitFor();

            // 4. RESULT: Printing the Exit Code.
            // An Exit Code of 0 means the command finished successfully.
            // Another number (1) indicates an error
            System.out.println("CODE SUCCESS: " + codigo);

        } catch (IOException e) {
            // Catches errors related to I/O, such as the command not being found
            // or failing to start
            throw new RuntimeException(e);

        } catch (InterruptedException e) {

            // Catches errors if the Java thread is interrupted
            // while waiting for the process to finish
            throw new RuntimeException(e);
        }
    }
}
