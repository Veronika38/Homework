/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javaapplication2;

import java.util.Arrays;
import java.util.Objects;

/**
 * class SoundCarrier contains two param: Song arrayOfSongs[]
 *
 * @author VERON
 */
public class SoundCarrier {

    protected Song arrayOfSongs[];

    /**
     * Constructor returns SoundCarrier with empty fields
     */
    public SoundCarrier() {
        Song arrayOfSongs1[] = {};
        this.arrayOfSongs = arrayOfSongs1;
    }

    /**
     * Constructor returns SoundCarrier with field made of array of Songs
     *
     * @param arrayOfSongs
     */
    public SoundCarrier(Song arrayOfSongs[]) {
        this.arrayOfSongs = arrayOfSongs;
    }

    /**
     * Constructor returns copy of another SoundCarrier
     *
     * @param other
     */
    public SoundCarrier(SoundCarrier other) {
        this(other.arrayOfSongs);
    }

    /**
     * Getter for arrayOfSongs-field
     *
     * @return Song arrayOfSongs
     */
    public Song[] getArrayOfSongs() {
        return this.arrayOfSongs;
    }

    /**
     * Setter for arrayOfSongs-field
     *
     * @param arrayOfSongs
     */
    public void setArrayOfSongs(Song arrayOfSongs[]) {
        this.arrayOfSongs = arrayOfSongs;
    }

    /**
     * Method toString() formats output of SoundCarrier
     *
     * @return String
     */
    @Override
    public String toString() {
        return String.format("Объект — музыкальный носитель, набор песен: %s", Arrays.toString(this.arrayOfSongs));
    }

    /**
     * Method hashCode() generates hashCode
     *
     * @return hash
     */
    @Override
    public int hashCode() {
        int hash = 2;
        if (this.arrayOfSongs != null) {
            hash = 89 * hash + Arrays.hashCode(this.arrayOfSongs);
        }
        return hash;
    }

    /**
     * Method equals() compares two SoundCarrier-objects
     *
     * @param o
     * @return boolean
     */
    @Override
    public boolean equals(Object o) {
        if (o == null) {
            return false;
        }
        if (o instanceof SoundCarrier) {
            final SoundCarrier other = (SoundCarrier) o;
            return this.hashCode() == other.hashCode() && Arrays.equals(this.arrayOfSongs, other.arrayOfSongs);
        } else {
            return false;
        }
    }

}
