﻿using CafeNoir.Core;

namespace CafeNoir;

public partial class EmployeeDetailsForm : Form
{
    private readonly CoffeeShop _coffeeShop;
    private readonly Employee _employee;

    public EmployeeDetailsForm(CoffeeShop coffeeShop, Employee employee)
    {
        _coffeeShop = coffeeShop;
        _employee = employee;

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
}
