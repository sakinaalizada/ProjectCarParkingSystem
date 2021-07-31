using System;
using System.Collections.Generic;
using System.ComponentModel;
using Business.Abstract;
using Entities.Concrete;
using System.Windows.Forms;
using Business.IoC.NInjection;

namespace FormUI
{
    public partial class FormEmployee : Form
    {
        private IEmployeeService _employeeService;
        public FormEmployee()
        {
            InitializeComponent();
            _employeeService = InstanceFactory.GetInstance<IEmployeeService>();
        }
        private void LoadData()
        {
            dgwEmployee.DataSource = _employeeService.GetAll();
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnEmployeeAdd_Click(object sender, EventArgs e)
        {
            _employeeService.Add(new Employee
            {
                EmployeeFirstName = tbxEmployeeFirstNameAdd.Text,
                EmployeeLastName = tbxEmployeeLastNameAdd.Text,
                EmployeeSalary = Convert.ToDecimal(tbxEmployeeSalaryAdd.Text),
                ParkingSpaceId = Convert.ToInt32(tbxParkingSpaceIdAdd.Text)
            });
            LoadData();
        }

        private void tbxEmployeeIdSearch_TextChanged(object sender, EventArgs e)
        {
            string text = tbxEmployeeIdSearch.Text;


            if (!String.IsNullOrEmpty(text))
            {
                dgwEmployee.DataSource = _employeeService.GetAll(m => m.EmployeeId.ToString().Contains(text));
            }
            else
            {
                LoadData();
            }
        }

        private void btnEmployeeUpdate_Click(object sender, EventArgs e)
        {
            _employeeService.Update(new Employee
            {
                EmployeeId = Convert.ToInt32(dgwEmployee.CurrentRow.Cells[0].Value.ToString()),
                EmployeeFirstName = tbxEmployeeFirstNameUpdate.Text,
                EmployeeLastName = tbxEmployeeLastNameUpdate.Text,
                EmployeeSalary = Convert.ToDecimal(tbxEmployeeSalaryUpdate.Text),
                ParkingSpaceId = Convert.ToInt32(tbxParkingSpaceIdUpdate.Text)


            });
            LoadData();
        }

        private void dgwEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxEmployeeFirstNameUpdate.Text = dgwEmployee.CurrentRow.Cells[1].Value.ToString();
            tbxEmployeeLastNameUpdate.Text = dgwEmployee.CurrentRow.Cells[2].Value.ToString();
            tbxEmployeeSalaryUpdate.Text = dgwEmployee.CurrentRow.Cells[3].Value.ToString();
            tbxParkingSpaceIdUpdate.Text = dgwEmployee.CurrentRow.Cells[4].Value.ToString();
            tbxEmployeeIdDelete.Text = dgwEmployee.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnEmployeeDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxEmployeeIdDelete.Text))
            {

                _employeeService.Delete(_employeeService.GetById(Convert.ToInt32(tbxEmployeeIdDelete.Text)));

            }
            LoadData();
        }
    }
}
