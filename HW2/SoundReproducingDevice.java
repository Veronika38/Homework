/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javaapplication2;

import java.util.Arrays;

/**
 * class SoundReproducingDevice contains two param: SoundCarrier
 * arrayOfSoundCarriers[]
 *
 * @author VERON
 */
public class SoundReproducingDevice {

    protected SoundCarrier arrayOfSoundCarriers[];

    /**
     * Constructor returns SoundReproducingDevice with empty fields
     */
    public SoundReproducingDevice() {
        SoundCarrier arrayOfSoundCarriers1[] = {};
        this.arrayOfSoundCarriers = arrayOfSoundCarriers1;
    }

    /**
     * Constructor returns SoundReproducingDevice with field made of array of
     * SoundCarriers
     *
     * @param arrayOfSoundCarriers
     */
    public SoundReproducingDevice(SoundCarrier arrayOfSoundCarriers[]) {
        this.arrayOfSoundCarriers = arrayOfSoundCarriers;
    }

    /**
     * Constructor returns copy of another SoundReproducingDevice
     *
     * @param other
     */
    public SoundReproducingDevice(SoundReproducingDevice other) {
        this(other.arrayOfSoundCarriers);
    }

    /**
     * Getter for arrayOfSoundCarriers-field
     *
     * @return SoundCarrier[] arrayOfSoundCarriers
     */
    public SoundCarrier[] getArrayOfSoundCarriers() {
        return this.arrayOfSoundCarriers;
    }

    /**
     * Setter for arrayOfSoundCarriers-field
     *
     * @param arrayOfSoundCarriers
     */
    public void setArrayOfSongs(SoundCarrier arrayOfSoundCarriers[]) {
        this.arrayOfSoundCarriers = arrayOfSoundCarriers;
    }

    /**
     * Method toString() formats output of SoundReproducingDevice
     *
     * @return String
     */
    @Override
    public String toString() {
        return String.format("Объект — звуковоспроизводящее устройство, набор носителей: %s", Arrays.toString(this.arrayOfSoundCarriers));
    }

    /**
     * Method hashCode() generates hashCode
     *
     * @return hash
     */
    @Override
    public int hashCode() {
        int hash = 3;
        if (this.arrayOfSoundCarriers != null) {
            hash = 99 * hash + Arrays.hashCode(this.arrayOfSoundCarriers);
        }
        return hash;
    }

    /**
     * Method equals() compares two SoundReproducingDevice-objects
     *
     * @param o
     * @return boolean
     */
    @Override
    public boolean equals(Object o) {
        if (o == null) {
            return false;
        }
        if (o instanceof SoundReproducingDevice) {
            final SoundReproducingDevice other = (SoundReproducingDevice) o;
            return this.hashCode() == other.hashCode() && Arrays.equals(this.arrayOfSoundCarriers, other.arrayOfSoundCarriers);
        } else {
            return false;
        }
    }
}
