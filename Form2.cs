using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mawanay_IT201NS_Lesson5Activity
{
    public partial class frmPayslipReport : Form
    {
        public frmPayslipReport()
        {
            InitializeComponent();
        }

        // Constructor for receiving data from Form1
        public frmPayslipReport(
            string fullName,
            string empNo,
            string dept,
            string payDate,

            // Earnings
            string basicRateHour,
            string basicIncome,
            string honRateHour,
            string honIncome,

            // Deductions
            string sss,
            string philHealth,
            string pagIbig,
            string tax,

            // Summary
            string gross,
            string totalDeduction,
            string net
        )
        {
            InitializeComponent();

            // EMPLOYEE INFO
            lblReportEmployeeName.Text = fullName;
            lblReportEmployeeCode.Text = empNo;
            lblReportDepartment.Text = dept;
            lblReportCutOff.Text = payDate;

            // EARNINGS
            txtBasicRateHour.Text = basicRateHour;
            txtTotalBasicPay.Text = basicIncome;
            txtHonorariumRateHour.Text = honRateHour;
            txtTotalHonorariumRateHour.Text = honIncome;
            textTotalEarnings.Text = gross; // Total Earnings is the same as Gross Income

            // DEDUCTIONS
            lblSSSVal.Text = sss;
            lblPhilHealthVal.Text = philHealth;
            lblValHDMF.Text = pagIbig;
            lblTaxVal.Text = tax;
            txtTotalDedutions.Text = totalDeduction;

            // SUMMARY
            lblValGross.Text = gross;
            lblTotalDeductionsVal.Text = totalDeduction;
            lblValNetPay.Text = net;
        }
    }
}