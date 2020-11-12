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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewMovements = new System.Windows.Forms.DataGridView();
            this.Concept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserMovement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Outcome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonClosing = new System.Windows.Forms.Button();
            this.groupBoxTotalDay = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonMovements = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovements)).BeginInit();
            this.groupBoxTotalDay.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMovements
            // 
            this.dataGridViewMovements.AllowUserToAddRows = false;
            this.dataGridViewMovements.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMovements.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMovements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Concept,
            this.Date,
            this.UserMovement,
            this.Amount,
            this.Outcome});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMovements.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMovements.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewMovements.Location = new System.Drawing.Point(20, 38);
            this.dataGridViewMovements.Name = "dataGridViewMovements";
            this.dataGridViewMovements.RowHeadersWidth = 50;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.dataGridViewMovements.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewMovements.Size = new System.Drawing.Size(657, 228);
            this.dataGridViewMovements.TabIndex = 1;
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
            this.Amount.HeaderText = "Ingreso";
            this.Amount.Name = "Amount";
            // 
            // Outcome
            // 
            this.Outcome.HeaderText = "Egreso";
            this.Outcome.Name = "Outcome";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(61, 79);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(40, 18);
            this.labelTotal.TabIndex = 2;
            this.labelTotal.Text = "Total";
            // 
            // buttonClosing
            // 
            this.buttonClosing.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonClosing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClosing.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClosing.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClosing.Location = new System.Drawing.Point(395, 304);
            this.buttonClosing.Name = "buttonClosing";
            this.buttonClosing.Size = new System.Drawing.Size(141, 51);
            this.buttonClosing.TabIndex = 3;
            this.buttonClosing.Text = "Cierre Caja";
            this.buttonClosing.UseVisualStyleBackColor = true;
            this.buttonClosing.Click += new System.EventHandler(this.buttonClosing_Click);
            // 
            // groupBoxTotalDay
            // 
            this.groupBoxTotalDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.groupBoxTotalDay.Controls.Add(this.label2);
            this.groupBoxTotalDay.Controls.Add(this.label1);
            this.groupBoxTotalDay.Controls.Add(this.labelTotal);
            this.groupBoxTotalDay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxTotalDay.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTotalDay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxTotalDay.Location = new System.Drawing.Point(12, 280);
            this.groupBoxTotalDay.Name = "groupBoxTotalDay";
            this.groupBoxTotalDay.Size = new System.Drawing.Size(208, 109);
            this.groupBoxTotalDay.TabIndex = 4;
            this.groupBoxTotalDay.TabStop = false;
            this.groupBoxTotalDay.Text = "Total ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Ingresos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Egresos";
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDay.Location = new System.Drawing.Point(17, 9);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(45, 23);
            this.labelDay.TabIndex = 3;
            this.labelDay.Text = "Date";
            // 
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExit.Location = new System.Drawing.Point(563, 304);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(108, 51);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Salir";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonMovements
            // 
            this.buttonMovements.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonMovements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMovements.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMovements.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMovements.Location = new System.Drawing.Point(226, 304);
            this.buttonMovements.Name = "buttonMovements";
            this.buttonMovements.Size = new System.Drawing.Size(141, 51);
            this.buttonMovements.TabIndex = 6;
            this.buttonMovements.Text = "Movimientos";
            this.buttonMovements.UseVisualStyleBackColor = true;
            this.buttonMovements.Click += new System.EventHandler(this.buttonMovements_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(683, 401);
            this.Controls.Add(this.buttonMovements);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBoxTotalDay);
            this.Controls.Add(this.buttonClosing);
            this.Controls.Add(this.dataGridViewMovements);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Outcome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMovements;
    }
}
