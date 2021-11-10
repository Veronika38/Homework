package javaapplication4;

/**
 * Class MakeThreads that speeds up class Matcher using MatcherWithThread
 *
 * @author VERON
 */
public class MakeThreads {

    public static void main(String[] args) throws InterruptedException {
        /*
        Get current time to get time of execution
         */
        final long startTime = System.nanoTime();

        final String input = "Раскаяние – самая бесполезная вещь на свете."
                + " Вернуть ничего нельзя. Ничего нельзя исправить. "
                + "Иначе все мы были бы святыми. "
                + "Жизнь не имела в виду сделать нас совершенными. "
                + "Тому, кто совершенен, место в музее.";

        /*
        Make multiple threads (here 4, but it can be more) to speed up the program
         */
        Thread thread1 = new Thread(new MatcherWithThread(input.substring(0, input.length() / 4), " "));
        Thread thread2 = new Thread(new MatcherWithThread(input.substring(input.length() / 4 + 1, input.length() / 2), " "));
        Thread thread3 = new Thread(new MatcherWithThread(input.substring(input.length() / 2 + 1, input.length() / 4 * 3), " "));
        Thread thread4 = new Thread(new MatcherWithThread(input.substring(input.length() / 4 * 3 + 1), " "));

        /*
        Threads start
         */
        thread1.start();
        thread2.start();
        thread3.start();
        thread4.start();

        /*
        Program waits till threads are completed
         */
        thread1.join();
        thread2.join();
        thread3.join();
        thread4.join();

        System.out.printf("Sum of templates: %d%n", MatcherWithThread.getSum());
        System.out.printf("Time of execution: %.3f%n", (System.nanoTime() - startTime) / 1e9);

    }
}
