package javaapplication4;

import java.util.ArrayList;
import java.util.List;
import java.util.concurrent.*;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 * Class MakeExecutionGroup that speeds up class Matcher using
 * MatcherWithCallable
 *
 * @author VERON
 */
public class MakeExecutionGroup {

    public static void main(String[] args) throws InterruptedException {
        /*
        Get current time to get time of execution
         */
        final long startTime = System.nanoTime();

        ExecutorService executor = (ExecutorService) Executors.newCachedThreadPool();

        final String input = "Раскаяние – самая бесполезная вещь на свете."
                + " Вернуть ничего нельзя. Ничего нельзя исправить. "
                + "Иначе все мы были бы святыми. "
                + "Жизнь не имела в виду сделать нас совершенными. "
                + "Тому, кто совершенен, место в музее.";

        List<MatcherWithCallable> tasks = new ArrayList<>();
        tasks.add(new MatcherWithCallable(input.substring(0, input.length() / 4), " "));
        tasks.add(new MatcherWithCallable(input.substring(input.length() / 4 + 1, input.length() / 2), " "));
        tasks.add(new MatcherWithCallable(input.substring(input.length() / 2 + 1, input.length() / 4 * 3), " "));
        tasks.add(new MatcherWithCallable(input.substring(input.length() / 4 * 3 + 1), " "));

        List<Future<Integer>> results = executor.invokeAll(tasks);
        executor.shutdown();
        Integer sum = 0;

        for (Future<Integer> result : results) {
            try {
                sum += result.get();
            } catch (ExecutionException ex) {
                Logger.getLogger(MakeExecutionGroup.class.getName()).log(Level.SEVERE, null, ex);
            }
        }

        System.out.printf("Sum of templates: %d%n", sum);
        System.out.printf("Time of execution: %.3f%n", (System.nanoTime() - startTime) / 1e9);

    }
}
