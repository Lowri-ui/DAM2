package PracticasConCesar.Examples;

import java.util.Queue;
import java.util.concurrent.ConcurrentLinkedDeque;

public class ConcurrentQueue implements Runnable {
	private static Queue<Integer> myq = new ConcurrentLinkedDeque<Integer>();
	
	@Override
	public void run() {
		myq.add(10);
		for (Integer i : myq) {
			System.out.println(i + ":");
		}
		System.out.println("Queue size:" + myq.size());
	}
	
	public static void main(String[] args) {
		for(int i=0; i<10;i++) {
			new Thread(new ConcurrentQueue()).start();
		}
	}
}
