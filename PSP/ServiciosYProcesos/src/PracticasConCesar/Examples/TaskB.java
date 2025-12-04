package PracticasConCesar.Examples;

import java.util.concurrent.Exchanger;

public class TaskB implements Runnable {
	private Exchanger<String> exchanger;
	
	public TaskB(Exchanger<String> exchanger) {
		super();
		this.exchanger = exchanger;
	}
	
	public void run() {
		try {
			String receivedMessage = exchanger.exchange("Message sent from TaskB");
			System.out.println("Message received at TaskB:"+ receivedMessage);
		} catch (InterruptedException e) {
			e.printStackTrace();
		}
	}
	
}