namespace Mawanay_IT201NS_Lesson5Activity
{
    partial class frmMainPayroll
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.picEmployeePhoto = new System.Windows.Forms.PictureBox();
            this.lblMainHeader = new System.Windows.Forms.Label();
            this.lblEmployeeNumber = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblBasicIncomeHeader = new System.Windows.Forms.Label();
            this.lblBasicRateHour = new System.Windows.Forms.Label();
            this.lblBasicHoursCutOff = new System.Windows.Forms.Label();
            this.lblBasicIncomeCutOff = new System.Windows.Forms.Label();
            this.lblHonIncomeHeader = new System.Windows.Forms.Label();
            this.lblHonRateHour = new System.Windows.Forms.Label();
            this.lblHonHoursCutOff = new System.Windows.Forms.Label();
            this.lblHonIncomeCutOff = new System.Windows.Forms.Label();
            this.lblOtherIncomeHeader = new System.Windows.Forms.Label();
            this.lblOtherRateHour = new System.Windows.Forms.Label();
            this.lblOtherHoursCutOff = new System.Windows.Forms.Label();
            this.lblOtherIncomeCutOff = new System.Windows.Forms.Label();
            this.lblSummaryIncomeHeader = new System.Windows.Forms.Label();
            this.lblSummaryGross = new System.Windows.Forms.Label();
            this.lblSummaryNet = new System.Windows.Forms.Label();
            this.txtEmployeeNumber = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtBasicRateHour = new System.Windows.Forms.TextBox();
            this.txtBasicHoursCutOff = new System.Windows.Forms.TextBox();
            this.txtCalcBasicIncome = new System.Windows.Forms.TextBox();
            this.txtCalcHonIncome = new System.Windows.Forms.TextBox();
            this.txtHonHoursCutOff = new System.Windows.Forms.TextBox();
            this.txtHonRateHour = new System.Windows.Forms.TextBox();
            this.txtCalcOtherIncome = new System.Windows.Forms.TextBox();
            this.txtOtherHoursCutOff = new System.Windows.Forms.TextBox();
            this.txtOtherRateHour = new System.Windows.Forms.TextBox();
            this.txtSummaryNet = new System.Windows.Forms.TextBox();
            this.txtSummaryGross = new System.Windows.Forms.TextBox();
            this.txtOtherFacultyDeposit = new System.Windows.Forms.TextBox();
            this.txtOtherPagibigLoan = new System.Windows.Forms.TextBox();
            this.txtOtherSSSLoan = new System.Windows.Forms.TextBox();
            this.txtCalcPagibig = new System.Windows.Forms.TextBox();
            this.txtCalcPhilHealth = new System.Windows.Forms.TextBox();
            this.txtCalcSSS = new System.Windows.Forms.TextBox();
            this.lblFacultySavingsDeposit = new System.Windows.Forms.Label();
            this.lblPagibigLoan = new System.Windows.Forms.Label();
            this.lblSSSLoan = new System.Windows.Forms.Label();
            this.lblOtherDeductionHeader = new System.Windows.Forms.Label();
            this.lblPagibigContribution = new System.Windows.Forms.Label();
            this.lblPhilHealthContribution = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblRegDeductionHeader = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtCivilStatus = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblCivilStatus = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtPaydate = new System.Windows.Forms.TextBox();
            this.txtQualifiedDependentStatus = new System.Windows.Forms.TextBox();
            this.lblPaydate = new System.Windows.Forms.Label();
            this.lblQualifiedDependentStatus = new System.Windows.Forms.Label();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.txtEmployeeStatus = new System.Windows.Forms.TextBox();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblEmployeeStatus = new System.Windows.Forms.Label();
            this.btnGrossIncome = new System.Windows.Forms.Button();
            this.btnNetIncome = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtCalcIncomeTax = new System.Windows.Forms.TextBox();
            this.lblIncomeTaxContribution = new System.Windows.Forms.Label();
            this.txtOtherGeneralLoan = new System.Windows.Forms.TextBox();
            this.txtOtherSalaryLoan = new System.Windows.Forms.TextBox();
            this.txtOtherFacultyLoan = new System.Windows.Forms.TextBox();
            this.lblOtherLoans = new System.Windows.Forms.Label();
            this.lblSalaryLoan = new System.Windows.Forms.Label();
            this.lblFacultySavingsLoan = new System.Windows.Forms.Label();
            this.txtSummaryTotalDeduction = new System.Windows.Forms.TextBox();
            this.lblSummaryTotalDeduction = new System.Windows.Forms.Label();
            this.lblDeductionSummaryHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployeePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Basic Info";
            // 
            // picEmployeePhoto
            // 
            this.picEmployeePhoto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picEmployeePhoto.Location = new System.Drawing.Point(15, 66);
            this.picEmployeePhoto.Name = "picEmployeePhoto";
            this.picEmployeePhoto.Size = new System.Drawing.Size(119, 99);
            this.picEmployeePhoto.TabIndex = 1;
            this.picEmployeePhoto.TabStop = false;
            // 
            // lblMainHeader
            // 
            this.lblMainHeader.AutoSize = true;
            this.lblMainHeader.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainHeader.Location = new System.Drawing.Point(212, 9);
            this.lblMainHeader.Name = "lblMainHeader";
            this.lblMainHeader.Size = new System.Drawing.Size(302, 26);
            this.lblMainHeader.TabIndex = 2;
            this.lblMainHeader.Text = "SE\'RI\'S CHOICE PAYROLL";
            this.lblMainHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmployeeNumber
            // 
            this.lblEmployeeNumber.AutoSize = true;
            this.lblEmployeeNumber.Location = new System.Drawing.Point(12, 182);
            this.lblEmployeeNumber.Name = "lblEmployeeNumber";
            this.lblEmployeeNumber.Size = new System.Drawing.Size(96, 13);
            this.lblEmployeeNumber.TabIndex = 3;
            this.lblEmployeeNumber.Text = "Employee Number:";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(12, 208);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(65, 13);
            this.lblDepartment.TabIndex = 4;
            this.lblDepartment.Text = "Department:";
            // 
            // lblBasicIncomeHeader
            // 
            this.lblBasicIncomeHeader.AutoSize = true;
            this.lblBasicIncomeHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasicIncomeHeader.Location = new System.Drawing.Point(12, 265);
            this.lblBasicIncomeHeader.Name = "lblBasicIncomeHeader";
            this.lblBasicIncomeHeader.Size = new System.Drawing.Size(99, 13);
            this.lblBasicIncomeHeader.TabIndex = 5;
            this.lblBasicIncomeHeader.Text = "BASIC INCOME:";
            // 
            // lblBasicRateHour
            // 
            this.lblBasicRateHour.AutoSize = true;
            this.lblBasicRateHour.Location = new System.Drawing.Point(31, 287);
            this.lblBasicRateHour.Name = "lblBasicRateHour";
            this.lblBasicRateHour.Size = new System.Drawing.Size(67, 13);
            this.lblBasicRateHour.TabIndex = 6;
            this.lblBasicRateHour.Text = "Rate / Hour:";
            // 
            // lblBasicHoursCutOff
            // 
            this.lblBasicHoursCutOff.AutoSize = true;
            this.lblBasicHoursCutOff.Location = new System.Drawing.Point(31, 313);
            this.lblBasicHoursCutOff.Name = "lblBasicHoursCutOff";
            this.lblBasicHoursCutOff.Size = new System.Drawing.Size(114, 13);
            this.lblBasicHoursCutOff.TabIndex = 7;
            this.lblBasicHoursCutOff.Text = "No. of Hours / Cut Off:";
            // 
            // lblBasicIncomeCutOff
            // 
            this.lblBasicIncomeCutOff.AutoSize = true;
            this.lblBasicIncomeCutOff.Location = new System.Drawing.Point(31, 339);
            this.lblBasicIncomeCutOff.Name = "lblBasicIncomeCutOff";
            this.lblBasicIncomeCutOff.Size = new System.Drawing.Size(89, 13);
            this.lblBasicIncomeCutOff.TabIndex = 8;
            this.lblBasicIncomeCutOff.Text = "Income / Cut Off:";
            // 
            // lblHonIncomeHeader
            // 
            this.lblHonIncomeHeader.AutoSize = true;
            this.lblHonIncomeHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHonIncomeHeader.Location = new System.Drawing.Point(12, 365);
            this.lblHonIncomeHeader.Name = "lblHonIncomeHeader";
            this.lblHonIncomeHeader.Size = new System.Drawing.Size(148, 13);
            this.lblHonIncomeHeader.TabIndex = 9;
            this.lblHonIncomeHeader.Text = "HONORARIUM INCOME:";
            // 
            // lblHonRateHour
            // 
            this.lblHonRateHour.AutoSize = true;
            this.lblHonRateHour.Location = new System.Drawing.Point(31, 387);
            this.lblHonRateHour.Name = "lblHonRateHour";
            this.lblHonRateHour.Size = new System.Drawing.Size(67, 13);
            this.lblHonRateHour.TabIndex = 10;
            this.lblHonRateHour.Text = "Rate / Hour:";
            // 
            // lblHonHoursCutOff
            // 
            this.lblHonHoursCutOff.AutoSize = true;
            this.lblHonHoursCutOff.Location = new System.Drawing.Point(31, 413);
            this.lblHonHoursCutOff.Name = "lblHonHoursCutOff";
            this.lblHonHoursCutOff.Size = new System.Drawing.Size(114, 13);
            this.lblHonHoursCutOff.TabIndex = 11;
            this.lblHonHoursCutOff.Tag = "";
            this.lblHonHoursCutOff.Text = "No. of Hours / Cut Off:";
            // 
            // lblHonIncomeCutOff
            // 
            this.lblHonIncomeCutOff.AutoSize = true;
            this.lblHonIncomeCutOff.Location = new System.Drawing.Point(31, 439);
            this.lblHonIncomeCutOff.Name = "lblHonIncomeCutOff";
            this.lblHonIncomeCutOff.Size = new System.Drawing.Size(89, 13);
            this.lblHonIncomeCutOff.TabIndex = 12;
            this.lblHonIncomeCutOff.Text = "Income / Cut Off:";
            // 
            // lblOtherIncomeHeader
            // 
            this.lblOtherIncomeHeader.AutoSize = true;
            this.lblOtherIncomeHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherIncomeHeader.Location = new System.Drawing.Point(12, 464);
            this.lblOtherIncomeHeader.Name = "lblOtherIncomeHeader";
            this.lblOtherIncomeHeader.Size = new System.Drawing.Size(106, 13);
            this.lblOtherIncomeHeader.TabIndex = 13;
            this.lblOtherIncomeHeader.Text = "OTHER INCOME:";
            // 
            // lblOtherRateHour
            // 
            this.lblOtherRateHour.AutoSize = true;
            this.lblOtherRateHour.Location = new System.Drawing.Point(31, 494);
            this.lblOtherRateHour.Name = "lblOtherRateHour";
            this.lblOtherRateHour.Size = new System.Drawing.Size(67, 13);
            this.lblOtherRateHour.TabIndex = 14;
            this.lblOtherRateHour.Text = "Rate / Hour:";
            // 
            // lblOtherHoursCutOff
            // 
            this.lblOtherHoursCutOff.AutoSize = true;
            this.lblOtherHoursCutOff.Location = new System.Drawing.Point(31, 520);
            this.lblOtherHoursCutOff.Name = "lblOtherHoursCutOff";
            this.lblOtherHoursCutOff.Size = new System.Drawing.Size(114, 13);
            this.lblOtherHoursCutOff.TabIndex = 15;
            this.lblOtherHoursCutOff.Text = "No. of Hours / Cut Off:";
            // 
            // lblOtherIncomeCutOff
            // 
            this.lblOtherIncomeCutOff.AutoSize = true;
            this.lblOtherIncomeCutOff.Location = new System.Drawing.Point(31, 546);
            this.lblOtherIncomeCutOff.Name = "lblOtherIncomeCutOff";
            this.lblOtherIncomeCutOff.Size = new System.Drawing.Size(89, 13);
            this.lblOtherIncomeCutOff.TabIndex = 16;
            this.lblOtherIncomeCutOff.Text = "Income / Cut Off:";
            // 
            // lblSummaryIncomeHeader
            // 
            this.lblSummaryIncomeHeader.AutoSize = true;
            this.lblSummaryIncomeHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummaryIncomeHeader.Location = new System.Drawing.Point(12, 577);
            this.lblSummaryIncomeHeader.Name = "lblSummaryIncomeHeader";
            this.lblSummaryIncomeHeader.Size = new System.Drawing.Size(125, 13);
            this.lblSummaryIncomeHeader.TabIndex = 17;
            this.lblSummaryIncomeHeader.Text = "SUMMARY INCOME:";
            // 
            // lblSummaryGross
            // 
            this.lblSummaryGross.AutoSize = true;
            this.lblSummaryGross.Location = new System.Drawing.Point(31, 602);
            this.lblSummaryGross.Name = "lblSummaryGross";
            this.lblSummaryGross.Size = new System.Drawing.Size(93, 13);
            this.lblSummaryGross.TabIndex = 18;
            this.lblSummaryGross.Text = "GROSS INCOME:";
            // 
            // lblSummaryNet
            // 
            this.lblSummaryNet.AutoSize = true;
            this.lblSummaryNet.Location = new System.Drawing.Point(31, 628);
            this.lblSummaryNet.Name = "lblSummaryNet";
            this.lblSummaryNet.Size = new System.Drawing.Size(77, 13);
            this.lblSummaryNet.TabIndex = 19;
            this.lblSummaryNet.Text = "NET INCOME:";
            // 
            // txtEmployeeNumber
            // 
            this.txtEmployeeNumber.Location = new System.Drawing.Point(146, 179);
            this.txtEmployeeNumber.Name = "txtEmployeeNumber";
            this.txtEmployeeNumber.Size = new System.Drawing.Size(182, 20);
            this.txtEmployeeNumber.TabIndex = 20;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(146, 205);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(182, 20);
            this.txtDepartment.TabIndex = 21;
            // 
            // txtBasicRateHour
            // 
            this.txtBasicRateHour.Location = new System.Drawing.Point(146, 284);
            this.txtBasicRateHour.Name = "txtBasicRateHour";
            this.txtBasicRateHour.Size = new System.Drawing.Size(182, 20);
            this.txtBasicRateHour.TabIndex = 22;
            // 
            // txtBasicHoursCutOff
            // 
            this.txtBasicHoursCutOff.Location = new System.Drawing.Point(146, 310);
            this.txtBasicHoursCutOff.Name = "txtBasicHoursCutOff";
            this.txtBasicHoursCutOff.Size = new System.Drawing.Size(182, 20);
            this.txtBasicHoursCutOff.TabIndex = 23;
            // 
            // txtCalcBasicIncome
            // 
            this.txtCalcBasicIncome.Location = new System.Drawing.Point(146, 336);
            this.txtCalcBasicIncome.Name = "txtCalcBasicIncome";
            this.txtCalcBasicIncome.ReadOnly = true;
            this.txtCalcBasicIncome.Size = new System.Drawing.Size(182, 20);
            this.txtCalcBasicIncome.TabIndex = 24;
            // 
            // txtCalcHonIncome
            // 
            this.txtCalcHonIncome.Location = new System.Drawing.Point(146, 436);
            this.txtCalcHonIncome.Name = "txtCalcHonIncome";
            this.txtCalcHonIncome.ReadOnly = true;
            this.txtCalcHonIncome.Size = new System.Drawing.Size(182, 20);
            this.txtCalcHonIncome.TabIndex = 27;
            // 
            // txtHonHoursCutOff
            // 
            this.txtHonHoursCutOff.Location = new System.Drawing.Point(146, 410);
            this.txtHonHoursCutOff.Name = "txtHonHoursCutOff";
            this.txtHonHoursCutOff.Size = new System.Drawing.Size(182, 20);
            this.txtHonHoursCutOff.TabIndex = 26;
            // 
            // txtHonRateHour
            // 
            this.txtHonRateHour.Location = new System.Drawing.Point(146, 384);
            this.txtHonRateHour.Name = "txtHonRateHour";
            this.txtHonRateHour.Size = new System.Drawing.Size(182, 20);
            this.txtHonRateHour.TabIndex = 25;
            // 
            // txtCalcOtherIncome
            // 
            this.txtCalcOtherIncome.Location = new System.Drawing.Point(146, 543);
            this.txtCalcOtherIncome.Name = "txtCalcOtherIncome";
            this.txtCalcOtherIncome.ReadOnly = true;
            this.txtCalcOtherIncome.Size = new System.Drawing.Size(182, 20);
            this.txtCalcOtherIncome.TabIndex = 30;
            // 
            // txtOtherHoursCutOff
            // 
            this.txtOtherHoursCutOff.Location = new System.Drawing.Point(146, 517);
            this.txtOtherHoursCutOff.Name = "txtOtherHoursCutOff";
            this.txtOtherHoursCutOff.Size = new System.Drawing.Size(182, 20);
            this.txtOtherHoursCutOff.TabIndex = 29;
            // 
            // txtOtherRateHour
            // 
            this.txtOtherRateHour.Location = new System.Drawing.Point(146, 491);
            this.txtOtherRateHour.Name = "txtOtherRateHour";
            this.txtOtherRateHour.Size = new System.Drawing.Size(182, 20);
            this.txtOtherRateHour.TabIndex = 28;
            // 
            // txtSummaryNet
            // 
            this.txtSummaryNet.Location = new System.Drawing.Point(146, 625);
            this.txtSummaryNet.Name = "txtSummaryNet";
            this.txtSummaryNet.ReadOnly = true;
            this.txtSummaryNet.Size = new System.Drawing.Size(182, 20);
            this.txtSummaryNet.TabIndex = 32;
            // 
            // txtSummaryGross
            // 
            this.txtSummaryGross.Location = new System.Drawing.Point(146, 599);
            this.txtSummaryGross.Name = "txtSummaryGross";
            this.txtSummaryGross.ReadOnly = true;
            this.txtSummaryGross.Size = new System.Drawing.Size(182, 20);
            this.txtSummaryGross.TabIndex = 31;
            // 
            // txtOtherFacultyDeposit
            // 
            this.txtOtherFacultyDeposit.Location = new System.Drawing.Point(492, 466);
            this.txtOtherFacultyDeposit.Name = "txtOtherFacultyDeposit";
            this.txtOtherFacultyDeposit.Size = new System.Drawing.Size(191, 20);
            this.txtOtherFacultyDeposit.TabIndex = 46;
            // 
            // txtOtherPagibigLoan
            // 
            this.txtOtherPagibigLoan.Location = new System.Drawing.Point(492, 440);
            this.txtOtherPagibigLoan.Name = "txtOtherPagibigLoan";
            this.txtOtherPagibigLoan.Size = new System.Drawing.Size(191, 20);
            this.txtOtherPagibigLoan.TabIndex = 45;
            // 
            // txtOtherSSSLoan
            // 
            this.txtOtherSSSLoan.Location = new System.Drawing.Point(492, 414);
            this.txtOtherSSSLoan.Name = "txtOtherSSSLoan";
            this.txtOtherSSSLoan.Size = new System.Drawing.Size(191, 20);
            this.txtOtherSSSLoan.TabIndex = 44;
            // 
            // txtCalcPagibig
            // 
            this.txtCalcPagibig.Location = new System.Drawing.Point(492, 342);
            this.txtCalcPagibig.Name = "txtCalcPagibig";
            this.txtCalcPagibig.ReadOnly = true;
            this.txtCalcPagibig.Size = new System.Drawing.Size(191, 20);
            this.txtCalcPagibig.TabIndex = 43;
            // 
            // txtCalcPhilHealth
            // 
            this.txtCalcPhilHealth.Location = new System.Drawing.Point(492, 316);
            this.txtCalcPhilHealth.Name = "txtCalcPhilHealth";
            this.txtCalcPhilHealth.ReadOnly = true;
            this.txtCalcPhilHealth.Size = new System.Drawing.Size(191, 20);
            this.txtCalcPhilHealth.TabIndex = 42;
            // 
            // txtCalcSSS
            // 
            this.txtCalcSSS.Location = new System.Drawing.Point(492, 290);
            this.txtCalcSSS.Name = "txtCalcSSS";
            this.txtCalcSSS.ReadOnly = true;
            this.txtCalcSSS.Size = new System.Drawing.Size(191, 20);
            this.txtCalcSSS.TabIndex = 41;
            // 
            // lblFacultySavingsDeposit
            // 
            this.lblFacultySavingsDeposit.AutoSize = true;
            this.lblFacultySavingsDeposit.Location = new System.Drawing.Point(364, 469);
            this.lblFacultySavingsDeposit.Name = "lblFacultySavingsDeposit";
            this.lblFacultySavingsDeposit.Size = new System.Drawing.Size(124, 13);
            this.lblFacultySavingsDeposit.TabIndex = 40;
            this.lblFacultySavingsDeposit.Text = "Faculty Savings Deposit:";
            // 
            // lblPagibigLoan
            // 
            this.lblPagibigLoan.AutoSize = true;
            this.lblPagibigLoan.Location = new System.Drawing.Point(364, 443);
            this.lblPagibigLoan.Name = "lblPagibigLoan";
            this.lblPagibigLoan.Size = new System.Drawing.Size(72, 13);
            this.lblPagibigLoan.TabIndex = 39;
            this.lblPagibigLoan.Tag = "";
            this.lblPagibigLoan.Text = "Pagibig Loan:";
            // 
            // lblSSSLoan
            // 
            this.lblSSSLoan.AutoSize = true;
            this.lblSSSLoan.Location = new System.Drawing.Point(364, 417);
            this.lblSSSLoan.Name = "lblSSSLoan";
            this.lblSSSLoan.Size = new System.Drawing.Size(58, 13);
            this.lblSSSLoan.TabIndex = 38;
            this.lblSSSLoan.Text = "SSS Loan:";
            // 
            // lblOtherDeductionHeader
            // 
            this.lblOtherDeductionHeader.AutoSize = true;
            this.lblOtherDeductionHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherDeductionHeader.Location = new System.Drawing.Point(345, 395);
            this.lblOtherDeductionHeader.Name = "lblOtherDeductionHeader";
            this.lblOtherDeductionHeader.Size = new System.Drawing.Size(139, 13);
            this.lblOtherDeductionHeader.TabIndex = 37;
            this.lblOtherDeductionHeader.Text = "OTHER DEDUCTIONS:";
            // 
            // lblPagibigContribution
            // 
            this.lblPagibigContribution.AutoSize = true;
            this.lblPagibigContribution.Location = new System.Drawing.Point(364, 345);
            this.lblPagibigContribution.Name = "lblPagibigContribution";
            this.lblPagibigContribution.Size = new System.Drawing.Size(104, 13);
            this.lblPagibigContribution.TabIndex = 36;
            this.lblPagibigContribution.Text = "Pagibig Contribution:";
            // 
            // lblPhilHealthContribution
            // 
            this.lblPhilHealthContribution.AutoSize = true;
            this.lblPhilHealthContribution.Location = new System.Drawing.Point(364, 319);
            this.lblPhilHealthContribution.Name = "lblPhilHealthContribution";
            this.lblPhilHealthContribution.Size = new System.Drawing.Size(117, 13);
            this.lblPhilHealthContribution.TabIndex = 35;
            this.lblPhilHealthContribution.Text = "PhilHealth Contribution:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(364, 293);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(90, 13);
            this.label26.TabIndex = 34;
            this.label26.Text = "SSS Contribution:";
            // 
            // lblRegDeductionHeader
            // 
            this.lblRegDeductionHeader.AutoSize = true;
            this.lblRegDeductionHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegDeductionHeader.Location = new System.Drawing.Point(345, 271);
            this.lblRegDeductionHeader.Name = "lblRegDeductionHeader";
            this.lblRegDeductionHeader.Size = new System.Drawing.Size(155, 13);
            this.lblRegDeductionHeader.TabIndex = 33;
            this.lblRegDeductionHeader.Text = "REGULAR DEDUCTIONS:";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(492, 89);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(191, 20);
            this.txtMiddleName.TabIndex = 50;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(492, 63);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(191, 20);
            this.txtFirstName.TabIndex = 49;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(368, 92);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(72, 13);
            this.lblMiddleName.TabIndex = 48;
            this.lblMiddleName.Text = "Middle Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(368, 66);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(55, 13);
            this.lblFirstName.TabIndex = 47;
            this.lblFirstName.Text = "Firstname:";
            // 
            // txtCivilStatus
            // 
            this.txtCivilStatus.Location = new System.Drawing.Point(492, 141);
            this.txtCivilStatus.Name = "txtCivilStatus";
            this.txtCivilStatus.Size = new System.Drawing.Size(191, 20);
            this.txtCivilStatus.TabIndex = 54;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(492, 115);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(191, 20);
            this.txtSurname.TabIndex = 53;
            // 
            // lblCivilStatus
            // 
            this.lblCivilStatus.AutoSize = true;
            this.lblCivilStatus.Location = new System.Drawing.Point(368, 144);
            this.lblCivilStatus.Name = "lblCivilStatus";
            this.lblCivilStatus.Size = new System.Drawing.Size(64, 13);
            this.lblCivilStatus.TabIndex = 52;
            this.lblCivilStatus.Text = "Civili Status:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(368, 118);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(58, 13);
            this.lblSurname.TabIndex = 51;
            this.lblSurname.Text = "Surename:";
            // 
            // txtPaydate
            // 
            this.txtPaydate.Location = new System.Drawing.Point(492, 193);
            this.txtPaydate.Name = "txtPaydate";
            this.txtPaydate.Size = new System.Drawing.Size(191, 20);
            this.txtPaydate.TabIndex = 58;
            // 
            // txtQualifiedDependentStatus
            // 
            this.txtQualifiedDependentStatus.Location = new System.Drawing.Point(492, 167);
            this.txtQualifiedDependentStatus.Name = "txtQualifiedDependentStatus";
            this.txtQualifiedDependentStatus.Size = new System.Drawing.Size(191, 20);
            this.txtQualifiedDependentStatus.TabIndex = 57;
            // 
            // lblPaydate
            // 
            this.lblPaydate.AutoSize = true;
            this.lblPaydate.Location = new System.Drawing.Point(368, 196);
            this.lblPaydate.Name = "lblPaydate";
            this.lblPaydate.Size = new System.Drawing.Size(49, 13);
            this.lblPaydate.TabIndex = 56;
            this.lblPaydate.Text = "Paydate:";
            // 
            // lblQualifiedDependentStatus
            // 
            this.lblQualifiedDependentStatus.AutoSize = true;
            this.lblQualifiedDependentStatus.Location = new System.Drawing.Point(368, 170);
            this.lblQualifiedDependentStatus.Name = "lblQualifiedDependentStatus";
            this.lblQualifiedDependentStatus.Size = new System.Drawing.Size(104, 26);
            this.lblQualifiedDependentStatus.TabIndex = 55;
            this.lblQualifiedDependentStatus.Text = "Qualified Dependent\r\n Status:";
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(492, 245);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(191, 20);
            this.txtDesignation.TabIndex = 62;
            // 
            // txtEmployeeStatus
            // 
            this.txtEmployeeStatus.Location = new System.Drawing.Point(492, 219);
            this.txtEmployeeStatus.Name = "txtEmployeeStatus";
            this.txtEmployeeStatus.Size = new System.Drawing.Size(191, 20);
            this.txtEmployeeStatus.TabIndex = 61;
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Location = new System.Drawing.Point(368, 248);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(66, 13);
            this.lblDesignation.TabIndex = 60;
            this.lblDesignation.Text = "Designation:";
            // 
            // lblEmployeeStatus
            // 
            this.lblEmployeeStatus.AutoSize = true;
            this.lblEmployeeStatus.Location = new System.Drawing.Point(368, 222);
            this.lblEmployeeStatus.Name = "lblEmployeeStatus";
            this.lblEmployeeStatus.Size = new System.Drawing.Size(89, 13);
            this.lblEmployeeStatus.TabIndex = 59;
            this.lblEmployeeStatus.Text = "Employee Status:";
            // 
            // btnGrossIncome
            // 
            this.btnGrossIncome.Location = new System.Drawing.Point(347, 625);
            this.btnGrossIncome.Name = "btnGrossIncome";
            this.btnGrossIncome.Size = new System.Drawing.Size(103, 23);
            this.btnGrossIncome.TabIndex = 63;
            this.btnGrossIncome.Text = "GROSS INCOME";
            this.btnGrossIncome.UseVisualStyleBackColor = true;
            this.btnGrossIncome.Click += new System.EventHandler(this.btnGrossIncome_Click);
            // 
            // btnNetIncome
            // 
            this.btnNetIncome.Location = new System.Drawing.Point(456, 626);
            this.btnNetIncome.Name = "btnNetIncome";
            this.btnNetIncome.Size = new System.Drawing.Size(84, 23);
            this.btnNetIncome.TabIndex = 64;
            this.btnNetIncome.Text = "NET INCOME";
            this.btnNetIncome.UseVisualStyleBackColor = true;
            this.btnNetIncome.Click += new System.EventHandler(this.btnNetIncome_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(546, 625);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(49, 23);
            this.btnSave.TabIndex = 65;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(601, 625);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(62, 23);
            this.btnUpdate.TabIndex = 67;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(669, 625);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(41, 23);
            this.btnNew.TabIndex = 66;
            this.btnNew.Text = "NEW";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtCalcIncomeTax
            // 
            this.txtCalcIncomeTax.Location = new System.Drawing.Point(492, 368);
            this.txtCalcIncomeTax.Name = "txtCalcIncomeTax";
            this.txtCalcIncomeTax.ReadOnly = true;
            this.txtCalcIncomeTax.Size = new System.Drawing.Size(191, 20);
            this.txtCalcIncomeTax.TabIndex = 69;
            // 
            // lblIncomeTaxContribution
            // 
            this.lblIncomeTaxContribution.AutoSize = true;
            this.lblIncomeTaxContribution.Location = new System.Drawing.Point(364, 371);
            this.lblIncomeTaxContribution.Name = "lblIncomeTaxContribution";
            this.lblIncomeTaxContribution.Size = new System.Drawing.Size(125, 13);
            this.lblIncomeTaxContribution.TabIndex = 68;
            this.lblIncomeTaxContribution.Text = "Income Tax Contribution:";
            // 
            // txtOtherGeneralLoan
            // 
            this.txtOtherGeneralLoan.Location = new System.Drawing.Point(492, 544);
            this.txtOtherGeneralLoan.Name = "txtOtherGeneralLoan";
            this.txtOtherGeneralLoan.Size = new System.Drawing.Size(191, 20);
            this.txtOtherGeneralLoan.TabIndex = 75;
            // 
            // txtOtherSalaryLoan
            // 
            this.txtOtherSalaryLoan.Location = new System.Drawing.Point(492, 518);
            this.txtOtherSalaryLoan.Name = "txtOtherSalaryLoan";
            this.txtOtherSalaryLoan.Size = new System.Drawing.Size(191, 20);
            this.txtOtherSalaryLoan.TabIndex = 74;
            // 
            // txtOtherFacultyLoan
            // 
            this.txtOtherFacultyLoan.Location = new System.Drawing.Point(492, 492);
            this.txtOtherFacultyLoan.Name = "txtOtherFacultyLoan";
            this.txtOtherFacultyLoan.Size = new System.Drawing.Size(191, 20);
            this.txtOtherFacultyLoan.TabIndex = 73;
            // 
            // lblOtherLoans
            // 
            this.lblOtherLoans.AutoSize = true;
            this.lblOtherLoans.Location = new System.Drawing.Point(364, 547);
            this.lblOtherLoans.Name = "lblOtherLoans";
            this.lblOtherLoans.Size = new System.Drawing.Size(63, 13);
            this.lblOtherLoans.TabIndex = 72;
            this.lblOtherLoans.Text = "Other Loan:";
            // 
            // lblSalaryLoan
            // 
            this.lblSalaryLoan.AutoSize = true;
            this.lblSalaryLoan.Location = new System.Drawing.Point(364, 521);
            this.lblSalaryLoan.Name = "lblSalaryLoan";
            this.lblSalaryLoan.Size = new System.Drawing.Size(66, 13);
            this.lblSalaryLoan.TabIndex = 71;
            this.lblSalaryLoan.Tag = "";
            this.lblSalaryLoan.Text = "Salary Loan:";
            // 
            // lblFacultySavingsLoan
            // 
            this.lblFacultySavingsLoan.AutoSize = true;
            this.lblFacultySavingsLoan.Location = new System.Drawing.Point(364, 495);
            this.lblFacultySavingsLoan.Name = "lblFacultySavingsLoan";
            this.lblFacultySavingsLoan.Size = new System.Drawing.Size(112, 13);
            this.lblFacultySavingsLoan.TabIndex = 70;
            this.lblFacultySavingsLoan.Text = "Faculty Savings Loan:";
            // 
            // txtSummaryTotalDeduction
            // 
            this.txtSummaryTotalDeduction.Location = new System.Drawing.Point(492, 591);
            this.txtSummaryTotalDeduction.Name = "txtSummaryTotalDeduction";
            this.txtSummaryTotalDeduction.ReadOnly = true;
            this.txtSummaryTotalDeduction.Size = new System.Drawing.Size(191, 20);
            this.txtSummaryTotalDeduction.TabIndex = 78;
            // 
            // lblSummaryTotalDeduction
            // 
            this.lblSummaryTotalDeduction.AutoSize = true;
            this.lblSummaryTotalDeduction.Location = new System.Drawing.Point(364, 594);
            this.lblSummaryTotalDeduction.Name = "lblSummaryTotalDeduction";
            this.lblSummaryTotalDeduction.Size = new System.Drawing.Size(91, 13);
            this.lblSummaryTotalDeduction.TabIndex = 77;
            this.lblSummaryTotalDeduction.Text = "Total Deductions:";
            // 
            // lblDeductionSummaryHeader
            // 
            this.lblDeductionSummaryHeader.AutoSize = true;
            this.lblDeductionSummaryHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeductionSummaryHeader.Location = new System.Drawing.Point(345, 572);
            this.lblDeductionSummaryHeader.Name = "lblDeductionSummaryHeader";
            this.lblDeductionSummaryHeader.Size = new System.Drawing.Size(150, 13);
            this.lblDeductionSummaryHeader.TabIndex = 76;
            this.lblDeductionSummaryHeader.Text = "DEDUCTION SUMMARY:";
            // 
            // frmMainPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 661);
            this.Controls.Add(this.txtSummaryTotalDeduction);
            this.Controls.Add(this.lblSummaryTotalDeduction);
            this.Controls.Add(this.lblDeductionSummaryHeader);
            this.Controls.Add(this.txtOtherGeneralLoan);
            this.Controls.Add(this.txtOtherSalaryLoan);
            this.Controls.Add(this.txtOtherFacultyLoan);
            this.Controls.Add(this.lblOtherLoans);
            this.Controls.Add(this.lblSalaryLoan);
            this.Controls.Add(this.lblFacultySavingsLoan);
            this.Controls.Add(this.txtCalcIncomeTax);
            this.Controls.Add(this.lblIncomeTaxContribution);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNetIncome);
            this.Controls.Add(this.btnGrossIncome);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.txtEmployeeStatus);
            this.Controls.Add(this.lblDesignation);
            this.Controls.Add(this.lblEmployeeStatus);
            this.Controls.Add(this.txtPaydate);
            this.Controls.Add(this.txtQualifiedDependentStatus);
            this.Controls.Add(this.lblPaydate);
            this.Controls.Add(this.lblQualifiedDependentStatus);
            this.Controls.Add(this.txtCivilStatus);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblCivilStatus);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtOtherFacultyDeposit);
            this.Controls.Add(this.txtOtherPagibigLoan);
            this.Controls.Add(this.txtOtherSSSLoan);
            this.Controls.Add(this.txtCalcPagibig);
            this.Controls.Add(this.txtCalcPhilHealth);
            this.Controls.Add(this.txtCalcSSS);
            this.Controls.Add(this.lblFacultySavingsDeposit);
            this.Controls.Add(this.lblPagibigLoan);
            this.Controls.Add(this.lblSSSLoan);
            this.Controls.Add(this.lblOtherDeductionHeader);
            this.Controls.Add(this.lblPagibigContribution);
            this.Controls.Add(this.lblPhilHealthContribution);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.lblRegDeductionHeader);
            this.Controls.Add(this.txtSummaryNet);
            this.Controls.Add(this.txtSummaryGross);
            this.Controls.Add(this.txtCalcOtherIncome);
            this.Controls.Add(this.txtOtherHoursCutOff);
            this.Controls.Add(this.txtOtherRateHour);
            this.Controls.Add(this.txtCalcHonIncome);
            this.Controls.Add(this.txtHonHoursCutOff);
            this.Controls.Add(this.txtHonRateHour);
            this.Controls.Add(this.txtCalcBasicIncome);
            this.Controls.Add(this.txtBasicHoursCutOff);
            this.Controls.Add(this.txtBasicRateHour);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtEmployeeNumber);
            this.Controls.Add(this.lblSummaryNet);
            this.Controls.Add(this.lblSummaryGross);
            this.Controls.Add(this.lblSummaryIncomeHeader);
            this.Controls.Add(this.lblOtherIncomeCutOff);
            this.Controls.Add(this.lblOtherHoursCutOff);
            this.Controls.Add(this.lblOtherRateHour);
            this.Controls.Add(this.lblOtherIncomeHeader);
            this.Controls.Add(this.lblHonIncomeCutOff);
            this.Controls.Add(this.lblHonHoursCutOff);
            this.Controls.Add(this.lblHonRateHour);
            this.Controls.Add(this.lblHonIncomeHeader);
            this.Controls.Add(this.lblBasicIncomeCutOff);
            this.Controls.Add(this.lblBasicHoursCutOff);
            this.Controls.Add(this.lblBasicRateHour);
            this.Controls.Add(this.lblBasicIncomeHeader);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblEmployeeNumber);
            this.Controls.Add(this.lblMainHeader);
            this.Controls.Add(this.picEmployeePhoto);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMainPayroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SE-RI\'S CHOICE PAYROLL";
            ((System.ComponentModel.ISupportInitialize)(this.picEmployeePhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picEmployeePhoto;
        private System.Windows.Forms.Label lblMainHeader;
        private System.Windows.Forms.Label lblEmployeeNumber;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblBasicIncomeHeader;
        private System.Windows.Forms.Label lblBasicRateHour;
        private System.Windows.Forms.Label lblBasicHoursCutOff;
        private System.Windows.Forms.Label lblBasicIncomeCutOff;
        private System.Windows.Forms.Label lblHonIncomeHeader;
        private System.Windows.Forms.Label lblHonRateHour;
        private System.Windows.Forms.Label lblHonHoursCutOff;
        private System.Windows.Forms.Label lblHonIncomeCutOff;
        private System.Windows.Forms.Label lblOtherIncomeHeader;
        private System.Windows.Forms.Label lblOtherRateHour;
        private System.Windows.Forms.Label lblOtherHoursCutOff;
        private System.Windows.Forms.Label lblOtherIncomeCutOff;
        private System.Windows.Forms.Label lblSummaryIncomeHeader;
        private System.Windows.Forms.Label lblSummaryGross;
        private System.Windows.Forms.Label lblSummaryNet;
        private System.Windows.Forms.TextBox txtEmployeeNumber;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtBasicRateHour;
        private System.Windows.Forms.TextBox txtBasicHoursCutOff;
        private System.Windows.Forms.TextBox txtCalcBasicIncome;
        private System.Windows.Forms.TextBox txtCalcHonIncome;
        private System.Windows.Forms.TextBox txtHonHoursCutOff;
        private System.Windows.Forms.TextBox txtHonRateHour;
        private System.Windows.Forms.TextBox txtCalcOtherIncome;
        private System.Windows.Forms.TextBox txtOtherHoursCutOff;
        private System.Windows.Forms.TextBox txtOtherRateHour;
        private System.Windows.Forms.TextBox txtSummaryNet;
        private System.Windows.Forms.TextBox txtSummaryGross;
        private System.Windows.Forms.TextBox txtOtherFacultyDeposit;
        private System.Windows.Forms.TextBox txtOtherPagibigLoan;
        private System.Windows.Forms.TextBox txtOtherSSSLoan;
        private System.Windows.Forms.TextBox txtCalcPagibig;
        private System.Windows.Forms.TextBox txtCalcPhilHealth;
        private System.Windows.Forms.TextBox txtCalcSSS;
        private System.Windows.Forms.Label lblFacultySavingsDeposit;
        private System.Windows.Forms.Label lblPagibigLoan;
        private System.Windows.Forms.Label lblSSSLoan;
        private System.Windows.Forms.Label lblOtherDeductionHeader;
        private System.Windows.Forms.Label lblPagibigContribution;
        private System.Windows.Forms.Label lblPhilHealthContribution;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblRegDeductionHeader;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtCivilStatus;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblCivilStatus;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtPaydate;
        private System.Windows.Forms.TextBox txtQualifiedDependentStatus;
        private System.Windows.Forms.Label lblPaydate;
        private System.Windows.Forms.Label lblQualifiedDependentStatus;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.TextBox txtEmployeeStatus;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblEmployeeStatus;
        private System.Windows.Forms.Button btnGrossIncome;
        private System.Windows.Forms.Button btnNetIncome;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtCalcIncomeTax;
        private System.Windows.Forms.Label lblIncomeTaxContribution;
        private System.Windows.Forms.TextBox txtOtherGeneralLoan;
        private System.Windows.Forms.TextBox txtOtherSalaryLoan;
        private System.Windows.Forms.TextBox txtOtherFacultyLoan;
        private System.Windows.Forms.Label lblOtherLoans;
        private System.Windows.Forms.Label lblSalaryLoan;
        private System.Windows.Forms.Label lblFacultySavingsLoan;
        private System.Windows.Forms.TextBox txtSummaryTotalDeduction;
        private System.Windows.Forms.Label lblSummaryTotalDeduction;
        private System.Windows.Forms.Label lblDeductionSummaryHeader;
        public System.Windows.Forms.Button btnSave;
    }
}

