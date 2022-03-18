using CafeNoir.Core;
namespace CafeNoir;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        
         ApplicationConfiguration.Initialize();
         Application.Run(new CoffeeShopForm());

        var tHandler = new TransactionHandler();

        var trans = new Transaction() {
            ID = new Guid(),
            CustomerID = new Guid(),
            EmployeeID = new Guid(),

        };

        TransactionLine transLine1 = new TransactionLine() {
            ID = new Guid(),
            ProductID = new Guid(),
            Quantity = 1,
            TotalPrice = 2,
            TransactionID = trans.ID
        };


        TransactionLine transLine2 = new TransactionLine() {
            ID = new Guid(),
            ProductID = new Guid(),
            Quantity = 3,
            TotalPrice = 3,
            TransactionID = trans.ID
        };

        tHandler.AddTransLine(trans, transLine1);
        tHandler.AddTransLine(trans, transLine2);

        tHandler.CalcTotal(trans);

    }
}
