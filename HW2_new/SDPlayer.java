/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javaapplication2;

import java.util.Arrays;

/**
 * class SDPlayer extends SoundReproducingDevice, contains same param:
 * SoundCarrier arrayOfSoundCarriers[]
 *
 * @author VERON
 */
public class SDPlayer extends SoundReproducingDevice {

    /**
     * Constructor returns SDPlayer with empty fields
     */
    public SDPlayer() {
        super();
    }

    /**
     * Constructor returns SDPlayer with field made of array of SoundCarriers
     *
     * @param arrayOfSoundCarriers
     */
    public SDPlayer(SoundCarrier arrayOfSoundCarriers[]) {
        super(arrayOfSoundCarriers);
    }

    /**
     * Constructor returns copy of another SDPlayer
     *
     * @param other
     */
    public SDPlayer(SDPlayer other) {
        super(other.arrayOfSoundCarriers);
    }

    /**
     * Method toString() formats output of SDPlayer
     *
     * @return String
     */
    @Override
    public String toString() {
        return String.format("Объект — звуковоспроизводящее устройство — sd-проигрыватель, набор носителей: %s", Arrays.toString(this.arrayOfSoundCarriers));
    }

    /**
     * Method hashCode() generates hashCode
     *
     * @return hash
     */
    @Override
    public int hashCode() {
        int hash = 32;
        if (this.arrayOfSoundCarriers != null) {
            hash = 99 * hash + Arrays.hashCode(this.arrayOfSoundCarriers);
        }
        return hash;
    }

    /**
     * Method equals() compares two SDPlayer-objects
     *
     * @param o
     * @return boolean
     */
    @Override
    public boolean equals(Object o) {
        if (o == null) {
            return false;
        }
        if (o instanceof SDPlayer) {
            final SDPlayer other = (SDPlayer) o;
            return this.hashCode() == other.hashCode() && Arrays.equals(this.arrayOfSoundCarriers, other.arrayOfSoundCarriers);
        } else {
            return false;
        }
    }

    /**
     * Method play() shows which SoundCarriers from array can be played
     *
     * @return String
     */
    @Override
    public String plays() {
        String error = "Ошибка воспроизведения: неверный носитель";
        String output = "SD-проигрыватель";
        for (SoundCarrier arrayOfSoundCarrier : this.arrayOfSoundCarriers) {
            if (arrayOfSoundCarrier instanceof SD) {
                output += String.format("%n%s", arrayOfSoundCarrier.toString());
            } else {
                output += String.format("%n") + error;
            }
        }
        return output;
    }
}
