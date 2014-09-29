using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmploySalaryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Employee anEmployee=new Employee();
        private void showMeSalaryButton_Click(object sender, EventArgs e)
        {
            anEmployee.name = employeeNameTextBox.Text;
            anEmployee.salary = Convert.ToDouble(basicAmountTextBox.Text);
            anEmployee.houseRent = Convert.ToDouble(houseRentTextBox.Text);
            anEmployee.medicalAlloance = Convert.ToDouble(medicalAllowanceTextBox.Text);
            double total = anEmployee.GetTotal();
            MessageBox.Show("your Name is" + anEmployee.name   + " " + "totalsalary is"+ anEmployee.GetTotal());
        }
    }
}
