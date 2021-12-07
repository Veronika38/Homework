/**
 * Class TraderHasAvailable contains trader, product, costOfProduct and
 * amountOfProduct
 *
 * @author VERON
 */
public class TraderHasAvailable {

    protected int traderID;
    protected int productID;
    protected int costOfProduct;
    protected int amountOfProduct;

    /**
     * Constructor returns TraderHasAvailable with fields made of given param
     *
     * @param traderID
     * @param productID
     * @param costOfProduct
     * @param amountOfProduct
     */
    public TraderHasAvailable(int traderID, int productID, int costOfProduct, int amountOfProduct) {
        this.traderID = traderID;
        this.productID = productID;
        this.costOfProduct = costOfProduct;
        this.amountOfProduct = amountOfProduct;
    }

    /**
     * Constructor returns copy of another TraderHasAvailable
     *
     * @param other
     */
    public TraderHasAvailable(TraderHasAvailable other) {
        this(other.traderID, other.productID, other.costOfProduct, other.amountOfProduct);
    }

    /**
     * Getter for traderID-param
     *
     * @return int
     */
    public int getTraderID() {
        return this.traderID;
    }

    /**
     * Getter for productID-param
     *
     * @return int
     */
    public int getProductID() {
        return this.productID;
    }

    /**
     * Getter for costOfProduct-param
     *
     * @return int
     */
    public int getCostOfProduct() {
        return this.costOfProduct;
    }

    /**
     * Getter for amountOfProduct-param
     *
     * @return int
     */
    public int getAmountOfProductID() {
        return this.amountOfProduct;
    }

    /**
     * Setter for traderID-param
     *
     * @param traderID
     */
    public void setTraderID(int traderID) {
        this.traderID = traderID;
    }

    /**
     * Setter for productID-param
     *
     * @param productID
     */
    public void setProductID(int productID) {
        this.productID = productID;
    }

    /**
     * Setter for costOfProduct-param
     *
     * @param costOfProduct
     */
    public void setCostOfProduct(int costOfProduct) {
        this.costOfProduct = costOfProduct;
    }

    /**
     * Setter for amountOfProduct-param
     *
     * @param amountOfProduct
     */
    public void setAmountOfProduct(int amountOfProduct) {
        this.amountOfProduct = amountOfProduct;
    }

    /**
     * Method hashCode() generates hashCode
     *
     * @return int
     */
    @Override
    public int hashCode() {
        return this.traderID + this.productID + this.amountOfProduct * 17 + this.costOfProduct * 39;
    }

    /**
     * Method equals() compares two TraderHasAvailable-objects
     *
     * @param o
     * @return boolean
     */
    @Override
    public boolean equals(Object o) {
        if (o == null) {
            return false;
        }
        if (o instanceof TraderHasAvailable) {
            final TraderHasAvailable other = (TraderHasAvailable) o;
            return this.hashCode() == other.hashCode() && this.traderID == other.traderID && this.productID == other.productID && this.costOfProduct == other.costOfProduct && this.amountOfProduct == other.amountOfProduct;
        } else {
            return false;
        }
    }

    /**
     * Method toString() formats output of TraderHasAvailable
     *
     * @return String
     */
    @Override
    public String toString() {
        return String.format("Trader: %10d — Product: %10d — %10d — %10d", this.traderID, this.productID, this.costOfProduct, this.amountOfProduct);
    }
}
