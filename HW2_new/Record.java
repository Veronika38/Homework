/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javaapplication2;

import java.util.Arrays;

/**
 * class Record extends SoundCarrier, contains same param: Song arrayOfSongs[]
 *
 * @author VERON
 */
public class Record extends SoundCarrier {

    /**
     * Constructor returns Record with empty fields
     */
    public Record() {
        super();
    }

    /**
     * Constructor returns Record with field made of array of Songs
     *
     * @param arrayOfSongs
     */
    public Record(Song arrayOfSongs[]) {
        super(arrayOfSongs);
    }

    /**
     * Constructor returns copy of another Record
     *
     * @param other
     */
    public Record(Record other) {
        super(other.arrayOfSongs);
    }

    /**
     * Method toString() formats output of Record
     *
     * @return String
     */
    @Override
    public String toString() {
        return String.format("Объект — музыкальный носитель — пластинка, набор песен: %s", Arrays.toString(this.arrayOfSongs));
    }

    /**
     * Method hashCode() generates hashCode
     *
     * @return hash
     */
    @Override
    public int hashCode() {
        int hash = 21;
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
        if (o instanceof Record) {
            final Record other = (Record) o;
            return this.hashCode() == other.hashCode() && Arrays.equals(this.arrayOfSongs, other.arrayOfSongs);
        } else {
            return false;
        }
    }
}
