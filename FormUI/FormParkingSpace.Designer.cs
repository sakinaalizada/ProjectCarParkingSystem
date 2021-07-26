
namespace FormUI
{
    partial class FormParkingSpace
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
            this.lblParkingSpaceIdSearch = new System.Windows.Forms.Label();
            this.tbxParkingSpaceIdSearch = new System.Windows.Forms.TextBox();
            this.gbxParkingSpaceDelete = new System.Windows.Forms.GroupBox();
            this.btnParkingSpaceDelete = new System.Windows.Forms.Button();
            this.tbxParkingSpaceIdDelete = new System.Windows.Forms.TextBox();
            this.lblParkingSpaceIdDelete = new System.Windows.Forms.Label();
            this.gbxParkingSpaceUpdate = new System.Windows.Forms.GroupBox();
            this.btnParkingSpaceUpdate = new System.Windows.Forms.Button();
            this.tbxTotalNumberParkingSpotsUpdate = new System.Windows.Forms.TextBox();
            this.tbxParkingSpaceAdressUpdate = new System.Windows.Forms.TextBox();
            this.tbxChargeForHourUpdate = new System.Windows.Forms.TextBox();
            this.lblParkingSpaceAdressUpdate = new System.Windows.Forms.Label();
            this.lblTotalNumberParkingSpotsUpdate = new System.Windows.Forms.Label();
            this.lblChargeForHourUpdate = new System.Windows.Forms.Label();
            this.gbxParkingSpaceAdd = new System.Windows.Forms.GroupBox();
            this.btnParkingSpaceAdd = new System.Windows.Forms.Button();
            this.tbxTotalNumberParkingSpotsAdd = new System.Windows.Forms.TextBox();
            this.tbxChargeForHourAdd = new System.Windows.Forms.TextBox();
            this.tbxParkingSpaceAdressAdd = new System.Windows.Forms.TextBox();
            this.lblChargeForHourAdd = new System.Windows.Forms.Label();
            this.lblTotalNumberParkingSpotsAdd = new System.Windows.Forms.Label();
            this.lblParkingSpaceAdressAdd = new System.Windows.Forms.Label();
            this.dgwParkingSpace = new System.Windows.Forms.DataGridView();
            this.gbxParkingSpaceDelete.SuspendLayout();
            this.gbxParkingSpaceUpdate.SuspendLayout();
            this.gbxParkingSpaceAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwParkingSpace)).BeginInit();
            this.SuspendLayout();
            // 
            // lblParkingSpaceIdSearch
            // 
            this.lblParkingSpaceIdSearch.AutoSize = true;
            this.lblParkingSpaceIdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParkingSpaceIdSearch.Location = new System.Drawing.Point(604, 21);
            this.lblParkingSpaceIdSearch.Name = "lblParkingSpaceIdSearch";
            this.lblParkingSpaceIdSearch.Size = new System.Drawing.Size(202, 29);
            this.lblParkingSpaceIdSearch.TabIndex = 14;
            this.lblParkingSpaceIdSearch.Text = "Parking Space Id:";
            // 
            // tbxParkingSpaceIdSearch
            // 
            this.tbxParkingSpaceIdSearch.Location = new System.Drawing.Point(816, 28);
            this.tbxParkingSpaceIdSearch.Name = "tbxParkingSpaceIdSearch";
            this.tbxParkingSpaceIdSearch.Size = new System.Drawing.Size(187, 22);
            this.tbxParkingSpaceIdSearch.TabIndex = 13;
            this.tbxParkingSpaceIdSearch.TextChanged += new System.EventHandler(this.tbxParkingSpaceIdSearch_TextChanged);
            // 
            // gbxParkingSpaceDelete
            // 
            this.gbxParkingSpaceDelete.Controls.Add(this.btnParkingSpaceDelete);
            this.gbxParkingSpaceDelete.Controls.Add(this.tbxParkingSpaceIdDelete);
            this.gbxParkingSpaceDelete.Controls.Add(this.lblParkingSpaceIdDelete);
            this.gbxParkingSpaceDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxParkingSpaceDelete.Location = new System.Drawing.Point(859, 372);
            this.gbxParkingSpaceDelete.Name = "gbxParkingSpaceDelete";
            this.gbxParkingSpaceDelete.Size = new System.Drawing.Size(189, 274);
            this.gbxParkingSpaceDelete.TabIndex = 12;
            this.gbxParkingSpaceDelete.TabStop = false;
            this.gbxParkingSpaceDelete.Text = "Delete";
            // 
            // btnParkingSpaceDelete
            // 
            this.btnParkingSpaceDelete.Location = new System.Drawing.Point(58, 220);
            this.btnParkingSpaceDelete.Name = "btnParkingSpaceDelete";
            this.btnParkingSpaceDelete.Size = new System.Drawing.Size(101, 36);
            this.btnParkingSpaceDelete.TabIndex = 2;
            this.btnParkingSpaceDelete.Text = "Delete";
            this.btnParkingSpaceDelete.UseVisualStyleBackColor = true;
            this.btnParkingSpaceDelete.Click += new System.EventHandler(this.btnParkingSpaceDelete_Click);
            // 
            // tbxParkingSpaceIdDelete
            // 
            this.tbxParkingSpaceIdDelete.Location = new System.Drawing.Point(8, 80);
            this.tbxParkingSpaceIdDelete.Name = "tbxParkingSpaceIdDelete";
            this.tbxParkingSpaceIdDelete.Size = new System.Drawing.Size(100, 30);
            this.tbxParkingSpaceIdDelete.TabIndex = 1;
            // 
            // lblParkingSpaceIdDelete
            // 
            this.lblParkingSpaceIdDelete.AutoSize = true;
            this.lblParkingSpaceIdDelete.Location = new System.Drawing.Point(6, 39);
            this.lblParkingSpaceIdDelete.Name = "lblParkingSpaceIdDelete";
            this.lblParkingSpaceIdDelete.Size = new System.Drawing.Size(161, 25);
            this.lblParkingSpaceIdDelete.TabIndex = 0;
            this.lblParkingSpaceIdDelete.Text = "Parking Space Id";
            // 
            // gbxParkingSpaceUpdate
            // 
            this.gbxParkingSpaceUpdate.Controls.Add(this.btnParkingSpaceUpdate);
            this.gbxParkingSpaceUpdate.Controls.Add(this.tbxTotalNumberParkingSpotsUpdate);
            this.gbxParkingSpaceUpdate.Controls.Add(this.tbxParkingSpaceAdressUpdate);
            this.gbxParkingSpaceUpdate.Controls.Add(this.tbxChargeForHourUpdate);
            this.gbxParkingSpaceUpdate.Controls.Add(this.lblParkingSpaceAdressUpdate);
            this.gbxParkingSpaceUpdate.Controls.Add(this.lblTotalNumberParkingSpotsUpdate);
            this.gbxParkingSpaceUpdate.Controls.Add(this.lblChargeForHourUpdate);
            this.gbxParkingSpaceUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxParkingSpaceUpdate.Location = new System.Drawing.Point(427, 372);
            this.gbxParkingSpaceUpdate.Name = "gbxParkingSpaceUpdate";
            this.gbxParkingSpaceUpdate.Size = new System.Drawing.Size(379, 275);
            this.gbxParkingSpaceUpdate.TabIndex = 10;
            this.gbxParkingSpaceUpdate.TabStop = false;
            this.gbxParkingSpaceUpdate.Text = "Update";
            // 
            // btnParkingSpaceUpdate
            // 
            this.btnParkingSpaceUpdate.Location = new System.Drawing.Point(222, 220);
            this.btnParkingSpaceUpdate.Name = "btnParkingSpaceUpdate";
            this.btnParkingSpaceUpdate.Size = new System.Drawing.Size(118, 36);
            this.btnParkingSpaceUpdate.TabIndex = 7;
            this.btnParkingSpaceUpdate.Text = "Update";
            this.btnParkingSpaceUpdate.UseVisualStyleBackColor = true;
            this.btnParkingSpaceUpdate.Click += new System.EventHandler(this.btnParkingSpaceUpdate_Click);
            // 
            // tbxTotalNumberParkingSpotsUpdate
            // 
            this.tbxTotalNumberParkingSpotsUpdate.Location = new System.Drawing.Point(25, 141);
            this.tbxTotalNumberParkingSpotsUpdate.Name = "tbxTotalNumberParkingSpotsUpdate";
            this.tbxTotalNumberParkingSpotsUpdate.Size = new System.Drawing.Size(100, 30);
            this.tbxTotalNumberParkingSpotsUpdate.TabIndex = 12;
            // 
            // tbxParkingSpaceAdressUpdate
            // 
            this.tbxParkingSpaceAdressUpdate.Location = new System.Drawing.Point(25, 67);
            this.tbxParkingSpaceAdressUpdate.Name = "tbxParkingSpaceAdressUpdate";
            this.tbxParkingSpaceAdressUpdate.Size = new System.Drawing.Size(100, 30);
            this.tbxParkingSpaceAdressUpdate.TabIndex = 10;
            // 
            // tbxChargeForHourUpdate
            // 
            this.tbxChargeForHourUpdate.Location = new System.Drawing.Point(25, 223);
            this.tbxChargeForHourUpdate.Name = "tbxChargeForHourUpdate";
            this.tbxChargeForHourUpdate.Size = new System.Drawing.Size(100, 30);
            this.tbxChargeForHourUpdate.TabIndex = 11;
            // 
            // lblParkingSpaceAdressUpdate
            // 
            this.lblParkingSpaceAdressUpdate.AutoSize = true;
            this.lblParkingSpaceAdressUpdate.Location = new System.Drawing.Point(20, 39);
            this.lblParkingSpaceAdressUpdate.Name = "lblParkingSpaceAdressUpdate";
            this.lblParkingSpaceAdressUpdate.Size = new System.Drawing.Size(207, 25);
            this.lblParkingSpaceAdressUpdate.TabIndex = 7;
            this.lblParkingSpaceAdressUpdate.Text = "Parking Space Adress";
            // 
            // lblTotalNumberParkingSpotsUpdate
            // 
            this.lblTotalNumberParkingSpotsUpdate.AutoSize = true;
            this.lblTotalNumberParkingSpotsUpdate.Location = new System.Drawing.Point(20, 113);
            this.lblTotalNumberParkingSpotsUpdate.Name = "lblTotalNumberParkingSpotsUpdate";
            this.lblTotalNumberParkingSpotsUpdate.Size = new System.Drawing.Size(278, 25);
            this.lblTotalNumberParkingSpotsUpdate.TabIndex = 8;
            this.lblTotalNumberParkingSpotsUpdate.Text = "Total Number of Parking Spots";
            // 
            // lblChargeForHourUpdate
            // 
            this.lblChargeForHourUpdate.AutoSize = true;
            this.lblChargeForHourUpdate.Location = new System.Drawing.Point(20, 189);
            this.lblChargeForHourUpdate.Name = "lblChargeForHourUpdate";
            this.lblChargeForHourUpdate.Size = new System.Drawing.Size(158, 25);
            this.lblChargeForHourUpdate.TabIndex = 9;
            this.lblChargeForHourUpdate.Text = "Charge For Hour";
            // 
            // gbxParkingSpaceAdd
            // 
            this.gbxParkingSpaceAdd.Controls.Add(this.btnParkingSpaceAdd);
            this.gbxParkingSpaceAdd.Controls.Add(this.tbxTotalNumberParkingSpotsAdd);
            this.gbxParkingSpaceAdd.Controls.Add(this.tbxChargeForHourAdd);
            this.gbxParkingSpaceAdd.Controls.Add(this.tbxParkingSpaceAdressAdd);
            this.gbxParkingSpaceAdd.Controls.Add(this.lblChargeForHourAdd);
            this.gbxParkingSpaceAdd.Controls.Add(this.lblTotalNumberParkingSpotsAdd);
            this.gbxParkingSpaceAdd.Controls.Add(this.lblParkingSpaceAdressAdd);
            this.gbxParkingSpaceAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxParkingSpaceAdd.Location = new System.Drawing.Point(12, 372);
            this.gbxParkingSpaceAdd.Name = "gbxParkingSpaceAdd";
            this.gbxParkingSpaceAdd.Size = new System.Drawing.Size(379, 275);
            this.gbxParkingSpaceAdd.TabIndex = 11;
            this.gbxParkingSpaceAdd.TabStop = false;
            this.gbxParkingSpaceAdd.Text = "Add";
            // 
            // btnParkingSpaceAdd
            // 
            this.btnParkingSpaceAdd.Location = new System.Drawing.Point(214, 217);
            this.btnParkingSpaceAdd.Name = "btnParkingSpaceAdd";
            this.btnParkingSpaceAdd.Size = new System.Drawing.Size(118, 36);
            this.btnParkingSpaceAdd.TabIndex = 6;
            this.btnParkingSpaceAdd.Text = "Add";
            this.btnParkingSpaceAdd.UseVisualStyleBackColor = true;
            this.btnParkingSpaceAdd.Click += new System.EventHandler(this.btnParkingSpaceAdd_Click);
            // 
            // tbxTotalNumberParkingSpotsAdd
            // 
            this.tbxTotalNumberParkingSpotsAdd.Location = new System.Drawing.Point(11, 141);
            this.tbxTotalNumberParkingSpotsAdd.Name = "tbxTotalNumberParkingSpotsAdd";
            this.tbxTotalNumberParkingSpotsAdd.Size = new System.Drawing.Size(100, 30);
            this.tbxTotalNumberParkingSpotsAdd.TabIndex = 5;
            // 
            // tbxChargeForHourAdd
            // 
            this.tbxChargeForHourAdd.Location = new System.Drawing.Point(11, 223);
            this.tbxChargeForHourAdd.Name = "tbxChargeForHourAdd";
            this.tbxChargeForHourAdd.Size = new System.Drawing.Size(100, 30);
            this.tbxChargeForHourAdd.TabIndex = 4;
            // 
            // tbxParkingSpaceAdressAdd
            // 
            this.tbxParkingSpaceAdressAdd.Location = new System.Drawing.Point(11, 67);
            this.tbxParkingSpaceAdressAdd.Name = "tbxParkingSpaceAdressAdd";
            this.tbxParkingSpaceAdressAdd.Size = new System.Drawing.Size(100, 30);
            this.tbxParkingSpaceAdressAdd.TabIndex = 3;
            // 
            // lblChargeForHourAdd
            // 
            this.lblChargeForHourAdd.AutoSize = true;
            this.lblChargeForHourAdd.Location = new System.Drawing.Point(6, 189);
            this.lblChargeForHourAdd.Name = "lblChargeForHourAdd";
            this.lblChargeForHourAdd.Size = new System.Drawing.Size(158, 25);
            this.lblChargeForHourAdd.TabIndex = 2;
            this.lblChargeForHourAdd.Text = "Charge For Hour";
            // 
            // lblTotalNumberParkingSpotsAdd
            // 
            this.lblTotalNumberParkingSpotsAdd.AutoSize = true;
            this.lblTotalNumberParkingSpotsAdd.Location = new System.Drawing.Point(6, 113);
            this.lblTotalNumberParkingSpotsAdd.Name = "lblTotalNumberParkingSpotsAdd";
            this.lblTotalNumberParkingSpotsAdd.Size = new System.Drawing.Size(278, 25);
            this.lblTotalNumberParkingSpotsAdd.TabIndex = 1;
            this.lblTotalNumberParkingSpotsAdd.Text = "Total Number of Parking Spots";
            // 
            // lblParkingSpaceAdressAdd
            // 
            this.lblParkingSpaceAdressAdd.AutoSize = true;
            this.lblParkingSpaceAdressAdd.Location = new System.Drawing.Point(6, 39);
            this.lblParkingSpaceAdressAdd.Name = "lblParkingSpaceAdressAdd";
            this.lblParkingSpaceAdressAdd.Size = new System.Drawing.Size(207, 25);
            this.lblParkingSpaceAdressAdd.TabIndex = 0;
            this.lblParkingSpaceAdressAdd.Text = "Parking Space Adress";
            // 
            // dgwParkingSpace
            // 
            this.dgwParkingSpace.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwParkingSpace.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgwParkingSpace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwParkingSpace.Location = new System.Drawing.Point(12, 69);
            this.dgwParkingSpace.Name = "dgwParkingSpace";
            this.dgwParkingSpace.RowHeadersWidth = 51;
            this.dgwParkingSpace.RowTemplate.Height = 24;
            this.dgwParkingSpace.Size = new System.Drawing.Size(1036, 276);
            this.dgwParkingSpace.TabIndex = 9;
            this.dgwParkingSpace.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwParkingSpace_CellClick);
            // 
            // FormParkingSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1077, 680);
            this.Controls.Add(this.lblParkingSpaceIdSearch);
            this.Controls.Add(this.tbxParkingSpaceIdSearch);
            this.Controls.Add(this.gbxParkingSpaceDelete);
            this.Controls.Add(this.gbxParkingSpaceUpdate);
            this.Controls.Add(this.gbxParkingSpaceAdd);
            this.Controls.Add(this.dgwParkingSpace);
            this.Name = "FormParkingSpace";
            this.Text = "Parking Spaces";
            this.Load += new System.EventHandler(this.FormParkingSpace_Load);
            this.gbxParkingSpaceDelete.ResumeLayout(false);
            this.gbxParkingSpaceDelete.PerformLayout();
            this.gbxParkingSpaceUpdate.ResumeLayout(false);
            this.gbxParkingSpaceUpdate.PerformLayout();
            this.gbxParkingSpaceAdd.ResumeLayout(false);
            this.gbxParkingSpaceAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwParkingSpace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParkingSpaceIdSearch;
        private System.Windows.Forms.TextBox tbxParkingSpaceIdSearch;
        private System.Windows.Forms.GroupBox gbxParkingSpaceDelete;
        private System.Windows.Forms.Button btnParkingSpaceDelete;
        private System.Windows.Forms.TextBox tbxParkingSpaceIdDelete;
        private System.Windows.Forms.Label lblParkingSpaceIdDelete;
        private System.Windows.Forms.GroupBox gbxParkingSpaceUpdate;
        private System.Windows.Forms.Button btnParkingSpaceUpdate;
        private System.Windows.Forms.TextBox tbxTotalNumberParkingSpotsUpdate;
        private System.Windows.Forms.TextBox tbxParkingSpaceAdressUpdate;
        private System.Windows.Forms.TextBox tbxChargeForHourUpdate;
        private System.Windows.Forms.Label lblParkingSpaceAdressUpdate;
        private System.Windows.Forms.Label lblTotalNumberParkingSpotsUpdate;
        private System.Windows.Forms.Label lblChargeForHourUpdate;
        private System.Windows.Forms.GroupBox gbxParkingSpaceAdd;
        private System.Windows.Forms.Button btnParkingSpaceAdd;
        private System.Windows.Forms.TextBox tbxTotalNumberParkingSpotsAdd;
        private System.Windows.Forms.TextBox tbxChargeForHourAdd;
        private System.Windows.Forms.TextBox tbxParkingSpaceAdressAdd;
        private System.Windows.Forms.Label lblChargeForHourAdd;
        private System.Windows.Forms.Label lblTotalNumberParkingSpotsAdd;
        private System.Windows.Forms.Label lblParkingSpaceAdressAdd;
        private System.Windows.Forms.DataGridView dgwParkingSpace;
    }
}