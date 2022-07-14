namespace DepartmentManagement
{
    partial class frmDetail
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
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtDepartmentID = new System.Windows.Forms.ComboBox();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lbFullName = new System.Windows.Forms.Label();
            this.lbEmployeeID = new System.Windows.Forms.Label();
            this.cbDepartmentID = new System.Windows.Forms.Label();
            this.lbJobTitle = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(135, 56);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(286, 27);
            this.txtFullName.TabIndex = 63;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(135, 12);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(286, 27);
            this.txtEmployeeID.TabIndex = 62;
            // 
            // txtDepartmentID
            // 
            this.txtDepartmentID.FormattingEnabled = true;
            this.txtDepartmentID.Location = new System.Drawing.Point(135, 195);
            this.txtDepartmentID.Name = "txtDepartmentID";
            this.txtDepartmentID.Size = new System.Drawing.Size(262, 28);
            this.txtDepartmentID.TabIndex = 61;
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Location = new System.Drawing.Point(135, 153);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(267, 27);
            this.txtJobTitle.TabIndex = 60;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(135, 111);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(267, 27);
            this.txtYear.TabIndex = 59;
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Location = new System.Drawing.Point(5, 63);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(72, 20);
            this.lbFullName.TabIndex = 58;
            this.lbFullName.Text = "FullName";
            // 
            // lbEmployeeID
            // 
            this.lbEmployeeID.AutoSize = true;
            this.lbEmployeeID.Location = new System.Drawing.Point(5, 20);
            this.lbEmployeeID.Name = "lbEmployeeID";
            this.lbEmployeeID.Size = new System.Drawing.Size(90, 20);
            this.lbEmployeeID.TabIndex = 57;
            this.lbEmployeeID.Text = "EmployeeID";
            // 
            // cbDepartmentID
            // 
            this.cbDepartmentID.AutoSize = true;
            this.cbDepartmentID.Location = new System.Drawing.Point(12, 195);
            this.cbDepartmentID.Name = "cbDepartmentID";
            this.cbDepartmentID.Size = new System.Drawing.Size(89, 20);
            this.cbDepartmentID.TabIndex = 66;
            this.cbDepartmentID.Text = "Department";
            // 
            // lbJobTitle
            // 
            this.lbJobTitle.AutoSize = true;
            this.lbJobTitle.Location = new System.Drawing.Point(12, 156);
            this.lbJobTitle.Name = "lbJobTitle";
            this.lbJobTitle.Size = new System.Drawing.Size(61, 20);
            this.lbJobTitle.TabIndex = 65;
            this.lbJobTitle.Text = "JobTitle";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(12, 114);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(37, 20);
            this.lbYear.TabIndex = 64;
            this.lbYear.Text = "Year";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(422, 303);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 68;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(226, 303);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 67;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbDepartmentID);
            this.Controls.Add(this.lbJobTitle);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.txtDepartmentID);
            this.Controls.Add(this.txtJobTitle);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lbFullName);
            this.Controls.Add(this.lbEmployeeID);
            this.Name = "frmDetail";
            this.Text = "frmDetail";
            this.Load += new System.EventHandler(this.frmDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.ComboBox txtDepartmentID;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.Label lbEmployeeID;
        private System.Windows.Forms.Label cbDepartmentID;
        private System.Windows.Forms.Label lbJobTitle;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}