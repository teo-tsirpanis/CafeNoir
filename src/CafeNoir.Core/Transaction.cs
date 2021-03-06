
namespace CafeNoir.Core;
public class Transaction {
    public Guid ID { get; set;  }
    public DateTime Date { get; set; }
    public Guid EmployeeID { get; set; }
    public Guid CustomerID { get; set; }
    public List<TransactionLine> TransactionLines { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
    public decimal TotalPrice { get; set; }
    public decimal TotalCost { get; set; }
    public string EmployeeName { get; set; }
    public Transaction() {
        ID = Guid.NewGuid();
        TransactionLines = new List<TransactionLine>();
    }
    public Transaction(Guid employeeID, Guid customerID) {
        ID = Guid.NewGuid();
        EmployeeID = employeeID;
        CustomerID = customerID;
       

    }

}
