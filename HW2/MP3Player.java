package javaapplication2;

import java.util.Arrays;

/**
 * class MP3Player extends SoundReproducingDevice, contains same param:
 * SoundCarrier arrayOfSoundCarriers[]
 *
 * @author VERON
 */
public class MP3Player extends SoundReproducingDevice {

    /**
     * Constructor returns MP3Player with empty fields
     */
    public MP3Player() {
        super();
    }

    /**
     * Constructor returns MP3Player with field made of array of SoundCarriers
     *
     * @param arrayOfSoundCarriers
     */
    public MP3Player(SoundCarrier arrayOfSoundCarriers[]) {
        super(arrayOfSoundCarriers);
    }

    /**
     * Constructor returns copy of another MP3Player
     *
     * @param other
     */
    public MP3Player(MP3Player other) {
        super(other.arrayOfSoundCarriers);
    }

    /**
     * Method toString() formats output of MPPlayer
     *
     * @return String
     */
    @Override
    public String toString() {
        return String.format("Объект — звуковоспроизводящее устройство — mp3-проигрыватель, набор носителей: %s", Arrays.toString(this.arrayOfSoundCarriers));
    }

    /**
     * Method hashCode() generates hashCode
     *
     * @return hash
     */
    @Override
    public int hashCode() {
        int hash = 33;
        if (this.arrayOfSoundCarriers != null) {
            hash = 99 * hash + Arrays.hashCode(this.arrayOfSoundCarriers);
        }
        return hash;
    }

    /**
     * Method equals() compares two MP3Player-objects
     *
     * @param o
     * @return boolean
     */
    @Override
    public boolean equals(Object o) {
        if (o == null) {
            return false;
        }
        if (o instanceof MP3Player) {
            final MP3Player other = (MP3Player) o;
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
        String output = "MP3-проигрыватель";
        for (SoundCarrier arrayOfSoundCarrier : this.arrayOfSoundCarriers) {
            if (arrayOfSoundCarrier instanceof SD || arrayOfSoundCarrier instanceof FlashDrive) {
                output += String.format("%n%s", arrayOfSoundCarrier.toString());
            } else {
                output += String.format("%n") + error;
            }
        }
        return output;
    }
}
