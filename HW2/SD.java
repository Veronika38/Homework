package javaapplication2;

import java.util.Arrays;

/**
 * class SD extends SoundCarrier, contains same param: Song arrayOfSongs[]
 *
 * @author VERON
 */
public class SD extends SoundCarrier {

    /**
     * Constructor returns SD with empty fields
     */
    public SD() {
        super();
    }

    /**
     * Constructor returns SD with field made of array of Songs
     *
     * @param arrayOfSongs
     */
    public SD(Song arrayOfSongs[]) {
        super(arrayOfSongs);
    }

    /**
     * Constructor returns copy of another SD
     *
     * @param other
     */
    public SD(SD other) {
        super(other.arrayOfSongs);
    }

    /**
     * Method toString() formats output of SD
     *
     * @return String
     */
    @Override
    public String toString() {
        return String.format("Объект — музыкальный носитель — сд, набор песен: %s", Arrays.toString(this.arrayOfSongs));
    }

    /**
     * Method hashCode() generates hashCode
     *
     * @return hash
     */
    @Override
    public int hashCode() {
        int hash = 22;
        if (this.arrayOfSongs != null) {
            hash = 89 * hash + Arrays.hashCode(this.arrayOfSongs);
        }
        return hash;
    }

    /**
     * Method equals() compares two SD-objects
     *
     * @param o
     * @return boolean
     */
    @Override
    public boolean equals(Object o) {
        if (o == null) {
            return false;
        }
        if (o instanceof SD) {
            final SD other = (SD) o;
            return this.hashCode() == other.hashCode() && Arrays.equals(this.arrayOfSongs, other.arrayOfSongs);
        } else {
            return false;
        }
    }
}
