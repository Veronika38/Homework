package javaapplication4;

/**
 * Class MatcherWithThread that implements Runnable, counts number of certain
 * symbols in string
 *
 * @author VERON
 */
public class MatcherWithThread implements Runnable {

    private final String str;
    private final String find;
    private static volatile int sum = 0;

    /**
     * Constructor returns MatcherWithTread with fields made from user's values
     *
     * @param str
     * @param find
     */
    public MatcherWithThread(String str, String find) {
        this.str = str;
        this.find = find;
    }

    /**
     * Getter
     *
     * @return sum
     */
    public static int getSum() {
        return sum;
    }

    /**
     * Overridden run() to find number of finds' matches in str
     */
    @Override
    public void run() {
        for (int i = 0; i < str.length(); i++) {
            sum += Matcher.match(String.valueOf(str.charAt(i)), this.find) ? 1 : 0;
        }
    }

}
