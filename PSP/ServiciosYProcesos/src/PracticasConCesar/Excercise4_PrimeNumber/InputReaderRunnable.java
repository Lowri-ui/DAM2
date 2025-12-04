package PracticasConCesar.Excercise4_PrimeNumber;

import java.util.Scanner;

public class InputReaderRunnable implements Runnable {
    @Override
    public void run() {
        Scanner sc = new Scanner(System.in);
        int num = sc.nextInt();

    }
}
