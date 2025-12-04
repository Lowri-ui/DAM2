package PracticasConCesar.Examples;

import java.util.LinkedList;
import java.util.Queue;

public class NotConcurrentQueue implements Runnable{

		private static Queue<Integer> myq= new LinkedList<Integer>();
		
		@Override
		public void run() {
			myq.add(10);
			for (Integer i : myq) {
				System.out.print(i+":");
			}
			System.out.println("Queue size: " + myq.size());
		}
		
		public static void main(String[] args) {
			for(int i=0;i<10;i++) {
				new Thread(new NotConcurrentQueue()).start();
			}
		}
}

