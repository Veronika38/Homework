import java.util.Date;

/**
 * Class Sale contains sale, trader, product, numberOfSold, dateOfSale
 *
 * @author VERON
 */
public class Sale {

    protected int saleID;
    protected int traderID;
    protected int productID;
    protected int numberOfSold;
    protected Date dateOfSale;

    /**
     * Constructor returns Sale with fields made of given param
     *
     * @param saleID
     * @param traderID
     * @param productID
     * @param numberOfSold
     * @param dateOfSale
     */
    public Sale(int saleID, int traderID, int productID, int numberOfSold, Date dateOfSale) {
        this.saleID = saleID;
        this.traderID = traderID;
        this.productID = productID;
        this.numberOfSold = numberOfSold;
        this.dateOfSale = dateOfSale;
    }

    /**
     * Constructor returns Sale with fields from param, but Date is made
     * within method
     *
     * @param saleID
     * @param traderID
     * @param productID
     * @param numberOfSold
     * @param day
     * @param month
     * @param year
     * @throws IllegalArgumentException
     */
    public Sale(int saleID, int traderID, int productID, int numberOfSold, int day, int month, int year) {
        try {
            this.saleID = saleID;
            this.traderID = traderID;
            this.productID = productID;
            this.numberOfSold = numberOfSold;
            this.dateOfSale = new Date(year, month, day);
        } catch (IllegalArgumentException e) {
            System.out.println("Ошибка создания даты");
        }

    }

    /**
     * Constructor returns copy of another Sale
     *
     * @param other
     */
    public Sale(Sale other) {
        this(other.saleID, other.traderID, other.productID, other.numberOfSold, other.dateOfSale);
    }

    /**
     * Getter for saleID-param
     *
     * @return int
     */
    public int getSaleID() {
        return this.saleID;
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
     * Getter for numberOfSold-param
     *
     * @return int
     */
    public int getNumberOfSold() {
        return this.numberOfSold;
    }

    /**
     * Getter for dateOfSale-param
     *
     * @return Date
     */
    public Date getDateOfSale() {
        return this.dateOfSale;
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
     * Setter for numberOfSold-param
     */
    public void setNumberOfSold(int numberOfSold) {
        this.numberOfSold = numberOfSold;
    }

    /**
     * Setter for dateOfSale-param
     *
     * @param dateOfSale
     */
    public void setDateOfSale(Date dateOfSale) {
        this.dateOfSale = dateOfSale;
    }

    /**
     * Method hashCode() generates hashCode
     *
     * @return int
     */
    @Override
    public int hashCode() {
        return this.saleID + this.traderID + this.productID + (this.numberOfSold + this.dateOfSale.hashCode()) * 19;
    }

    /**
     * Method equals() compares two Sale-objects
     *
     * @param o
     * @return boolean
     */
    @Override
    public boolean equals(Object o) {
        if (o == null) {
            return false;
        }
        if (o instanceof Sale) {
            final Sale other = (Sale) o;
            return this.hashCode() == other.hashCode() && this.saleID == other.saleID && this.traderID == other.traderID && this.productID == other.productID && this.numberOfSold == other.numberOfSold && this.dateOfSale.equals(other.dateOfSale);
        } else {
            return false;
        }
    }

    /**
     * Method toString() formats output of Sale
     *
     * @return String
     */
    @Override
    public String toString() {
        return String.format("Sale: %10d — Trader: %10d — Product: %10d — %10d — %10s", this.saleID, this.traderID, this.productID, this.numberOfSold, this.dateOfSale);
    }
}
