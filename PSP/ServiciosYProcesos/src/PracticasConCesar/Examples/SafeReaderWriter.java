package PracticasConCesar.Examples;

import java.util.List;
import java.util.concurrent.CopyOnWriteArrayList;

public class SafeReaderWriter extends Thread{
	private static List<String> words = new CopyOnWriteArrayList<String>();
	
	@Override
	public void run() {
		words.add(new String("New word"));
		for (String word : words) {
			words.size();
		}
		System.out.println(words.size());
	}
	
	public static void main(String[] args) {
		for (int i=0; i<100;i++) {
			new SafeReaderWriter().start();
		}
	}

}
