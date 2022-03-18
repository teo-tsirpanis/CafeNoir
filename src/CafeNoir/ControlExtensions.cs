using CafeNoir.Core;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;

namespace CafeNoir;
internal static class ControlExtensions
{
    public static void PopulateProductType(RepositoryItemLookUpEdit lookup)
    {
        var types = new Dictionary<ProductType, string>()
        {
            { ProductType.Coffee, "Coffee" },
            { ProductType.Beverages, "Beverage" },
            { ProductType.Food, "Food" }
        };

        lookup.DataSource = types;
        lookup.Columns.Add(new LookUpColumnInfo("Value"));
        lookup.DisplayMember = "Value";
        lookup.ValueMember = "Key";
        lookup.ShowHeader = false;
    }
}
