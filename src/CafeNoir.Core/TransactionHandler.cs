
namespace CafeNoir.Core;
public class TransactionHandler {
    private decimal discountPerCent = 0.15m;

    public TransactionHandler() {

    }

    public void CalcTotal(Transaction transaction) {
        transaction.TotalPrice = transaction.TransactionLines.Sum(x => x.TotalPrice);

        if (transaction.TotalPrice > 10m) {
            transaction.TotalPrice *= (1.0m - discountPerCent);
        }
    }

    public void AddTransLine(Transaction trans, TransactionLine transLine) {
        trans.TransactionLines.Add(transLine);
    }

    public void CalcTotalCosts(TransactionLine transactionLine, decimal cost) {
        transactionLine.TotalCost = transactionLine.Quantity * cost;
    }

    public void UpdateTotalCost(Transaction transaction) {
        transaction.TotalCost = transaction.TransactionLines.Sum(x => x.TotalCost);
    }
    public void UpdateTotalPrice(Transaction transaction) {
        transaction.TotalPrice = transaction.TransactionLines.Sum(x => x.TotalPrice);
        if (transaction.TotalPrice > 10m) {
            transaction.TotalPrice *= (1.0m - discountPerCent);
        }
    }
}
