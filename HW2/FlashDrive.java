/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javaapplication2;

import java.util.Arrays;

/**
 * class FlashDrive extends SoundCarrier, contains same param: Song
 * arrayOfSongs[]
 *
 * @author VERON
 */
public class FlashDrive extends SoundCarrier {

    /**
     * Constructor returns FlashDrive with empty fields
     */
    public FlashDrive() {
        super();
    }

    /**
     * Constructor returns FlashDrive with field made of array of Songs
     *
     * @param arrayOfSongs
     */
    public FlashDrive(Song arrayOfSongs[]) {
        super(arrayOfSongs);
    }

    /**
     * Constructor returns copy of another FlashDrive
     *
     * @param other
     */
    public FlashDrive(FlashDrive other) {
        super(other.arrayOfSongs);
    }

    /**
     * Method toString() formats output of FlashDrive
     *
     * @return String
     */
    @Override
    public String toString() {
        return String.format("Объект — музыкальный носитель — флешка, набор песен: %s", Arrays.toString(this.arrayOfSongs));
    }

    /**
     * Method hashCode() generates hashCode
     *
     * @return hash
     */
    @Override
    public int hashCode() {
        int hash = 23;
        if (this.arrayOfSongs != null) {
            hash = 89 * hash + Arrays.hashCode(this.arrayOfSongs);
        }
        return hash;
    }

    /**
     * Method equals() compares two Record-objects
     *
     * @param o
     * @return boolean
     */
    @Override
    public boolean equals(Object o) {
        if (o == null) {
            return false;
        }
        if (o instanceof FlashDrive) {
            final FlashDrive other = (FlashDrive) o;
            return this.hashCode() == other.hashCode() && Arrays.equals(this.arrayOfSongs, other.arrayOfSongs);
        } else {
            return false;
        }
    }
}
