/**
 * Class SoldProduct contains ID, Name and
 *
 * @author VERON
 */
public class SoldProduct {
    protected int productID;
    protected String productName;
    protected int numberOfSold;

    /**
     * Constructor returns SoldProduct with fields made of given param
     *
     * @param productID
     * @param productName
     * @param numberOfSold
     */
    public SoldProduct(int productID, String productName, int numberOfSold) {
        this.productID = productID;
        this.productName = productName;
        this.numberOfSold = numberOfSold;
    }

    /**
     * Constructor returns copy of another Product
     *
     * @param other
     */
    public SoldProduct(SoldProduct other) {
        this(other.productID, other.productName, other.numberOfSold);
    }

    /**
     * Getter for ID-param
     *
     * @return int
     */
    public int getSoldProductID() {
        return this.productID;
    }

    /**
     * Getter for Name-param
     *
     * @return String
     */
    public String getSoldProductName() {
        return this.productName;
    }

    /**
     * Getter for numberOfSold-param
     *
     * @return int
     */
    public int getNumberOfSold() {
        return this.numberOfSold;
    }

    /**
     * Setter for ID-param
     *
     * @param productID
     */
    public void setSoldProductID(int productID) {
        this.productID = productID;
    }

    /**
     * Setter for Name-param
     *
     * @param productName
     */
    public void setProductName(String productName) {
        this.productName = productName;
    }

    /**
     * Setter for numberOfSold-param
     *
     * @param numberOfSold
     */
    public void setNumberOfSold(int numberOfSold) {
        this.numberOfSold = numberOfSold;
    }

    /**
     * Method hashCode() generates hashCode
     *
     * @return int
     */
    @Override
    public int hashCode() {
        return this.productID + this.productName.hashCode() + this.numberOfSold;
    }

    /**
     * Method equals() compares two SoldProduct-objects
     *
     * @param o
     * @return boolean
     */
    @Override
    public boolean equals(Object o) {
        if (o == null) {
            return false;
        }
        if (o instanceof SoldProduct) {
            final SoldProduct other = (SoldProduct) o;
            return this.hashCode() == other.hashCode() && this.productID == other.productID && this.numberOfSold == other.numberOfSold && this.productName.equals(other.productName);
        } else {
            return false;
        }
    }

    /**
     * Method toString() formats output of SoldProduct
     *
     * @return String
     */
    @Override
    public String toString() {
        return String.format("SoldProduct:%10s — %6d", this.productName, this.numberOfSold);
    }
}
