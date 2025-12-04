package PracticasConCesar.Examples;

import java.util.concurrent.Exchanger;

public class TaskA implements Runnable {
	private Exchanger<String> exchanger;
	
	public TaskA(Exchanger<String> exchanger) {
		super();
		this.exchanger = exchanger;
		
	}
	
	public void run() {
		try {
			String receivedMessage = exchanger.exchange("Message sent from TaskA");
			System.out.println("Message received at TaskA:"+ receivedMessage);
		} catch (InterruptedException e) {
			e.printStackTrace();
		}
	}
	
}
