using CafeNoir.Core;

namespace CafeNoir;

public partial class EmployeeDetailsForm : Form
{
    private  CoffeeShop _coffeeShop;
    private  Employee _employee;
    private Employee _originalEmp;
    private bool editEmp = false;
    

    public EmployeeDetailsForm(CoffeeShop coffeeShop, Employee employee, bool edit)
    {
        _coffeeShop = coffeeShop;
        _employee = employee;
        _originalEmp = employee.ShallowCopy();
        editEmp = edit;
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

    private void simpleButtonClose_Click(object sender, EventArgs e) {
        
        if(editEmp == true) {
            _employee.Name = _originalEmp.Name;
            _employee.Surname = _originalEmp.Surname;
            _employee.SalaryPerMonth = _originalEmp.SalaryPerMonth;
            _employee.EmployeeType = _originalEmp.EmployeeType;
        }
        else {
            //int len = _coffeeShop.Employees.Count() - 1;
            _coffeeShop.Employees.Remove(_employee);
        }
        
        Close();
    }
}
