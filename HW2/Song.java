package javaapplication2;

import java.util.Objects;

/**
 * class Song contains two param: String nameOfSong, nameOfSongwriter
 *
 * @author VERON
 */
public class Song {

    protected String nameOfSong;
    protected String nameOfSongwriter;

    /**
     * Constructor returns Song with empty fields
     */
    public Song() {
        this("", "");
    }

    /**
     * Constructor returns Song with fields made of two Strings
     *
     * @param nameOfSong
     * @param nameOfSongwriter
     */
    public Song(String nameOfSong, String nameOfSongwriter) {
        this.nameOfSong = nameOfSong;
        this.nameOfSongwriter = nameOfSongwriter;
    }

    /**
     * Constructor returns copy of another Song
     *
     * @param other
     */
    public Song(Song other) {
        this(other.nameOfSong, other.nameOfSongwriter);
    }

    /**
     * Getter for nameOfSong-field
     *
     * @return nameOfSong
     */
    public String getNameOfSong() {
        return this.nameOfSong;
    }

    /**
     * Getter for nameOfSongwriter-field
     *
     * @return nameOfSongwriter
     */
    public String getNameOfSongwriter() {
        return this.nameOfSongwriter;
    }

    /**
     * Setter for nameOfSong-field
     *
     * @param nameOfSong
     */
    public void setNameOfSong(String nameOfSong) {
        this.nameOfSong = nameOfSong;
    }

    /**
     * Setter for nameOfSongwriter-field
     *
     * @param nameOfSongwriter
     */
    public void setNameOfSongwriter(String nameOfSongwriter) {
        this.nameOfSongwriter = nameOfSongwriter;
    }

    /**
     * Method toString() formats output of Song
     *
     * @return String
     */
    @Override
    public String toString() {
        return String.format("Объект — песня: %s, исполнитель — %s", this.nameOfSong, this.nameOfSongwriter);
    }

    /**
     * Method hashCode() generates hashCode
     *
     * @return hash
     */
    @Override
    public int hashCode() {
        int hash = 1;
        if (this.nameOfSong != null) {
            hash = 79 * hash + Objects.hashCode(this.nameOfSong);
        }
        if (this.nameOfSongwriter != null) {
            hash = 79 * hash + Objects.hashCode(this.nameOfSongwriter);
        }
        return hash;
    }

    /**
     * Method equals() compares two Song-objects
     *
     * @param o
     * @return boolean
     */
    @Override
    public boolean equals(Object o) {
        if (o == null) {
            return false;
        }
        if (o instanceof Song) {
            final Song other = (Song) o;
            return this.nameOfSong.equals(other.nameOfSong) && this.nameOfSongwriter.equals(other.nameOfSongwriter) && this.hashCode() == other.hashCode();
        } else {
            return false;
        }
    }

}
