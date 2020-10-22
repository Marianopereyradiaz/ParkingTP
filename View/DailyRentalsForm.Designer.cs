namespace TP_Parking
{
    partial class DailyRentalsForm
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
            this.dataGridViewDaily = new System.Windows.Forms.DataGridView();
            this.GarageNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleDomain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Finish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaily)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDaily
            // 
            this.dataGridViewDaily.AllowUserToAddRows = false;
            this.dataGridViewDaily.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewDaily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaily.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GarageNumber,
            this.RentalType,
            this.VehicleType,
            this.VehicleDomain,
            this.Start,
            this.Finish,
            this.Value,
            this.Owner});
            this.dataGridViewDaily.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewDaily.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewDaily.Name = "dataGridViewDaily";
            this.dataGridViewDaily.RowHeadersWidth = 50;
            this.dataGridViewDaily.Size = new System.Drawing.Size(935, 236);
            this.dataGridViewDaily.TabIndex = 1;
            // 
            // GarageNumber
            // 
            this.GarageNumber.HeaderText = "Garage Nº";
            this.GarageNumber.Name = "GarageNumber";
            this.GarageNumber.Width = 80;
            // 
            // RentalType
            // 
            this.RentalType.HeaderText = "Rental Type";
            this.RentalType.Name = "RentalType";
            // 
            // VehicleType
            // 
            this.VehicleType.HeaderText = "Vehicle Type";
            this.VehicleType.Name = "VehicleType";
            // 
            // VehicleDomain
            // 
            this.VehicleDomain.HeaderText = "VehicleDomain";
            this.VehicleDomain.Name = "VehicleDomain";
            // 
            // Start
            // 
            this.Start.HeaderText = "Start";
            this.Start.Name = "Start";
            this.Start.Width = 150;
            // 
            // Finish
            // 
            this.Finish.HeaderText = "Finish";
            this.Finish.Name = "Finish";
            this.Finish.Width = 150;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            // 
            // Owner
            // 
            this.Owner.HeaderText = "Owner";
            this.Owner.Name = "Owner";
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(377, 301);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(129, 47);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click_1);
            // 
            // DailyRentalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 385);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.dataGridViewDaily);
            this.Name = "DailyRentalsForm";
            this.Text = "Daily Rentals";
            this.Load += new System.EventHandler(this.DailyRentalsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaily)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDaily;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn GarageNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalType;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleDomain;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn Finish;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Owner;
    }
}
