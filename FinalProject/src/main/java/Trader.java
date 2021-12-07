/**
 * Class Trader contains ID, FamilyName and Name
 *
 * @author VERON
 */
public class Trader {

    protected int traderID;
    protected String traderFamilyName;
    protected String traderName;

    /**
     * Constructor returns Trader with fields made of given param
     *
     * @param traderID
     * @param traderFamilyName
     * @param traderName
     */
    public Trader(int traderID, String traderFamilyName, String traderName) {
        this.traderID = traderID;
        this.traderFamilyName = traderFamilyName;
        this.traderName = traderName;
    }

    /**
     * Constructor returns Trader with fields made of given param, FamilyName
     * and Name are given in one String
     *
     * @param traderID
     * @param traderFamilyName_traderName
     */
    public Trader(int traderID, String traderFamilyName_traderName) {
        this.traderID = traderID;
        String[] a = traderFamilyName_traderName.split(" ");
        this.traderFamilyName = a[0];
        this.traderName = a[1];
    }

    /**
     * Constructor returns copy of another Trader
     *
     * @param other
     */
    public Trader(Trader other) {
        this(other.traderID, other.traderFamilyName, other.traderName);
    }

    /**
     * Getter for ID-param
     *
     * @return int
     */
    public int getTraderID() {
        return this.traderID;
    }

    /**
     * Getter for FamilyName-param
     *
     * @return String
     */
    public String getTraderFamilyName() {
        return this.traderFamilyName;
    }

    /**
     * Getter for Name-param
     *
     * @return String
     */
    public String getTraderName() {
        return this.traderName;
    }

    /**
     * Setter for ID-param
     *
     * @param traderID
     */
    public void setTraderID(int traderID) {
        this.traderID = traderID;
    }

    /**
     * Setter for FamilyName-param
     *
     * @param traderFamilyName
     */
    public void setTraderFamilyName(String traderFamilyName) {
        this.traderFamilyName = traderFamilyName;
    }

    /**
     * Setter for Name-param
     *
     * @param traderName
     */
    public void setTraderName(String traderName) {
        this.traderName = traderName;
    }

    /**
     * Method hashCode() generates hashCode
     *
     * @return int
     */
    @Override
    public int hashCode() {
        return this.traderID + (this.traderFamilyName + this.traderName).hashCode();
    }

    /**
     * Method equals() compares two Trader-objects
     *
     * @param o
     * @return boolean
     */
    @Override
    public boolean equals(Object o) {
        if (o == null) {
            return false;
        }
        if (o instanceof Trader) {
            final Trader other = (Trader) o;
            return this.hashCode() == other.hashCode() && this.traderID == other.traderID && (this.traderFamilyName + this.traderName).equals(other.traderFamilyName + other.traderName);
        } else {
            return false;
        }
    }

    /**
     * Method toString() formats output of Trader
     *
     * @return String
     */
    @Override
    public String toString() {
        return String.format("Trader:%10d — %15s — %15s", this.traderID, this.traderFamilyName, this.traderName);
    }
}
