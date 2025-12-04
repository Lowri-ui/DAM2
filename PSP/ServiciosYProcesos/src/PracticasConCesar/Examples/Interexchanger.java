package PracticasConCesar.Examples;

import java.util.concurrent.Exchanger;
public class Interexchanger {
	
	public static void main(String[] args) {
		Exchanger<String> exchanger = new Exchanger<String>();
		new Thread(new TaskA(exchanger)).start();
		new Thread(new TaskB(exchanger)).start();
	}

}
