using CafeNoir.Core;

namespace CafeNoir;

public partial class EmployeeDetailsForm : Form
{
    private readonly CoffeeShop _coffeeShop;
    private readonly Employee _employee;
    private readonly Employee _originalEmployee;

    public EmployeeDetailsForm(CoffeeShop coffeeShop, Employee employee)
    {
        _coffeeShop = coffeeShop;
        _employee = employee;
        _originalEmployee = employee.ShallowCopy();

        InitializeComponent();
    }

    private void EmployeeDetailsForm_Load(object sender, EventArgs e)
    {
        bsEmployee.DataSource = _employee;
        teName.DataBindings.Add("EditValue", bsEmployee, nameof(Employee.Name));
        teSurname.DataBindings.Add("EditValue", bsEmployee, nameof(Employee.Surname));
        cbEmployeeType.DataBindings.Add("EditValue", bsEmployee, nameof(Employee.EmployeeType));
        teSalaryPerMonth.DataBindings.Add("EditValue", bsEmployee, nameof(Employee.SalaryPerMonth));
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        _coffeeShop.SaveChanges();
        DialogResult = DialogResult.OK;
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        _employee.Name = _originalEmployee.Name;
        _employee.Surname = _originalEmployee.Surname;
        _employee.SalaryPerMonth = _originalEmployee.SalaryPerMonth;

        DialogResult = DialogResult.Cancel;
    }
}
