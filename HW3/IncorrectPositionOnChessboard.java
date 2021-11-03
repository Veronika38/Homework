package javaapplication3;

/**
 * IllegalArgumentException for case when x or y is not in [1;8]
 * @author VERON
 */
public class IncorrectPositionOnChessboard extends Exception {

    /**
     * Constructor for an IllegalArgumentException with specific final message
     */
    public IncorrectPositionOnChessboard() {
        super("x or y is not in [1;8]");
    }
}
