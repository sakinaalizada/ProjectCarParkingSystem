
namespace FormUI
{
    partial class FormCar
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
            this.btnPassiveCars = new System.Windows.Forms.Button();
            this.btnActiveCars = new System.Windows.Forms.Button();
            this.lblCarPlateSearch = new System.Windows.Forms.Label();
            this.tbxCarPlateSearch = new System.Windows.Forms.TextBox();
            this.gbxTotalChargeCalculate = new System.Windows.Forms.GroupBox();
            this.dtpDepartureTimeCalculate = new System.Windows.Forms.DateTimePicker();
            this.tbxTotalChargeCalculate = new System.Windows.Forms.TextBox();
            this.lblTotalChargeCalculate = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tbxCarPlateCalculate = new System.Windows.Forms.TextBox();
            this.lblDepartureTimeCalculate = new System.Windows.Forms.Label();
            this.lblCarPlateClaculate = new System.Windows.Forms.Label();
            this.gbxCarAdd = new System.Windows.Forms.GroupBox();
            this.dtpArrivalTimeAdd = new System.Windows.Forms.DateTimePicker();
            this.tbxParkingSpaceIdAdd = new System.Windows.Forms.TextBox();
            this.lblParkingSpaceIdAdd = new System.Windows.Forms.Label();
            this.btnCarAdd = new System.Windows.Forms.Button();
            this.tbxCarPlateAdd = new System.Windows.Forms.TextBox();
            this.lblArrivalTimeAdd = new System.Windows.Forms.Label();
            this.lblCarPlateAdd = new System.Windows.Forms.Label();
            this.dgwCarAdd = new System.Windows.Forms.DataGridView();
            this.gbxTotalChargeCalculate.SuspendLayout();
            this.gbxCarAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCarAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPassiveCars
            // 
            this.btnPassiveCars.Location = new System.Drawing.Point(205, 27);
            this.btnPassiveCars.Name = "btnPassiveCars";
            this.btnPassiveCars.Size = new System.Drawing.Size(153, 23);
            this.btnPassiveCars.TabIndex = 18;
            this.btnPassiveCars.Text = "Passive Cars";
            this.btnPassiveCars.UseVisualStyleBackColor = true;
            this.btnPassiveCars.Click += new System.EventHandler(this.btnPassiveCars_Click);
            // 
            // btnActiveCars
            // 
            this.btnActiveCars.Location = new System.Drawing.Point(27, 27);
            this.btnActiveCars.Name = "btnActiveCars";
            this.btnActiveCars.Size = new System.Drawing.Size(141, 23);
            this.btnActiveCars.TabIndex = 17;
            this.btnActiveCars.Text = "Active Cars";
            this.btnActiveCars.UseVisualStyleBackColor = true;
            this.btnActiveCars.Click += new System.EventHandler(this.btnActiveCars_Click);
            // 
            // lblCarPlateSearch
            // 
            this.lblCarPlateSearch.AutoSize = true;
            this.lblCarPlateSearch.Location = new System.Drawing.Point(638, 33);
            this.lblCarPlateSearch.Name = "lblCarPlateSearch";
            this.lblCarPlateSearch.Size = new System.Drawing.Size(70, 17);
            this.lblCarPlateSearch.TabIndex = 16;
            this.lblCarPlateSearch.Text = "Car Plate:";
            // 
            // tbxCarPlateSearch
            // 
            this.tbxCarPlateSearch.Location = new System.Drawing.Point(723, 33);
            this.tbxCarPlateSearch.Name = "tbxCarPlateSearch";
            this.tbxCarPlateSearch.Size = new System.Drawing.Size(152, 22);
            this.tbxCarPlateSearch.TabIndex = 15;
            this.tbxCarPlateSearch.TextChanged += new System.EventHandler(this.tbxCarPlateSearch_TextChanged);
            // 
            // gbxTotalChargeCalculate
            // 
            this.gbxTotalChargeCalculate.Controls.Add(this.dtpDepartureTimeCalculate);
            this.gbxTotalChargeCalculate.Controls.Add(this.tbxTotalChargeCalculate);
            this.gbxTotalChargeCalculate.Controls.Add(this.lblTotalChargeCalculate);
            this.gbxTotalChargeCalculate.Controls.Add(this.btnCalculate);
            this.gbxTotalChargeCalculate.Controls.Add(this.tbxCarPlateCalculate);
            this.gbxTotalChargeCalculate.Controls.Add(this.lblDepartureTimeCalculate);
            this.gbxTotalChargeCalculate.Controls.Add(this.lblCarPlateClaculate);
            this.gbxTotalChargeCalculate.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTotalChargeCalculate.Location = new System.Drawing.Point(626, 301);
            this.gbxTotalChargeCalculate.Name = "gbxTotalChargeCalculate";
            this.gbxTotalChargeCalculate.Size = new System.Drawing.Size(386, 262);
            this.gbxTotalChargeCalculate.TabIndex = 14;
            this.gbxTotalChargeCalculate.TabStop = false;
            this.gbxTotalChargeCalculate.Text = "Calculate Total Charge";
            // 
            // dtpDepartureTimeCalculate
            // 
            this.dtpDepartureTimeCalculate.Location = new System.Drawing.Point(149, 89);
            this.dtpDepartureTimeCalculate.Name = "dtpDepartureTimeCalculate";
            this.dtpDepartureTimeCalculate.Size = new System.Drawing.Size(230, 32);
            this.dtpDepartureTimeCalculate.TabIndex = 9;
            // 
            // tbxTotalChargeCalculate
            // 
            this.tbxTotalChargeCalculate.Location = new System.Drawing.Point(149, 189);
            this.tbxTotalChargeCalculate.Name = "tbxTotalChargeCalculate";
            this.tbxTotalChargeCalculate.Size = new System.Drawing.Size(100, 32);
            this.tbxTotalChargeCalculate.TabIndex = 8;
            // 
            // lblTotalChargeCalculate
            // 
            this.lblTotalChargeCalculate.AutoSize = true;
            this.lblTotalChargeCalculate.Location = new System.Drawing.Point(21, 189);
            this.lblTotalChargeCalculate.Name = "lblTotalChargeCalculate";
            this.lblTotalChargeCalculate.Size = new System.Drawing.Size(114, 32);
            this.lblTotalChargeCalculate.TabIndex = 7;
            this.lblTotalChargeCalculate.Text = "Total Charge : ";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(149, 137);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 34);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // tbxCarPlateCalculate
            // 
            this.tbxCarPlateCalculate.Location = new System.Drawing.Point(149, 40);
            this.tbxCarPlateCalculate.Name = "tbxCarPlateCalculate";
            this.tbxCarPlateCalculate.Size = new System.Drawing.Size(100, 32);
            this.tbxCarPlateCalculate.TabIndex = 5;
            // 
            // lblDepartureTimeCalculate
            // 
            this.lblDepartureTimeCalculate.AutoSize = true;
            this.lblDepartureTimeCalculate.Location = new System.Drawing.Point(21, 89);
            this.lblDepartureTimeCalculate.Name = "lblDepartureTimeCalculate";
            this.lblDepartureTimeCalculate.Size = new System.Drawing.Size(122, 32);
            this.lblDepartureTimeCalculate.TabIndex = 2;
            this.lblDepartureTimeCalculate.Text = "Departure Time";
            // 
            // lblCarPlateClaculate
            // 
            this.lblCarPlateClaculate.AutoSize = true;
            this.lblCarPlateClaculate.Location = new System.Drawing.Point(21, 40);
            this.lblCarPlateClaculate.Name = "lblCarPlateClaculate";
            this.lblCarPlateClaculate.Size = new System.Drawing.Size(76, 32);
            this.lblCarPlateClaculate.TabIndex = 0;
            this.lblCarPlateClaculate.Text = "Car Plate";
            // 
            // gbxCarAdd
            // 
            this.gbxCarAdd.Controls.Add(this.dtpArrivalTimeAdd);
            this.gbxCarAdd.Controls.Add(this.tbxParkingSpaceIdAdd);
            this.gbxCarAdd.Controls.Add(this.lblParkingSpaceIdAdd);
            this.gbxCarAdd.Controls.Add(this.btnCarAdd);
            this.gbxCarAdd.Controls.Add(this.tbxCarPlateAdd);
            this.gbxCarAdd.Controls.Add(this.lblArrivalTimeAdd);
            this.gbxCarAdd.Controls.Add(this.lblCarPlateAdd);
            this.gbxCarAdd.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCarAdd.Location = new System.Drawing.Point(54, 301);
            this.gbxCarAdd.Name = "gbxCarAdd";
            this.gbxCarAdd.Size = new System.Drawing.Size(397, 262);
            this.gbxCarAdd.TabIndex = 13;
            this.gbxCarAdd.TabStop = false;
            this.gbxCarAdd.Text = "Add";
            // 
            // dtpArrivalTimeAdd
            // 
            this.dtpArrivalTimeAdd.Location = new System.Drawing.Point(151, 83);
            this.dtpArrivalTimeAdd.Name = "dtpArrivalTimeAdd";
            this.dtpArrivalTimeAdd.Size = new System.Drawing.Size(228, 32);
            this.dtpArrivalTimeAdd.TabIndex = 9;
            // 
            // tbxParkingSpaceIdAdd
            // 
            this.tbxParkingSpaceIdAdd.Location = new System.Drawing.Point(149, 136);
            this.tbxParkingSpaceIdAdd.Name = "tbxParkingSpaceIdAdd";
            this.tbxParkingSpaceIdAdd.Size = new System.Drawing.Size(100, 32);
            this.tbxParkingSpaceIdAdd.TabIndex = 8;
            // 
            // lblParkingSpaceIdAdd
            // 
            this.lblParkingSpaceIdAdd.AutoSize = true;
            this.lblParkingSpaceIdAdd.Location = new System.Drawing.Point(15, 136);
            this.lblParkingSpaceIdAdd.Name = "lblParkingSpaceIdAdd";
            this.lblParkingSpaceIdAdd.Size = new System.Drawing.Size(128, 32);
            this.lblParkingSpaceIdAdd.TabIndex = 7;
            this.lblParkingSpaceIdAdd.Text = "Parking Space Id";
            // 
            // btnCarAdd
            // 
            this.btnCarAdd.Location = new System.Drawing.Point(149, 190);
            this.btnCarAdd.Name = "btnCarAdd";
            this.btnCarAdd.Size = new System.Drawing.Size(100, 34);
            this.btnCarAdd.TabIndex = 6;
            this.btnCarAdd.Text = "Add";
            this.btnCarAdd.UseVisualStyleBackColor = true;
            this.btnCarAdd.Click += new System.EventHandler(this.btnCarAdd_Click);
            // 
            // tbxCarPlateAdd
            // 
            this.tbxCarPlateAdd.Location = new System.Drawing.Point(149, 40);
            this.tbxCarPlateAdd.Name = "tbxCarPlateAdd";
            this.tbxCarPlateAdd.Size = new System.Drawing.Size(100, 32);
            this.tbxCarPlateAdd.TabIndex = 5;
            // 
            // lblArrivalTimeAdd
            // 
            this.lblArrivalTimeAdd.AutoSize = true;
            this.lblArrivalTimeAdd.Location = new System.Drawing.Point(15, 86);
            this.lblArrivalTimeAdd.Name = "lblArrivalTimeAdd";
            this.lblArrivalTimeAdd.Size = new System.Drawing.Size(99, 32);
            this.lblArrivalTimeAdd.TabIndex = 1;
            this.lblArrivalTimeAdd.Text = "Arrival Time";
            // 
            // lblCarPlateAdd
            // 
            this.lblCarPlateAdd.AutoSize = true;
            this.lblCarPlateAdd.Location = new System.Drawing.Point(15, 40);
            this.lblCarPlateAdd.Name = "lblCarPlateAdd";
            this.lblCarPlateAdd.Size = new System.Drawing.Size(76, 32);
            this.lblCarPlateAdd.TabIndex = 0;
            this.lblCarPlateAdd.Text = "Car Plate";
            // 
            // dgwCarAdd
            // 
            this.dgwCarAdd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCarAdd.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgwCarAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCarAdd.Location = new System.Drawing.Point(27, 72);
            this.dgwCarAdd.Name = "dgwCarAdd";
            this.dgwCarAdd.RowHeadersWidth = 51;
            this.dgwCarAdd.RowTemplate.Height = 24;
            this.dgwCarAdd.Size = new System.Drawing.Size(1101, 223);
            this.dgwCarAdd.TabIndex = 12;
            this.dgwCarAdd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCarAdd_CellClick);
           
            // 
            // FormCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1144, 582);
            this.Controls.Add(this.btnPassiveCars);
            this.Controls.Add(this.btnActiveCars);
            this.Controls.Add(this.lblCarPlateSearch);
            this.Controls.Add(this.tbxCarPlateSearch);
            this.Controls.Add(this.gbxTotalChargeCalculate);
            this.Controls.Add(this.gbxCarAdd);
            this.Controls.Add(this.dgwCarAdd);
            this.Name = "FormCar";
            this.Text = "Cars";
            this.Load += new System.EventHandler(this.FormCar_Load);
            this.gbxTotalChargeCalculate.ResumeLayout(false);
            this.gbxTotalChargeCalculate.PerformLayout();
            this.gbxCarAdd.ResumeLayout(false);
            this.gbxCarAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCarAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPassiveCars;
        private System.Windows.Forms.Button btnActiveCars;
        private System.Windows.Forms.Label lblCarPlateSearch;
        private System.Windows.Forms.TextBox tbxCarPlateSearch;
        private System.Windows.Forms.GroupBox gbxTotalChargeCalculate;
        private System.Windows.Forms.DateTimePicker dtpDepartureTimeCalculate;
        private System.Windows.Forms.TextBox tbxTotalChargeCalculate;
        private System.Windows.Forms.Label lblTotalChargeCalculate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox tbxCarPlateCalculate;
        private System.Windows.Forms.Label lblDepartureTimeCalculate;
        private System.Windows.Forms.Label lblCarPlateClaculate;
        private System.Windows.Forms.GroupBox gbxCarAdd;
        private System.Windows.Forms.DateTimePicker dtpArrivalTimeAdd;
        private System.Windows.Forms.TextBox tbxParkingSpaceIdAdd;
        private System.Windows.Forms.Label lblParkingSpaceIdAdd;
        private System.Windows.Forms.Button btnCarAdd;
        private System.Windows.Forms.TextBox tbxCarPlateAdd;
        private System.Windows.Forms.Label lblArrivalTimeAdd;
        private System.Windows.Forms.Label lblCarPlateAdd;
        private System.Windows.Forms.DataGridView dgwCarAdd;
    }
}

