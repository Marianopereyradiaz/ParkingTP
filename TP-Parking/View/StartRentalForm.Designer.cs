﻿namespace TP_Parking
{
    partial class StartRentalForm
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
            this.buttonExitRental = new System.Windows.Forms.Button();
            this.buttonConfirmRental = new System.Windows.Forms.Button();
            this.textBoxDomain = new System.Windows.Forms.TextBox();
            this.labelRentalType = new System.Windows.Forms.Label();
            this.labelVehicleType = new System.Windows.Forms.Label();
            this.labelDomain = new System.Windows.Forms.Label();
            this.labelGarage = new System.Windows.Forms.Label();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.textBoxGarage = new System.Windows.Forms.TextBox();
            this.labelOwner = new System.Windows.Forms.Label();
            this.textBoxOwner = new System.Windows.Forms.TextBox();
            this.comboBoxVehicleSel = new System.Windows.Forms.ComboBox();
            this.comboBoxRentalType = new System.Windows.Forms.ComboBox();
            this.labelMonths = new System.Windows.Forms.Label();
            this.comboBoxMonths = new System.Windows.Forms.ComboBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.labelValueShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonExitRental
            // 
            this.buttonExitRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExitRental.Location = new System.Drawing.Point(97, 448);
            this.buttonExitRental.Name = "buttonExitRental";
            this.buttonExitRental.Size = new System.Drawing.Size(121, 33);
            this.buttonExitRental.TabIndex = 9;
            this.buttonExitRental.Text = "Cancelar";
            this.buttonExitRental.UseVisualStyleBackColor = true;
            this.buttonExitRental.Click += new System.EventHandler(this.buttonExitRental_Click);
            // 
            // buttonConfirmRental
            // 
            this.buttonConfirmRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmRental.Location = new System.Drawing.Point(97, 395);
            this.buttonConfirmRental.Name = "buttonConfirmRental";
            this.buttonConfirmRental.Size = new System.Drawing.Size(121, 33);
            this.buttonConfirmRental.TabIndex = 8;
            this.buttonConfirmRental.Text = "Confirmar";
            this.buttonConfirmRental.UseVisualStyleBackColor = true;
            this.buttonConfirmRental.Click += new System.EventHandler(this.buttonConfirmRental_Click);
            // 
            // textBoxDomain
            // 
            this.textBoxDomain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDomain.Location = new System.Drawing.Point(169, 173);
            this.textBoxDomain.Name = "textBoxDomain";
            this.textBoxDomain.Size = new System.Drawing.Size(74, 22);
            this.textBoxDomain.TabIndex = 4;
            // 
            // labelRentalType
            // 
            this.labelRentalType.AutoSize = true;
            this.labelRentalType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRentalType.Location = new System.Drawing.Point(48, 45);
            this.labelRentalType.Name = "labelRentalType";
            this.labelRentalType.Size = new System.Drawing.Size(106, 16);
            this.labelRentalType.TabIndex = 5;
            this.labelRentalType.Text = "Tipo de Alquiler:";
            // 
            // labelVehicleType
            // 
            this.labelVehicleType.AutoSize = true;
            this.labelVehicleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVehicleType.Location = new System.Drawing.Point(41, 91);
            this.labelVehicleType.Name = "labelVehicleType";
            this.labelVehicleType.Size = new System.Drawing.Size(113, 16);
            this.labelVehicleType.TabIndex = 7;
            this.labelVehicleType.Text = "Tipo de Vehiculo:";
            // 
            // labelDomain
            // 
            this.labelDomain.AutoSize = true;
            this.labelDomain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDomain.Location = new System.Drawing.Point(93, 173);
            this.labelDomain.Name = "labelDomain";
            this.labelDomain.Size = new System.Drawing.Size(57, 16);
            this.labelDomain.TabIndex = 8;
            this.labelDomain.Text = "Patente:";
            // 
            // labelGarage
            // 
            this.labelGarage.AutoSize = true;
            this.labelGarage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGarage.Location = new System.Drawing.Point(94, 129);
            this.labelGarage.Name = "labelGarage";
            this.labelGarage.Size = new System.Drawing.Size(60, 16);
            this.labelGarage.TabIndex = 9;
            this.labelGarage.Text = "Garage: ";
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBrand.Location = new System.Drawing.Point(169, 215);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(73, 22);
            this.textBoxBrand.TabIndex = 5;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModel.Location = new System.Drawing.Point(170, 253);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(73, 22);
            this.textBoxModel.TabIndex = 6;
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrand.Location = new System.Drawing.Point(101, 215);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(49, 16);
            this.labelBrand.TabIndex = 12;
            this.labelBrand.Text = "Marca:";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModel.Location = new System.Drawing.Point(94, 256);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(57, 16);
            this.labelModel.TabIndex = 13;
            this.labelModel.Text = "Modelo:";
            // 
            // textBoxGarage
            // 
            this.textBoxGarage.Enabled = false;
            this.textBoxGarage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGarage.Location = new System.Drawing.Point(169, 129);
            this.textBoxGarage.Name = "textBoxGarage";
            this.textBoxGarage.Size = new System.Drawing.Size(74, 22);
            this.textBoxGarage.TabIndex = 3;
            // 
            // labelOwner
            // 
            this.labelOwner.AutoSize = true;
            this.labelOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOwner.Location = new System.Drawing.Point(100, 291);
            this.labelOwner.Name = "labelOwner";
            this.labelOwner.Size = new System.Drawing.Size(51, 16);
            this.labelOwner.TabIndex = 14;
            this.labelOwner.Text = "Dueño:";
            // 
            // textBoxOwner
            // 
            this.textBoxOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOwner.Location = new System.Drawing.Point(170, 288);
            this.textBoxOwner.Name = "textBoxOwner";
            this.textBoxOwner.Size = new System.Drawing.Size(73, 22);
            this.textBoxOwner.TabIndex = 7;
            // 
            // comboBoxVehicleSel
            // 
            this.comboBoxVehicleSel.FormattingEnabled = true;
            this.comboBoxVehicleSel.Items.AddRange(new object[] {
            "Camioneta",
            "Auto",
            "Moto"});
            this.comboBoxVehicleSel.Location = new System.Drawing.Point(169, 91);
            this.comboBoxVehicleSel.Name = "comboBoxVehicleSel";
            this.comboBoxVehicleSel.Size = new System.Drawing.Size(75, 21);
            this.comboBoxVehicleSel.TabIndex = 16;
            // 
            // comboBoxRentalType
            // 
            this.comboBoxRentalType.FormattingEnabled = true;
            this.comboBoxRentalType.Items.AddRange(new object[] {
            "Hora",
            "Mes"});
            this.comboBoxRentalType.Location = new System.Drawing.Point(169, 44);
            this.comboBoxRentalType.Name = "comboBoxRentalType";
            this.comboBoxRentalType.Size = new System.Drawing.Size(75, 21);
            this.comboBoxRentalType.TabIndex = 17;
            this.comboBoxRentalType.SelectedIndexChanged += new System.EventHandler(this.comboBoxRentalType_SelectedIndexChanged_1);
            // 
            // labelMonths
            // 
            this.labelMonths.AutoSize = true;
            this.labelMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonths.Location = new System.Drawing.Point(22, 326);
            this.labelMonths.Name = "labelMonths";
            this.labelMonths.Size = new System.Drawing.Size(128, 16);
            this.labelMonths.TabIndex = 19;
            this.labelMonths.Text = "Cantidad de Meses:";
            // 
            // comboBoxMonths
            // 
            this.comboBoxMonths.FormattingEnabled = true;
            this.comboBoxMonths.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxMonths.Location = new System.Drawing.Point(169, 326);
            this.comboBoxMonths.Name = "comboBoxMonths";
            this.comboBoxMonths.Size = new System.Drawing.Size(73, 21);
            this.comboBoxMonths.TabIndex = 20;
            this.comboBoxMonths.SelectedIndexChanged += new System.EventHandler(this.comboBoxMonths_SelectedIndexChanged);
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValue.Location = new System.Drawing.Point(107, 361);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(43, 16);
            this.labelValue.TabIndex = 21;
            this.labelValue.Text = "Valor:";
            // 
            // labelValueShow
            // 
            this.labelValueShow.AutoSize = true;
            this.labelValueShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValueShow.Location = new System.Drawing.Point(167, 361);
            this.labelValueShow.Name = "labelValueShow";
            this.labelValueShow.Size = new System.Drawing.Size(0, 16);
            this.labelValueShow.TabIndex = 22;
            // 
            // StartRentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 514);
            this.Controls.Add(this.labelValueShow);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.comboBoxMonths);
            this.Controls.Add(this.labelMonths);
            this.Controls.Add(this.comboBoxRentalType);
            this.Controls.Add(this.comboBoxVehicleSel);
            this.Controls.Add(this.textBoxOwner);
            this.Controls.Add(this.labelOwner);
            this.Controls.Add(this.textBoxGarage);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.labelGarage);
            this.Controls.Add(this.labelDomain);
            this.Controls.Add(this.labelVehicleType);
            this.Controls.Add(this.labelRentalType);
            this.Controls.Add(this.textBoxDomain);
            this.Controls.Add(this.buttonConfirmRental);
            this.Controls.Add(this.buttonExitRental);
            this.Name = "StartRentalForm";
            this.Text = "Empezar Alquiler";
            this.Load += new System.EventHandler(this.StartRentalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExitRental;
        private System.Windows.Forms.Button buttonConfirmRental;
        private System.Windows.Forms.TextBox textBoxDomain;
        private System.Windows.Forms.Label labelRentalType;
        private System.Windows.Forms.Label labelVehicleType;
        private System.Windows.Forms.Label labelDomain;
        private System.Windows.Forms.Label labelGarage;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.TextBox textBoxGarage;
        private System.Windows.Forms.Label labelOwner;
        private System.Windows.Forms.TextBox textBoxOwner;
        private System.Windows.Forms.ComboBox comboBoxVehicleType;
        private System.Windows.Forms.ComboBox comboBoxVehicleSel;
        private System.Windows.Forms.ComboBox comboBoxRentalType;
        private System.Windows.Forms.Label labelMonths;
        private System.Windows.Forms.ComboBox comboBoxMonths;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label labelValueShow;
    }
}
