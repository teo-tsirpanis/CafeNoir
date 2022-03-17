
using CafeNoir.Core;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;

namespace CafeNoir;
internal class ControlsHelper {
    public void PopulateProductType(RepositoryItemLookUpEdit lookup) {
        Dictionary<ProductType, string> types = new Dictionary<ProductType, string>();
        types.Add(ProductType.Coffee, "Coofee");
        types.Add(ProductType.Beverages, "Beverage");
        types.Add(ProductType.Food, "Food");

        lookup.DataSource = types;
        lookup.Columns.Add(new LookUpColumnInfo("Value"));
        lookup.DisplayMember = "Value";
        lookup.ValueMember = "Key";
        lookup.ShowHeader = false;
    }

}
