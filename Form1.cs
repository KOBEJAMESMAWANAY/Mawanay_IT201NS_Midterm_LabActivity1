using System;
using System.Windows.Forms;

namespace Mawanay_IT201NS_Lesson5Activity
{
    public partial class frmMainPayroll : Form
    {
        public frmMainPayroll()
        {
            InitializeComponent();
        }

        private decimal GetDecimal(string text)
        {
            if (decimal.TryParse(text, out decimal result))
                return result;
            return 0m;
        }

        // PHILHEALTH COMPUTATION (Based on Image 7)
        private decimal ComputePhilHealth(decimal basicSalary)
        {
            // Premium rate is 5%. Employee share is half of that (2.5%).
            decimal employeeShare = 0m;

            if (basicSalary <= 10000m)
            {
                employeeShare = 500m / 2m; // 250
            }
            else if (basicSalary >= 100000m)
            {
                employeeShare = 5000m / 2m; // 2500
            }
            else
            {
                decimal totalPremium = basicSalary * 0.05m;
                employeeShare = totalPremium / 2m;
            }
            return employeeShare;
        }

        // SSS COMPUTATION (Based on Table Conversion Image)
        private decimal ComputeSSS(decimal grossIncome)
        {
            // Instead of 40+ if-else statements, we can use a math algorithm 
            // that matches the logic of the SSS bracket table.
            if (grossIncome < 5250m) return 250m;
            if (grossIncome >= 34750m) return 1750m;

            // For every 500 increase above 5250, the deduction increases by 25
            decimal steps = Math.Floor((grossIncome - 5250m) / 500m);
            return 275m + (steps * 25m);
        }

        // INCOME TAX COMPUTATION (Based on Train Law Image)
        private decimal ComputeIncomeTax(decimal taxableIncome)
        {
            if (taxableIncome <= 250000m)
                return 0m;
            else if (taxableIncome > 250000m && taxableIncome <= 400000m)
                return (taxableIncome - 250000m) * 0.15m;
            else if (taxableIncome > 400000m && taxableIncome <= 800000m)
                return 22500m + ((taxableIncome - 400000m) * 0.20m);
            else if (taxableIncome > 800000m && taxableIncome <= 2000000m)
                return 102500m + ((taxableIncome - 800000m) * 0.25m);
            else if (taxableIncome > 2000000m && taxableIncome <= 8000000m)
                return 402500m + ((taxableIncome - 2000000m) * 0.30m);
            else
                return 2202500m + ((taxableIncome - 8000000m) * 0.35m);
        }

        private void btnGrossIncome_Click(object sender, System.EventArgs e)
        {
            // 1. Calculate Incomes
            decimal basicIncome = GetDecimal(txtBasicRateHour.Text) * GetDecimal(txtBasicHoursCutOff.Text);
            decimal honIncome = GetDecimal(txtHonRateHour.Text) * GetDecimal(txtHonHoursCutOff.Text);
            decimal otherIncome = GetDecimal(txtOtherRateHour.Text) * GetDecimal(txtOtherHoursCutOff.Text);

            decimal grossIncome = basicIncome + honIncome + otherIncome;

            // Update Income TextBoxes (Formatted to 2 decimal places)
            txtCalcBasicIncome.Text = basicIncome.ToString("N2");
            txtCalcHonIncome.Text = honIncome.ToString("N2");
            txtCalcOtherIncome.Text = otherIncome.ToString("N2");
            txtSummaryGross.Text = grossIncome.ToString("N2");

            // 2. Calculate Regular Deductions
            // Assuming Pag-IBIG is a fixed 200 based on the assignment instructions
            decimal pagIbig = 200m;
            decimal sss = ComputeSSS(grossIncome);
            // PhilHealth is usually based on Basic Salary, not Gross
            decimal philHealth = ComputePhilHealth(basicIncome);
            decimal tax = ComputeIncomeTax(grossIncome);

            // Update Deduction TextBoxes
            txtCalcPagibig.Text = pagIbig.ToString("N2");
            txtCalcSSS.Text = sss.ToString("N2");
            txtCalcPhilHealth.Text = philHealth.ToString("N2");
            txtCalcIncomeTax.Text = tax.ToString("N2");
        }

        private void btnNetIncome_Click(object sender, System.EventArgs e)
        {
            // Make sure Gross Income is calculated first
            decimal grossIncome = GetDecimal(txtSummaryGross.Text);

            // Sum up Regular Deductions
            decimal regDeductions = GetDecimal(txtCalcSSS.Text) +
                                    GetDecimal(txtCalcPhilHealth.Text) +
                                    GetDecimal(txtCalcPagibig.Text) +
                                    GetDecimal(txtCalcIncomeTax.Text);

            // Sum up Other Deductions
            decimal otherDeductions = GetDecimal(txtOtherSSSLoan.Text) +
                                      GetDecimal(txtOtherPagibigLoan.Text) +
                                      GetDecimal(txtOtherFacultyDeposit.Text) +
                                      GetDecimal(txtOtherFacultyLoan.Text) +
                                      GetDecimal(txtOtherSalaryLoan.Text) +
                                      GetDecimal(txtOtherGeneralLoan.Text);

            decimal totalDeductions = regDeductions + otherDeductions;
            decimal netIncome = grossIncome - totalDeductions;

            // Update UI
            txtSummaryTotalDeduction.Text = totalDeductions.ToString("N2");
            txtSummaryNet.Text = netIncome.ToString("N2");
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            // Combine names for the report
            string fullName = txtFirstName.Text + " " + txtSurname.Text;

            frmPayslipReport slip = new frmPayslipReport(
                fullName,
                //Employee details
                txtEmployeeNumber.Text,
                txtDepartment.Text,
                txtPaydate.Text,

                //Earnings
                txtBasicHoursCutOff.Text,
                txtCalcBasicIncome.Text,
                txtHonHoursCutOff.Text,
                txtCalcHonIncome.Text,

                //Deductions
                txtCalcSSS.Text,
                txtCalcPhilHealth.Text,
                txtCalcPagibig.Text,
                txtCalcIncomeTax.Text,

                // Summary
                txtSummaryGross.Text,
                txtSummaryTotalDeduction.Text,
                txtSummaryNet.Text
            );

            slip.ShowDialog();
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {

        }

        private void btnNew_Click(object sender, System.EventArgs e)
        {
            // Loop through all controls and clear textboxes
            foreach (Control c in this.Controls)
            {
                if (c is TextBox) ((TextBox)c).Clear();
                // If you used GroupBoxes, you need to loop through them too
                if (c is GroupBox)
                {
                    foreach (Control inner in c.Controls)
                    {
                        if (inner is TextBox) ((TextBox)inner).Clear();
                    }
                }
            }

            // Reset fixed Pag-IBIG just in case
            txtCalcPagibig.Text = "200.00";
        }
    }
}
