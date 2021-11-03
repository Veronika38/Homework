package javaapplication3;

import java.util.logging.Level;
import java.util.logging.Logger;

/**
 * class Check for testing class PositionOnChessboard
 *
 * @author VERON
 */
public class Check {

    public static void main(String[] args) {
        PositionOnChessboard a, a1, a2;
        try {
            a = new PositionOnChessboard(10, 2);
        } catch (IncorrectPositionOnChessboard ex) {
            Logger.getLogger(Check.class.getName()).log(Level.SEVERE, null, ex);
        }
        try {
            a1 = new PositionOnChessboard(6, 2);
            a1.setY(3);
            a2 = new PositionOnChessboard(6, 3);
            System.out.printf("%s == %s? %b%n", a2.toString(), a1.toString(), a2.equals(a1));
        } catch (IncorrectPositionOnChessboard ex) {
            Logger.getLogger(Check.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
}
