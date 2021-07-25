
namespace FormUI
{
    partial class FormEmployee
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
            this.lblEmployeeIdSearch = new System.Windows.Forms.Label();
            this.tbxEmployeeIdSearch = new System.Windows.Forms.TextBox();
            this.gbxEmployeeDelete = new System.Windows.Forms.GroupBox();
            this.btnEmployeeDelete = new System.Windows.Forms.Button();
            this.tbxEmployeeIdDelete = new System.Windows.Forms.TextBox();
            this.lblEmployeeIdDelete = new System.Windows.Forms.Label();
            this.gbxEmployeeUpdate = new System.Windows.Forms.GroupBox();
            this.lblParkingSpaceIdUpdate = new System.Windows.Forms.Label();
            this.tbxParkingSpaceIdUpdate = new System.Windows.Forms.TextBox();
            this.btnEmployeeUpdate = new System.Windows.Forms.Button();
            this.tbxEmployeeLastNameUpdate = new System.Windows.Forms.TextBox();
            this.tbxEmployeeFirstNameUpdate = new System.Windows.Forms.TextBox();
            this.tbxEmployeeSalaryUpdate = new System.Windows.Forms.TextBox();
            this.lblEmployeeFirstNameUpdate = new System.Windows.Forms.Label();
            this.lblEmployeeLastNameUpdate = new System.Windows.Forms.Label();
            this.lblEmployeeSalaryUpdate = new System.Windows.Forms.Label();
            this.gbxEmployeeAdd = new System.Windows.Forms.GroupBox();
            this.lblParkingSpaceIdAdd = new System.Windows.Forms.Label();
            this.tbxParkingSpaceIdAdd = new System.Windows.Forms.TextBox();
            this.btnEmployeeAdd = new System.Windows.Forms.Button();
            this.tbxEmployeeLastNameAdd = new System.Windows.Forms.TextBox();
            this.tbxEmployeeSalaryAdd = new System.Windows.Forms.TextBox();
            this.tbxEmployeeFirstNameAdd = new System.Windows.Forms.TextBox();
            this.lblEmployeeSalaryAdd = new System.Windows.Forms.Label();
            this.lblEmployeeLastNameAdd = new System.Windows.Forms.Label();
            this.lblEmployeeFirstNameAdd = new System.Windows.Forms.Label();
            this.dgwEmployee = new System.Windows.Forms.DataGridView();
            this.gbxEmployeeDelete.SuspendLayout();
            this.gbxEmployeeUpdate.SuspendLayout();
            this.gbxEmployeeAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmployeeIdSearch
            // 
            this.lblEmployeeIdSearch.AutoSize = true;
            this.lblEmployeeIdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeIdSearch.Location = new System.Drawing.Point(624, 10);
            this.lblEmployeeIdSearch.Name = "lblEmployeeIdSearch";
            this.lblEmployeeIdSearch.Size = new System.Drawing.Size(154, 29);
            this.lblEmployeeIdSearch.TabIndex = 10;
            this.lblEmployeeIdSearch.Text = "Employee Id:";
            // 
            // tbxEmployeeIdSearch
            // 
            this.tbxEmployeeIdSearch.Location = new System.Drawing.Point(796, 17);
            this.tbxEmployeeIdSearch.Name = "tbxEmployeeIdSearch";
            this.tbxEmployeeIdSearch.Size = new System.Drawing.Size(187, 22);
            this.tbxEmployeeIdSearch.TabIndex = 8;
            this.tbxEmployeeIdSearch.TextChanged += new System.EventHandler(this.tbxEmployeeIdSearch_TextChanged);
            // 
            // gbxEmployeeDelete
            // 
            this.gbxEmployeeDelete.Controls.Add(this.btnEmployeeDelete);
            this.gbxEmployeeDelete.Controls.Add(this.tbxEmployeeIdDelete);
            this.gbxEmployeeDelete.Controls.Add(this.lblEmployeeIdDelete);
            this.gbxEmployeeDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEmployeeDelete.Location = new System.Drawing.Point(859, 345);
            this.gbxEmployeeDelete.Name = "gbxEmployeeDelete";
            this.gbxEmployeeDelete.Size = new System.Drawing.Size(179, 274);
            this.gbxEmployeeDelete.TabIndex = 9;
            this.gbxEmployeeDelete.TabStop = false;
            this.gbxEmployeeDelete.Text = "Delete";
            // 
            // btnEmployeeDelete
            // 
            this.btnEmployeeDelete.Location = new System.Drawing.Point(58, 220);
            this.btnEmployeeDelete.Name = "btnEmployeeDelete";
            this.btnEmployeeDelete.Size = new System.Drawing.Size(101, 36);
            this.btnEmployeeDelete.TabIndex = 2;
            this.btnEmployeeDelete.Text = "Delete";
            this.btnEmployeeDelete.UseVisualStyleBackColor = true;
            this.btnEmployeeDelete.Click += new System.EventHandler(this.btnEmployeeDelete_Click);
            // 
            // tbxEmployeeIdDelete
            // 
            this.tbxEmployeeIdDelete.Location = new System.Drawing.Point(8, 75);
            this.tbxEmployeeIdDelete.Name = "tbxEmployeeIdDelete";
            this.tbxEmployeeIdDelete.Size = new System.Drawing.Size(100, 34);
            this.tbxEmployeeIdDelete.TabIndex = 1;
            // 
            // lblEmployeeIdDelete
            // 
            this.lblEmployeeIdDelete.AutoSize = true;
            this.lblEmployeeIdDelete.Location = new System.Drawing.Point(3, 30);
            this.lblEmployeeIdDelete.Name = "lblEmployeeIdDelete";
            this.lblEmployeeIdDelete.Size = new System.Drawing.Size(148, 29);
            this.lblEmployeeIdDelete.TabIndex = 0;
            this.lblEmployeeIdDelete.Text = "Employee Id";
            // 
            // gbxEmployeeUpdate
            // 
            this.gbxEmployeeUpdate.Controls.Add(this.lblParkingSpaceIdUpdate);
            this.gbxEmployeeUpdate.Controls.Add(this.tbxParkingSpaceIdUpdate);
            this.gbxEmployeeUpdate.Controls.Add(this.btnEmployeeUpdate);
            this.gbxEmployeeUpdate.Controls.Add(this.tbxEmployeeLastNameUpdate);
            this.gbxEmployeeUpdate.Controls.Add(this.tbxEmployeeFirstNameUpdate);
            this.gbxEmployeeUpdate.Controls.Add(this.tbxEmployeeSalaryUpdate);
            this.gbxEmployeeUpdate.Controls.Add(this.lblEmployeeFirstNameUpdate);
            this.gbxEmployeeUpdate.Controls.Add(this.lblEmployeeLastNameUpdate);
            this.gbxEmployeeUpdate.Controls.Add(this.lblEmployeeSalaryUpdate);
            this.gbxEmployeeUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEmployeeUpdate.Location = new System.Drawing.Point(427, 345);
            this.gbxEmployeeUpdate.Name = "gbxEmployeeUpdate";
            this.gbxEmployeeUpdate.Size = new System.Drawing.Size(379, 275);
            this.gbxEmployeeUpdate.TabIndex = 6;
            this.gbxEmployeeUpdate.TabStop = false;
            this.gbxEmployeeUpdate.Text = "Update";
            // 
            // lblParkingSpaceIdUpdate
            // 
            this.lblParkingSpaceIdUpdate.AutoSize = true;
            this.lblParkingSpaceIdUpdate.Location = new System.Drawing.Point(20, 168);
            this.lblParkingSpaceIdUpdate.Name = "lblParkingSpaceIdUpdate";
            this.lblParkingSpaceIdUpdate.Size = new System.Drawing.Size(196, 29);
            this.lblParkingSpaceIdUpdate.TabIndex = 4;
            this.lblParkingSpaceIdUpdate.Text = "Parking Space Id";
            // 
            // tbxParkingSpaceIdUpdate
            // 
            this.tbxParkingSpaceIdUpdate.Location = new System.Drawing.Point(222, 168);
            this.tbxParkingSpaceIdUpdate.Name = "tbxParkingSpaceIdUpdate";
            this.tbxParkingSpaceIdUpdate.Size = new System.Drawing.Size(100, 34);
            this.tbxParkingSpaceIdUpdate.TabIndex = 5;
            // 
            // btnEmployeeUpdate
            // 
            this.btnEmployeeUpdate.Location = new System.Drawing.Point(222, 220);
            this.btnEmployeeUpdate.Name = "btnEmployeeUpdate";
            this.btnEmployeeUpdate.Size = new System.Drawing.Size(118, 36);
            this.btnEmployeeUpdate.TabIndex = 7;
            this.btnEmployeeUpdate.Text = "Update";
            this.btnEmployeeUpdate.UseVisualStyleBackColor = true;
            this.btnEmployeeUpdate.Click += new System.EventHandler(this.btnEmployeeUpdate_Click);
            // 
            // tbxEmployeeLastNameUpdate
            // 
            this.tbxEmployeeLastNameUpdate.Location = new System.Drawing.Point(222, 88);
            this.tbxEmployeeLastNameUpdate.Name = "tbxEmployeeLastNameUpdate";
            this.tbxEmployeeLastNameUpdate.Size = new System.Drawing.Size(100, 34);
            this.tbxEmployeeLastNameUpdate.TabIndex = 12;
            // 
            // tbxEmployeeFirstNameUpdate
            // 
            this.tbxEmployeeFirstNameUpdate.Location = new System.Drawing.Point(222, 39);
            this.tbxEmployeeFirstNameUpdate.Name = "tbxEmployeeFirstNameUpdate";
            this.tbxEmployeeFirstNameUpdate.Size = new System.Drawing.Size(100, 34);
            this.tbxEmployeeFirstNameUpdate.TabIndex = 10;
            // 
            // tbxEmployeeSalaryUpdate
            // 
            this.tbxEmployeeSalaryUpdate.Location = new System.Drawing.Point(222, 128);
            this.tbxEmployeeSalaryUpdate.Name = "tbxEmployeeSalaryUpdate";
            this.tbxEmployeeSalaryUpdate.Size = new System.Drawing.Size(100, 34);
            this.tbxEmployeeSalaryUpdate.TabIndex = 11;
            // 
            // lblEmployeeFirstNameUpdate
            // 
            this.lblEmployeeFirstNameUpdate.AutoSize = true;
            this.lblEmployeeFirstNameUpdate.Location = new System.Drawing.Point(20, 39);
            this.lblEmployeeFirstNameUpdate.Name = "lblEmployeeFirstNameUpdate";
            this.lblEmployeeFirstNameUpdate.Size = new System.Drawing.Size(131, 29);
            this.lblEmployeeFirstNameUpdate.TabIndex = 7;
            this.lblEmployeeFirstNameUpdate.Text = "First Name";
            // 
            // lblEmployeeLastNameUpdate
            // 
            this.lblEmployeeLastNameUpdate.AutoSize = true;
            this.lblEmployeeLastNameUpdate.Location = new System.Drawing.Point(20, 80);
            this.lblEmployeeLastNameUpdate.Name = "lblEmployeeLastNameUpdate";
            this.lblEmployeeLastNameUpdate.Size = new System.Drawing.Size(128, 29);
            this.lblEmployeeLastNameUpdate.TabIndex = 8;
            this.lblEmployeeLastNameUpdate.Text = "Last Name";
            // 
            // lblEmployeeSalaryUpdate
            // 
            this.lblEmployeeSalaryUpdate.AutoSize = true;
            this.lblEmployeeSalaryUpdate.Location = new System.Drawing.Point(20, 123);
            this.lblEmployeeSalaryUpdate.Name = "lblEmployeeSalaryUpdate";
            this.lblEmployeeSalaryUpdate.Size = new System.Drawing.Size(80, 29);
            this.lblEmployeeSalaryUpdate.TabIndex = 9;
            this.lblEmployeeSalaryUpdate.Text = "Salary";
            // 
            // gbxEmployeeAdd
            // 
            this.gbxEmployeeAdd.Controls.Add(this.lblParkingSpaceIdAdd);
            this.gbxEmployeeAdd.Controls.Add(this.tbxParkingSpaceIdAdd);
            this.gbxEmployeeAdd.Controls.Add(this.btnEmployeeAdd);
            this.gbxEmployeeAdd.Controls.Add(this.tbxEmployeeLastNameAdd);
            this.gbxEmployeeAdd.Controls.Add(this.tbxEmployeeSalaryAdd);
            this.gbxEmployeeAdd.Controls.Add(this.tbxEmployeeFirstNameAdd);
            this.gbxEmployeeAdd.Controls.Add(this.lblEmployeeSalaryAdd);
            this.gbxEmployeeAdd.Controls.Add(this.lblEmployeeLastNameAdd);
            this.gbxEmployeeAdd.Controls.Add(this.lblEmployeeFirstNameAdd);
            this.gbxEmployeeAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEmployeeAdd.Location = new System.Drawing.Point(12, 345);
            this.gbxEmployeeAdd.Name = "gbxEmployeeAdd";
            this.gbxEmployeeAdd.Size = new System.Drawing.Size(379, 275);
            this.gbxEmployeeAdd.TabIndex = 7;
            this.gbxEmployeeAdd.TabStop = false;
            this.gbxEmployeeAdd.Text = "Add";
            // 
            // lblParkingSpaceIdAdd
            // 
            this.lblParkingSpaceIdAdd.AutoSize = true;
            this.lblParkingSpaceIdAdd.Location = new System.Drawing.Point(7, 166);
            this.lblParkingSpaceIdAdd.Name = "lblParkingSpaceIdAdd";
            this.lblParkingSpaceIdAdd.Size = new System.Drawing.Size(196, 29);
            this.lblParkingSpaceIdAdd.TabIndex = 3;
            this.lblParkingSpaceIdAdd.Text = "Parking Space Id";
            // 
            // tbxParkingSpaceIdAdd
            // 
            this.tbxParkingSpaceIdAdd.Location = new System.Drawing.Point(209, 166);
            this.tbxParkingSpaceIdAdd.Name = "tbxParkingSpaceIdAdd";
            this.tbxParkingSpaceIdAdd.Size = new System.Drawing.Size(100, 34);
            this.tbxParkingSpaceIdAdd.TabIndex = 6;
            // 
            // btnEmployeeAdd
            // 
            this.btnEmployeeAdd.Location = new System.Drawing.Point(209, 220);
            this.btnEmployeeAdd.Name = "btnEmployeeAdd";
            this.btnEmployeeAdd.Size = new System.Drawing.Size(118, 36);
            this.btnEmployeeAdd.TabIndex = 6;
            this.btnEmployeeAdd.Text = "Add";
            this.btnEmployeeAdd.UseVisualStyleBackColor = true;
            this.btnEmployeeAdd.Click += new System.EventHandler(this.btnEmployeeAdd_Click);
            // 
            // tbxEmployeeLastNameAdd
            // 
            this.tbxEmployeeLastNameAdd.Location = new System.Drawing.Point(209, 80);
            this.tbxEmployeeLastNameAdd.Name = "tbxEmployeeLastNameAdd";
            this.tbxEmployeeLastNameAdd.Size = new System.Drawing.Size(100, 34);
            this.tbxEmployeeLastNameAdd.TabIndex = 5;
            // 
            // tbxEmployeeSalaryAdd
            // 
            this.tbxEmployeeSalaryAdd.Location = new System.Drawing.Point(209, 123);
            this.tbxEmployeeSalaryAdd.Name = "tbxEmployeeSalaryAdd";
            this.tbxEmployeeSalaryAdd.Size = new System.Drawing.Size(100, 34);
            this.tbxEmployeeSalaryAdd.TabIndex = 4;
            // 
            // tbxEmployeeFirstNameAdd
            // 
            this.tbxEmployeeFirstNameAdd.Location = new System.Drawing.Point(209, 40);
            this.tbxEmployeeFirstNameAdd.Name = "tbxEmployeeFirstNameAdd";
            this.tbxEmployeeFirstNameAdd.Size = new System.Drawing.Size(100, 34);
            this.tbxEmployeeFirstNameAdd.TabIndex = 3;
            // 
            // lblEmployeeSalaryAdd
            // 
            this.lblEmployeeSalaryAdd.AutoSize = true;
            this.lblEmployeeSalaryAdd.Location = new System.Drawing.Point(6, 123);
            this.lblEmployeeSalaryAdd.Name = "lblEmployeeSalaryAdd";
            this.lblEmployeeSalaryAdd.Size = new System.Drawing.Size(80, 29);
            this.lblEmployeeSalaryAdd.TabIndex = 2;
            this.lblEmployeeSalaryAdd.Text = "Salary";
            // 
            // lblEmployeeLastNameAdd
            // 
            this.lblEmployeeLastNameAdd.AutoSize = true;
            this.lblEmployeeLastNameAdd.Location = new System.Drawing.Point(6, 80);
            this.lblEmployeeLastNameAdd.Name = "lblEmployeeLastNameAdd";
            this.lblEmployeeLastNameAdd.Size = new System.Drawing.Size(128, 29);
            this.lblEmployeeLastNameAdd.TabIndex = 1;
            this.lblEmployeeLastNameAdd.Text = "Last Name";
            // 
            // lblEmployeeFirstNameAdd
            // 
            this.lblEmployeeFirstNameAdd.AutoSize = true;
            this.lblEmployeeFirstNameAdd.Location = new System.Drawing.Point(6, 39);
            this.lblEmployeeFirstNameAdd.Name = "lblEmployeeFirstNameAdd";
            this.lblEmployeeFirstNameAdd.Size = new System.Drawing.Size(131, 29);
            this.lblEmployeeFirstNameAdd.TabIndex = 0;
            this.lblEmployeeFirstNameAdd.Text = "First Name";
            // 
            // dgwEmployee
            // 
            this.dgwEmployee.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgwEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwEmployee.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgwEmployee.Location = new System.Drawing.Point(12, 51);
            this.dgwEmployee.Name = "dgwEmployee";
            this.dgwEmployee.RowHeadersWidth = 51;
            this.dgwEmployee.RowTemplate.Height = 24;
            this.dgwEmployee.Size = new System.Drawing.Size(1094, 270);
            this.dgwEmployee.TabIndex = 5;
            this.dgwEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwEmployee_CellClick);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1128, 632);
            this.Controls.Add(this.lblEmployeeIdSearch);
            this.Controls.Add(this.tbxEmployeeIdSearch);
            this.Controls.Add(this.gbxEmployeeDelete);
            this.Controls.Add(this.gbxEmployeeUpdate);
            this.Controls.Add(this.gbxEmployeeAdd);
            this.Controls.Add(this.dgwEmployee);
            this.Name = "FormEmployee";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            this.gbxEmployeeDelete.ResumeLayout(false);
            this.gbxEmployeeDelete.PerformLayout();
            this.gbxEmployeeUpdate.ResumeLayout(false);
            this.gbxEmployeeUpdate.PerformLayout();
            this.gbxEmployeeAdd.ResumeLayout(false);
            this.gbxEmployeeAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeIdSearch;
        private System.Windows.Forms.TextBox tbxEmployeeIdSearch;
        private System.Windows.Forms.GroupBox gbxEmployeeDelete;
        private System.Windows.Forms.Button btnEmployeeDelete;
        private System.Windows.Forms.TextBox tbxEmployeeIdDelete;
        private System.Windows.Forms.Label lblEmployeeIdDelete;
        private System.Windows.Forms.GroupBox gbxEmployeeUpdate;
        private System.Windows.Forms.Label lblParkingSpaceIdUpdate;
        private System.Windows.Forms.TextBox tbxParkingSpaceIdUpdate;
        private System.Windows.Forms.Button btnEmployeeUpdate;
        private System.Windows.Forms.TextBox tbxEmployeeLastNameUpdate;
        private System.Windows.Forms.TextBox tbxEmployeeFirstNameUpdate;
        private System.Windows.Forms.TextBox tbxEmployeeSalaryUpdate;
        private System.Windows.Forms.Label lblEmployeeFirstNameUpdate;
        private System.Windows.Forms.Label lblEmployeeLastNameUpdate;
        private System.Windows.Forms.Label lblEmployeeSalaryUpdate;
        private System.Windows.Forms.GroupBox gbxEmployeeAdd;
        private System.Windows.Forms.Label lblParkingSpaceIdAdd;
        private System.Windows.Forms.TextBox tbxParkingSpaceIdAdd;
        private System.Windows.Forms.Button btnEmployeeAdd;
        private System.Windows.Forms.TextBox tbxEmployeeLastNameAdd;
        private System.Windows.Forms.TextBox tbxEmployeeSalaryAdd;
        private System.Windows.Forms.TextBox tbxEmployeeFirstNameAdd;
        private System.Windows.Forms.Label lblEmployeeSalaryAdd;
        private System.Windows.Forms.Label lblEmployeeLastNameAdd;
        private System.Windows.Forms.Label lblEmployeeFirstNameAdd;
        private System.Windows.Forms.DataGridView dgwEmployee;
    }
}