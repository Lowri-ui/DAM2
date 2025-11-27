package PracticasConCesar;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

/**
 * 2. Modify the program so that:
 * a) extracts the host name and IPv4 address from the command output
 * b) changes directory to a directory named “result” (you can create it from the OS)
 * c) creates a file with the hostname and IPv4 address.
 */

public class Excercise1_2 {

    //declares 'throws IOException' because starting an external process can fail
    static void main(String[] args) throws IOException {

        try{
            //1. Setting up the external command.
            ProcessBuilder pb = new ProcessBuilder("ipconfig");

            // 2. Launching the process.
            Process process = pb.start();

            //3. Read the Process Output and Print the lines
            BufferedReader reader = new BufferedReader(
                    new InputStreamReader(process.getInputStream())
            );
            String line = null;
            while ((line = reader.readLine()) != null) {
                System.out.println(line);
            }
            System.out.println("-----------------");

            // 4. Waiting for the external program to finish.
            int codigo = process.waitFor();

            // 5. Printing the Exit Code.
            System.out.println("CODE SUCCESS: " + codigo);

        } catch (IOException e) {
            throw new RuntimeException(e);

        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        }
    }
}
