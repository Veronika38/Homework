package javaapplication3;

import java.util.Objects;

/**
 * class PositionOnChessboard contains two param: int x, y
 *
 * @exception IllegalArgumetException
 * @author VERON
 */
public class PositionOnChessboard {

    protected int x, y;

    /**
     * Constructor returns PositionOnChessboard (1,1)
     */
    public PositionOnChessboard() {
        this.x = 1;
        this.y = 1;
    }

    /**
     * Constructor returns PositionOnChessboard with fields made from user's
     * coordinates
     *
     * @throws javaapplication3.IncorrectPositionOnChessboard
     * @throws IllegalArgumentException x||y not in[1;8]
     * @param x
     * @param y
     */
    public PositionOnChessboard(int x, int y) throws IncorrectPositionOnChessboard {
        if (x > 0 && x < 9 && y > 0 && y < 9) {
            this.x = x;
            this.y = y;
        } else {
            throw new IncorrectPositionOnChessboard();
        }
    }

    /**
     * Constructor returns copy of another PositionOnChessboard
     *
     * @param other
     */
    public PositionOnChessboard(PositionOnChessboard other) {
        this.x = other.x;
        this.y = other.y;
    }

    /**
     * Getter for x-field
     *
     * @return x
     */
    public int getX() {
        return this.x;
    }

    /**
     * Getter for y-field
     *
     * @return y
     */
    public int getY() {
        return this.y;
    }

    /**
     * Setter for x-field
     *
     * @throws javaapplication3.IncorrectPositionOnChessboard
     * @throws IllegalArgumentException x||y not in[1;8]
     * @param x
     */
    void setX(int x) throws IncorrectPositionOnChessboard {
        if (x > 0 && x < 9) {
            this.x = x;
        } else {
            throw new IncorrectPositionOnChessboard();
        }
    }

    /**
     * Setter for y-field
     *
     * @throws javaapplication3.IncorrectPositionOnChessboard
     * @throws IllegalArgumentException x||y not in[1;8]
     * @param y
     */
    void setY(int y) throws IncorrectPositionOnChessboard {
        if (y > 0 && y < 9) {
            this.y = y;
        } else {
            throw new IncorrectPositionOnChessboard();
        }
    }

    /**
     * Method toString() formats output of PositionOnChessboard
     *
     * @return String
     */
    @Override
    public String toString() {
        char c = 'a';
        while ((int) c != 96 + this.x) {
            c++;
        }
        return String.format("%c%d", c, this.y);
    }

    /**
     * Method hashCode() generates hashCode
     *
     * @return hash
     */
    @Override
    public int hashCode() {
        int hash = 6;
        hash = 79 * hash + Objects.hashCode(this.x);
        hash = 79 * hash + Objects.hashCode(this.y);
        return hash;
    }

    /**
     * Method equals() compares two PositionOnChessboard-objects
     *
     * @param o
     * @return boolean
     */
    @Override
    public boolean equals(Object o) {
        if (o == null) {
            return false;
        }
        if (o instanceof PositionOnChessboard) {
            final PositionOnChessboard other = (PositionOnChessboard) o;
            return this.hashCode() == other.hashCode() && this.y == other.y && this.x == other.x;
        } else {
            return false;
        }
    }

}
