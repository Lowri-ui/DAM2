package PracticasConCesar.Examples;

import java.util.concurrent.Callable;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.Future;

public class Reader implements Callable<String> {
	
	@Override
	public String call() throws Exception {
		String readedText = "I like action movies";
		Thread.sleep(1000);
		return readedText;
	}
	public static void main(String[] args) {
		try {
			Reader reader = new Reader();
			ExecutorService serviceExecution = 
					Executors.newSingleThreadExecutor();
			Future<String> result =
					serviceExecution.submit(reader);
			String text= result.get();
			if (result.isDone()) {
				System.out.println(text);
				System.out.println("Finished process");
				
			} else if (result.isCancelled()) {
				System.out.println("Cancelled process");
			}
			serviceExecution.shutdown();
		} catch (Exception e) {
			e.printStackTrace();
		}
	}
}
