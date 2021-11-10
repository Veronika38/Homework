package javaapplication4;

import java.util.concurrent.*;

/**
 * Class MatcherWithCallable that uses library concurrent and implements
 * Callable, counts number of certain symbols in string
 *
 * @author VERON
 */
public class MatcherWithCallable implements Callable<Integer> {

    private final String str;
    private final String find;
    private int sum = 0;

    /**
     * Constructor returns MatcherWithCallable with fields made from user's
     * values
     *
     * @param str
     * @param find
     */
    public MatcherWithCallable(String str, String find) {
        this.str = str;
        this.find = find;
    }

    /**
     * Overridden call() to find number of finds' matches in str
     */
    @Override
    public Integer call() {
        for (int i = 0; i < str.length(); i++) {
            sum += Matcher.match(String.valueOf(str.charAt(i)), this.find) ? 1 : 0;
        }
        return sum;
    }

}
