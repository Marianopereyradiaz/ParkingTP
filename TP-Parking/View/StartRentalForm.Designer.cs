namespace TP_Parking
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
            this.labelDomainFormat = new System.Windows.Forms.Label();
            this.comboBoxDomainFormat = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxOldDomain = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxNewDomain = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // buttonExitRental
            // 
            this.buttonExitRental.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonExitRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitRental.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExitRental.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExitRental.Location = new System.Drawing.Point(96, 495);
            this.buttonExitRental.Name = "buttonExitRental";
            this.buttonExitRental.Size = new System.Drawing.Size(121, 33);
            this.buttonExitRental.TabIndex = 11;
            this.buttonExitRental.Text = "Cancelar";
            this.buttonExitRental.UseVisualStyleBackColor = true;
            this.buttonExitRental.Click += new System.EventHandler(this.buttonExitRental_Click);
            // 
            // buttonConfirmRental
            // 
            this.buttonConfirmRental.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonConfirmRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmRental.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmRental.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonConfirmRental.Location = new System.Drawing.Point(96, 442);
            this.buttonConfirmRental.Name = "buttonConfirmRental";
            this.buttonConfirmRental.Size = new System.Drawing.Size(121, 33);
            this.buttonConfirmRental.TabIndex = 10;
            this.buttonConfirmRental.Text = "Confirmar";
            this.buttonConfirmRental.UseVisualStyleBackColor = true;
            this.buttonConfirmRental.Click += new System.EventHandler(this.buttonConfirmRental_Click);
            // 
            // labelRentalType
            // 
            this.labelRentalType.AutoSize = true;
            this.labelRentalType.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRentalType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelRentalType.Location = new System.Drawing.Point(48, 45);
            this.labelRentalType.Name = "labelRentalType";
            this.labelRentalType.Size = new System.Drawing.Size(110, 18);
            this.labelRentalType.TabIndex = 5;
            this.labelRentalType.Text = "Tipo de Alquiler:";
            // 
            // labelVehicleType
            // 
            this.labelVehicleType.AutoSize = true;
            this.labelVehicleType.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVehicleType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelVehicleType.Location = new System.Drawing.Point(41, 91);
            this.labelVehicleType.Name = "labelVehicleType";
            this.labelVehicleType.Size = new System.Drawing.Size(113, 18);
            this.labelVehicleType.TabIndex = 7;
            this.labelVehicleType.Text = "Tipo de Vehiculo:";
            // 
            // labelDomain
            // 
            this.labelDomain.AutoSize = true;
            this.labelDomain.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDomain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDomain.Location = new System.Drawing.Point(93, 206);
            this.labelDomain.Name = "labelDomain";
            this.labelDomain.Size = new System.Drawing.Size(57, 18);
            this.labelDomain.TabIndex = 8;
            this.labelDomain.Text = "Patente:";
            // 
            // labelGarage
            // 
            this.labelGarage.AutoSize = true;
            this.labelGarage.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGarage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGarage.Location = new System.Drawing.Point(94, 129);
            this.labelGarage.Name = "labelGarage";
            this.labelGarage.Size = new System.Drawing.Size(59, 18);
            this.labelGarage.TabIndex = 9;
            this.labelGarage.Text = "Garage: ";
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxBrand.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBrand.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxBrand.Location = new System.Drawing.Point(169, 247);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(73, 26);
            this.textBoxBrand.TabIndex = 6;
            // 
            // textBoxModel
            // 
            this.textBoxModel.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxModel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxModel.Location = new System.Drawing.Point(170, 285);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(73, 26);
            this.textBoxModel.TabIndex = 7;
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrand.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBrand.Location = new System.Drawing.Point(101, 247);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(50, 18);
            this.labelBrand.TabIndex = 12;
            this.labelBrand.Text = "Marca:";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelModel.Location = new System.Drawing.Point(94, 288);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(56, 18);
            this.labelModel.TabIndex = 13;
            this.labelModel.Text = "Modelo:";
            // 
            // textBoxGarage
            // 
            this.textBoxGarage.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxGarage.Enabled = false;
            this.textBoxGarage.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGarage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxGarage.Location = new System.Drawing.Point(169, 129);
            this.textBoxGarage.Name = "textBoxGarage";
            this.textBoxGarage.Size = new System.Drawing.Size(74, 26);
            this.textBoxGarage.TabIndex = 3;
            // 
            // labelOwner
            // 
            this.labelOwner.AutoSize = true;
            this.labelOwner.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOwner.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelOwner.Location = new System.Drawing.Point(73, 323);
            this.labelOwner.Name = "labelOwner";
            this.labelOwner.Size = new System.Drawing.Size(79, 18);
            this.labelOwner.TabIndex = 14;
            this.labelOwner.Text = "Propietario:";
            // 
            // textBoxOwner
            // 
            this.textBoxOwner.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxOwner.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOwner.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxOwner.Location = new System.Drawing.Point(170, 320);
            this.textBoxOwner.Name = "textBoxOwner";
            this.textBoxOwner.Size = new System.Drawing.Size(73, 26);
            this.textBoxOwner.TabIndex = 8;
            // 
            // comboBoxVehicleSel
            // 
            this.comboBoxVehicleSel.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxVehicleSel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVehicleSel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxVehicleSel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVehicleSel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxVehicleSel.FormattingEnabled = true;
            this.comboBoxVehicleSel.Items.AddRange(new object[] {
            "Camioneta",
            "Auto",
            "Moto"});
            this.comboBoxVehicleSel.Location = new System.Drawing.Point(169, 91);
            this.comboBoxVehicleSel.Name = "comboBoxVehicleSel";
            this.comboBoxVehicleSel.Size = new System.Drawing.Size(75, 26);
            this.comboBoxVehicleSel.TabIndex = 2;
            // 
            // comboBoxRentalType
            // 
            this.comboBoxRentalType.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxRentalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRentalType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxRentalType.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRentalType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxRentalType.FormattingEnabled = true;
            this.comboBoxRentalType.Items.AddRange(new object[] {
            "Hora",
            "Mes"});
            this.comboBoxRentalType.Location = new System.Drawing.Point(169, 44);
            this.comboBoxRentalType.Name = "comboBoxRentalType";
            this.comboBoxRentalType.Size = new System.Drawing.Size(75, 26);
            this.comboBoxRentalType.TabIndex = 1;
            this.comboBoxRentalType.SelectedIndexChanged += new System.EventHandler(this.comboBoxRentalType_SelectedIndexChanged_1);
            // 
            // labelMonths
            // 
            this.labelMonths.AutoSize = true;
            this.labelMonths.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonths.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMonths.Location = new System.Drawing.Point(22, 358);
            this.labelMonths.Name = "labelMonths";
            this.labelMonths.Size = new System.Drawing.Size(126, 18);
            this.labelMonths.TabIndex = 19;
            this.labelMonths.Text = "Cantidad de Meses:";
            // 
            // comboBoxMonths
            // 
            this.comboBoxMonths.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonths.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxMonths.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMonths.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.comboBoxMonths.Location = new System.Drawing.Point(169, 358);
            this.comboBoxMonths.Name = "comboBoxMonths";
            this.comboBoxMonths.Size = new System.Drawing.Size(73, 26);
            this.comboBoxMonths.TabIndex = 9;
            this.comboBoxMonths.SelectedIndexChanged += new System.EventHandler(this.comboBoxMonths_SelectedIndexChanged);
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelValue.Location = new System.Drawing.Point(107, 393);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(44, 18);
            this.labelValue.TabIndex = 21;
            this.labelValue.Text = "Valor:";
            // 
            // labelValueShow
            // 
            this.labelValueShow.AutoSize = true;
            this.labelValueShow.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValueShow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelValueShow.Location = new System.Drawing.Point(167, 393);
            this.labelValueShow.Name = "labelValueShow";
            this.labelValueShow.Size = new System.Drawing.Size(0, 18);
            this.labelValueShow.TabIndex = 22;
            // 
            // labelDomainFormat
            // 
            this.labelDomainFormat.AutoSize = true;
            this.labelDomainFormat.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDomainFormat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDomainFormat.Location = new System.Drawing.Point(38, 171);
            this.labelDomainFormat.Name = "labelDomainFormat";
            this.labelDomainFormat.Size = new System.Drawing.Size(110, 18);
            this.labelDomainFormat.TabIndex = 24;
            this.labelDomainFormat.Text = "Formato Patente:";
            // 
            // comboBoxDomainFormat
            // 
            this.comboBoxDomainFormat.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxDomainFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDomainFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDomainFormat.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDomainFormat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxDomainFormat.FormattingEnabled = true;
            this.comboBoxDomainFormat.Items.AddRange(new object[] {
            "AAA111",
            "11AAA11"});
            this.comboBoxDomainFormat.Location = new System.Drawing.Point(170, 168);
            this.comboBoxDomainFormat.Name = "comboBoxDomainFormat";
            this.comboBoxDomainFormat.Size = new System.Drawing.Size(75, 26);
            this.comboBoxDomainFormat.TabIndex = 4;
            this.comboBoxDomainFormat.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // maskedTextBoxOldDomain
            // 
            this.maskedTextBoxOldDomain.BackColor = System.Drawing.Color.Gainsboro;
            this.maskedTextBoxOldDomain.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBoxOldDomain.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxOldDomain.HidePromptOnLeave = true;
            this.maskedTextBoxOldDomain.HideSelection = false;
            this.maskedTextBoxOldDomain.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.maskedTextBoxOldDomain.Location = new System.Drawing.Point(169, 206);
            this.maskedTextBoxOldDomain.Mask = "LLL000";
            this.maskedTextBoxOldDomain.Name = "maskedTextBoxOldDomain";
            this.maskedTextBoxOldDomain.Size = new System.Drawing.Size(73, 26);
            this.maskedTextBoxOldDomain.TabIndex = 26;
            this.maskedTextBoxOldDomain.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBoxNewDomain
            // 
            this.maskedTextBoxNewDomain.BackColor = System.Drawing.Color.Gainsboro;
            this.maskedTextBoxNewDomain.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBoxNewDomain.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxNewDomain.HidePromptOnLeave = true;
            this.maskedTextBoxNewDomain.HideSelection = false;
            this.maskedTextBoxNewDomain.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.maskedTextBoxNewDomain.Location = new System.Drawing.Point(169, 206);
            this.maskedTextBoxNewDomain.Mask = "00LLL00";
            this.maskedTextBoxNewDomain.Name = "maskedTextBoxNewDomain";
            this.maskedTextBoxNewDomain.Size = new System.Drawing.Size(72, 26);
            this.maskedTextBoxNewDomain.TabIndex = 5;
            this.maskedTextBoxNewDomain.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // StartRentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(330, 550);
            this.Controls.Add(this.maskedTextBoxNewDomain);
            this.Controls.Add(this.maskedTextBoxOldDomain);
            this.Controls.Add(this.comboBoxDomainFormat);
            this.Controls.Add(this.labelDomainFormat);
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
            this.Controls.Add(this.buttonConfirmRental);
            this.Controls.Add(this.buttonExitRental);
            this.Name = "StartRentalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empezar Alquiler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExitRental;
        private System.Windows.Forms.Button buttonConfirmRental;
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
        private System.Windows.Forms.ComboBox comboBoxVehicleSel;
        private System.Windows.Forms.ComboBox comboBoxRentalType;
        private System.Windows.Forms.Label labelMonths;
        private System.Windows.Forms.ComboBox comboBoxMonths;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label labelValueShow;
        private System.Windows.Forms.Label labelDomainFormat;
        private System.Windows.Forms.ComboBox comboBoxDomainFormat;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxOldDomain;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNewDomain;
    }
}
