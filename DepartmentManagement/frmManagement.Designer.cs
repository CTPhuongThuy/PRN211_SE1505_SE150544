
using System;
using System.Windows.Forms;
namespace DepartmentManagement
{
    partial class frmManagement
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
            this.cbDepartmentID = new System.Windows.Forms.Label();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dgvMemberList = new System.Windows.Forms.DataGridView();
            this.lbJobTitle = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.lbFullName = new System.Windows.Forms.Label();
            this.lbEmployeeID = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtDepartmentID = new System.Windows.Forms.TextBox();
            this.lbDepartmentID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDepartmentID
            // 
            this.cbDepartmentID.Location = new System.Drawing.Point(0, 0);
            this.cbDepartmentID.Name = "cbDepartmentID";
            this.cbDepartmentID.Size = new System.Drawing.Size(100, 23);
            this.cbDepartmentID.TabIndex = 58;
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Location = new System.Drawing.Point(567, 54);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(267, 27);
            this.txtJobTitle.TabIndex = 51;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(567, 12);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(267, 27);
            this.txtYear.TabIndex = 50;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(415, 457);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 29);
            this.btnClose.TabIndex = 42;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(712, 137);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 29);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(401, 137);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(139, 29);
            this.btnNew.TabIndex = 40;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(106, 137);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(136, 29);
            this.btnLoad.TabIndex = 39;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dgvMemberList
            // 
            this.dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberList.Location = new System.Drawing.Point(16, 172);
            this.dgvMemberList.Name = "dgvMemberList";
            this.dgvMemberList.ReadOnly = true;
            this.dgvMemberList.RowHeadersWidth = 51;
            this.dgvMemberList.RowTemplate.Height = 29;
            this.dgvMemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberList.Size = new System.Drawing.Size(939, 261);
            this.dgvMemberList.TabIndex = 38;
            this.dgvMemberList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemberList_CellContentClick);
            // 
            // lbJobTitle
            // 
            this.lbJobTitle.AutoSize = true;
            this.lbJobTitle.Location = new System.Drawing.Point(465, 55);
            this.lbJobTitle.Name = "lbJobTitle";
            this.lbJobTitle.Size = new System.Drawing.Size(61, 20);
            this.lbJobTitle.TabIndex = 33;
            this.lbJobTitle.Text = "JobTitle";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(465, 13);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(37, 20);
            this.lbYear.TabIndex = 32;
            this.lbYear.Text = "Year";
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Location = new System.Drawing.Point(34, 58);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(72, 20);
            this.lbFullName.TabIndex = 30;
            this.lbFullName.Text = "FullName";
            // 
            // lbEmployeeID
            // 
            this.lbEmployeeID.AutoSize = true;
            this.lbEmployeeID.Location = new System.Drawing.Point(34, 23);
            this.lbEmployeeID.Name = "lbEmployeeID";
            this.lbEmployeeID.Size = new System.Drawing.Size(90, 20);
            this.lbEmployeeID.TabIndex = 29;
            this.lbEmployeeID.Text = "EmployeeID";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(164, 23);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(286, 27);
            this.txtEmployeeID.TabIndex = 55;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(164, 72);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(286, 27);
            this.txtFullName.TabIndex = 56;
            // 
            // txtDepartmentID
            // 
            this.txtDepartmentID.Location = new System.Drawing.Point(567, 94);
            this.txtDepartmentID.Name = "txtDepartmentID";
            this.txtDepartmentID.Size = new System.Drawing.Size(267, 27);
            this.txtDepartmentID.TabIndex = 57;
            // 
            // lbDepartmentID
            // 
            this.lbDepartmentID.AutoSize = true;
            this.lbDepartmentID.Location = new System.Drawing.Point(457, 92);
            this.lbDepartmentID.Name = "lbDepartmentID";
            this.lbDepartmentID.Size = new System.Drawing.Size(104, 20);
            this.lbDepartmentID.TabIndex = 59;
            this.lbDepartmentID.Text = "DepartmentID";
            // 
            // frmManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 501);
            this.Controls.Add(this.lbDepartmentID);
            this.Controls.Add(this.txtDepartmentID);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.cbDepartmentID);
            this.Controls.Add(this.txtJobTitle);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvMemberList);
            this.Controls.Add(this.lbJobTitle);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.lbFullName);
            this.Controls.Add(this.lbEmployeeID);
            this.Name = "frmManagement";
            this.Text = "Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label cbDepartmentID;
        private TextBox txtJobTitle;
        private TextBox txtYear;
        private Button btnClose;
        private Button btnDelete;
        private Button btnNew;
        private Button btnLoad;
        private DataGridView dgvMemberList;
        private Label lbJobTitle;
        private Label lbYear;
        private Label lbFullName;
        private Label lbEmployeeID;
        private TextBox txtEmployeeID;
        private TextBox txtFullName;
        private TextBox txtDepartmentID;
        private Label lbDepartmentID;
    }
}