﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorApp
{
    public partial class SalaryCalculatorUI : Form
    {
        EmployeeSalary _anEmployeeSalary=new EmployeeSalary();
        public SalaryCalculatorUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void salaryButton_Click(object sender, EventArgs e)
        {
            _anEmployeeSalary.name = employeenametextBox.Text;
            double salary =_anEmployeeSalary.CalculateSalary();
            MessageBox.Show(_anEmployeeSalary.name+","+"\nYour total salary is : "+salary);
        }
    }
}
