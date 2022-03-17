
namespace CafeNoir.Core;
public class TransactionLine {
    public Guid ID { get; set; }
    public Guid ProductID { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public decimal DiscountPerCent { get; set; }
    public decimal TotalPrice { get; set; }

    public TransactionLine() {
        ID = Guid.NewGuid();
    }
    public TransactionLine(Guid productID) : this() {
        ProductID = productID;
    }
    public TransactionLine(Guid productID, int quantity, decimal price, decimal discountPerCent) : this() {
        ProductID = productID;
        Quantity = quantity;
        Price = price;
        DiscountPerCent = discountPerCent;
        TotalPrice = (Quantity * Price) - (Quantity * Price)*discountPerCent;
    }
    public TransactionLine(Guid productID, int quantity, decimal price, decimal discountPerCent, decimal totalPrice) : this() {
        ProductID = productID;
        Quantity = quantity;
        Price = price;
        DiscountPerCent = discountPerCent;
        TotalPrice = totalPrice;
    }
}
