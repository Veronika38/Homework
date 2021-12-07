/**
 * Class Product contains ID and Name
 *
 * @author VERON
 */
public class Product {

    protected int productID;
    protected String productName;

    /**
     * Constructor returns Product with fields made of given param
     *
     * @param productID
     * @param productName
     */
    public Product(int productID, String productName) {
        this.productID = productID;
        this.productName = productName;
    }

    /**
     * Constructor returns copy of another Product
     *
     * @param other
     */
    public Product(Product other) {
        this(other.productID, other.productName);
    }

    /**
     * Getter for ID-param
     *
     * @return int
     */
    public int getProductID() {
        return this.productID;
    }

    /**
     * Getter for Name-param
     *
     * @return String
     */
    public String getProductName() {
        return this.productName;
    }

    /**
     * Setter for ID-param
     *
     * @param productID
     */
    public void setProductID(int productID) {
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
     * Method hashCode() generates hashCode
     *
     * @return int
     */
    @Override
    public int hashCode() {
        return this.productID + this.productName.hashCode();
    }

    /**
     * Method equals() compares two Product-objects
     *
     * @param o
     * @return boolean
     */
    @Override
    public boolean equals(Object o) {
        if (o == null) {
            return false;
        }
        if (o instanceof Product) {
            final Product other = (Product) o;
            return this.hashCode() == other.hashCode() && this.productID == other.productID && this.productName.equals(other.productName);
        } else {
            return false;
        }
    }

    /**
     * Method toString() formats output of Product
     *
     * @return String
     */
    @Override
    public String toString() {
        return String.format("Product:%10d — %15s", this.productID, this.productName);
    }
}
