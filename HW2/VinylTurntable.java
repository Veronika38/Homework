/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javaapplication2;

import java.util.Arrays;
import java.util.Objects;

/**
 * class VinylTurntable extends SoundReproducingDevice, contains same param:
 * SoundCarrier arrayOfSoundCarriers[]
 *
 * @author VERON
 */
public class VinylTurntable extends SoundReproducingDevice {

    /**
     * Constructor returns VinylTurntable with empty fields
     */
    public VinylTurntable() {
        super();
    }

    /**
     * Constructor returns VinylTurntable with field made of array of
     * SoundCarriers
     *
     * @param arrayOfSoundCarriers
     */
    public VinylTurntable(SoundCarrier arrayOfSoundCarriers[]) {
        super(arrayOfSoundCarriers);
    }

    /**
     * Constructor returns copy of another VinylTurntable
     *
     * @param other
     */
    public VinylTurntable(VinylTurntable other) {
        super(other.arrayOfSoundCarriers);
    }

    /**
     * Method toString() formats output of VinylTurntable
     *
     * @return String
     */
    @Override
    public String toString() {
        return String.format("Объект — звуковоспроизводящее устройство — виниловая вертушка, набор носителей: %s", Arrays.toString(this.arrayOfSoundCarriers));
    }

    /**
     * Method hashCode() generates hashCode
     *
     * @return hash
     */
    @Override
    public int hashCode() {
        int hash = 31;
        if (this.arrayOfSoundCarriers != null) {
            hash = 99 * hash + Arrays.hashCode(this.arrayOfSoundCarriers);
        }
        return hash;
    }

    /**
     * Method equals() compares two VinylTurntable-objects
     *
     * @param o
     * @return boolean
     */
    @Override
    public boolean equals(Object o) {
        if (o == null) {
            return false;
        }
        if (o instanceof VinylTurntable) {
            final VinylTurntable other = (VinylTurntable) o;
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
    public String plays() {
        String error = "Ошибка воспроизведения: неверный носитель";
        String output = "Виниловая вертушка";
        for (SoundCarrier arrayOfSoundCarrier : this.arrayOfSoundCarriers) {
            if (arrayOfSoundCarrier instanceof Record) {
                output += String.format("%n%s", arrayOfSoundCarrier.toString());
            } else {
                output += String.format("%n") + error;
            }
        }
        return output;
    }
}
