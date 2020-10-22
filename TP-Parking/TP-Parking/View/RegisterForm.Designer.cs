namespace TP_Parking
{
    partial class RegisterForm
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
            this.dataGridViewMovements = new System.Windows.Forms.DataGridView();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonClosing = new System.Windows.Forms.Button();
            this.groupBoxTotalDay = new System.Windows.Forms.GroupBox();
            this.labelDay = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.Concept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserMovement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovements)).BeginInit();
            this.groupBoxTotalDay.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMovements
            // 
            this.dataGridViewMovements.AllowUserToAddRows = false;
            this.dataGridViewMovements.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewMovements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Concept,
            this.Date,
            this.UserMovement,
            this.Amount});
            this.dataGridViewMovements.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewMovements.Location = new System.Drawing.Point(20, 38);
            this.dataGridViewMovements.Name = "dataGridViewMovements";
            this.dataGridViewMovements.RowHeadersWidth = 50;
            this.dataGridViewMovements.Size = new System.Drawing.Size(553, 228);
            this.dataGridViewMovements.TabIndex = 1;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(64, 30);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(56, 16);
            this.labelTotal.TabIndex = 2;
            this.labelTotal.Text = "Total $$";
            // 
            // buttonClosing
            // 
            this.buttonClosing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClosing.Location = new System.Drawing.Point(256, 291);
            this.buttonClosing.Name = "buttonClosing";
            this.buttonClosing.Size = new System.Drawing.Size(141, 51);
            this.buttonClosing.TabIndex = 3;
            this.buttonClosing.Text = "Cierre Caja";
            this.buttonClosing.UseVisualStyleBackColor = true;
            this.buttonClosing.Click += new System.EventHandler(this.buttonClosing_Click);
            // 
            // groupBoxTotalDay
            // 
            this.groupBoxTotalDay.BackColor = System.Drawing.Color.White;
            this.groupBoxTotalDay.Controls.Add(this.labelTotal);
            this.groupBoxTotalDay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxTotalDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTotalDay.Location = new System.Drawing.Point(12, 280);
            this.groupBoxTotalDay.Name = "groupBoxTotalDay";
            this.groupBoxTotalDay.Size = new System.Drawing.Size(176, 70);
            this.groupBoxTotalDay.TabIndex = 4;
            this.groupBoxTotalDay.TabStop = false;
            this.groupBoxTotalDay.Text = "Total ";
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay.Location = new System.Drawing.Point(12, 19);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(37, 16);
            this.labelDay.TabIndex = 3;
            this.labelDay.Text = "Date";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(433, 291);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(108, 51);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Salir";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Concept
            // 
            this.Concept.HeaderText = "Concepto";
            this.Concept.Name = "Concept";
            this.Concept.Width = 150;
            // 
            // Date
            // 
            this.Date.HeaderText = "Fecha";
            this.Date.Name = "Date";
            this.Date.Width = 150;
            // 
            // UserMovement
            // 
            this.UserMovement.HeaderText = "Usuario";
            this.UserMovement.Name = "UserMovement";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Valor";
            this.Amount.Name = "Amount";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(585, 401);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBoxTotalDay);
            this.Controls.Add(this.buttonClosing);
            this.Controls.Add(this.dataGridViewMovements);
            this.Name = "RegisterForm";
            this.Text = "Caja";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovements)).EndInit();
            this.groupBoxTotalDay.ResumeLayout(false);
            this.groupBoxTotalDay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewMovements;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonClosing;
        private System.Windows.Forms.GroupBox groupBoxTotalDay;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concept;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserMovement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}
