
namespace CafeNoir.Core;
public class TransactionHandler {
    private decimal discountPerCent = 0.15m;
    private decimal discountThreshold = 10m;
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
        if (transaction.TransactionLines.Sum(x => x.TotalPrice) > discountThreshold) {
            AddDiscountToLines(transaction);
        }
        else {
            RemoveDiscountFromLines(transaction);
        }
        transaction.TotalPrice = transaction.TransactionLines.Sum(x => x.TotalPrice - x.Discount);
    }
    public void AddDiscountToLines(Transaction transaction){
        foreach (var line in transaction.TransactionLines) {
            if(line.Discount == 0) {
                line.Discount = line.TotalPrice * discountPerCent;
                SetDisplayPrice(line);
            }
        }    
    }
    public void RemoveDiscountFromLines(Transaction transaction) {
        foreach (var line in transaction.TransactionLines) {
            if (line.Discount != 0) {
                line.Discount = 0;
                SetDisplayPrice(line);
            }
        }
    }
    private void SetDisplayPrice(TransactionLine line) {
        line.DisplayPrice = line.TotalPrice - line.Discount;
    }
}
