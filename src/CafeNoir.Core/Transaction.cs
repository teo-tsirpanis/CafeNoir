
namespace CafeNoir.Core;
public class Transaction {
    public Guid ID { get; }
    public DateTime Date { get; set; }
    public Guid EmployeeID { get; set; }
    public Guid CustomerID { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
    public decimal TotalPrice { get; set; }

    public Transaction() {
        ID = Guid.NewGuid();
    }
    public Transaction(Guid employeeID, Guid customerID) {
        ID = Guid.NewGuid();
        EmployeeID = employeeID;
        CustomerID = customerID;
    }
}
