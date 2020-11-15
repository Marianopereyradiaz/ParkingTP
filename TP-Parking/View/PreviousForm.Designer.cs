namespace TP_Parking.View
{
    partial class PreviousForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewPreviousClosing = new System.Windows.Forms.DataGridView();
            this.ClosingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserClosing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewMovements = new System.Windows.Forms.DataGridView();
            this.labelTotalFromClosing = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxConcept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Income = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Outcome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPreviousClosing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovements)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPreviousClosing
            // 
            this.dataGridViewPreviousClosing.AllowUserToAddRows = false;
            this.dataGridViewPreviousClosing.AllowUserToDeleteRows = false;
            this.dataGridViewPreviousClosing.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dataGridViewPreviousClosing.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPreviousClosing.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.dataGridViewPreviousClosing.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPreviousClosing.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPreviousClosing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPreviousClosing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClosingDate,
            this.UserClosing});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPreviousClosing.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPreviousClosing.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewPreviousClosing.Location = new System.Drawing.Point(274, 40);
            this.dataGridViewPreviousClosing.Name = "dataGridViewPreviousClosing";
            this.dataGridViewPreviousClosing.ReadOnly = true;
            this.dataGridViewPreviousClosing.RowHeadersWidth = 50;
            this.dataGridViewPreviousClosing.Size = new System.Drawing.Size(302, 228);
            this.dataGridViewPreviousClosing.TabIndex = 5;
            this.dataGridViewPreviousClosing.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPreviousClosing_CellContentClick);
            this.dataGridViewPreviousClosing.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPreviousClosing_CellContentClick);
            // 
            // ClosingDate
            // 
            this.ClosingDate.HeaderText = "Fecha";
            this.ClosingDate.Name = "ClosingDate";
            this.ClosingDate.ReadOnly = true;
            this.ClosingDate.Width = 150;
            // 
            // UserClosing
            // 
            this.UserClosing.HeaderText = "Usuario";
            this.UserClosing.Name = "UserClosing";
            this.UserClosing.ReadOnly = true;
            // 
            // dataGridViewMovements
            // 
            this.dataGridViewMovements.AllowUserToAddRows = false;
            this.dataGridViewMovements.AllowUserToDeleteRows = false;
            this.dataGridViewMovements.AllowUserToResizeColumns = false;
            this.dataGridViewMovements.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.dataGridViewMovements.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewMovements.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.dataGridViewMovements.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMovements.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewMovements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxConcept,
            this.Income,
            this.Outcome,
            this.dataGridViewTextBoxDate,
            this.User});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMovements.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewMovements.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewMovements.Location = new System.Drawing.Point(12, 309);
            this.dataGridViewMovements.Name = "dataGridViewMovements";
            this.dataGridViewMovements.ReadOnly = true;
            this.dataGridViewMovements.RowHeadersWidth = 50;
            this.dataGridViewMovements.Size = new System.Drawing.Size(803, 228);
            this.dataGridViewMovements.TabIndex = 6;
            // 
            // labelTotalFromClosing
            // 
            this.labelTotalFromClosing.AutoSize = true;
            this.labelTotalFromClosing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalFromClosing.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTotalFromClosing.Location = new System.Drawing.Point(349, 551);
            this.labelTotalFromClosing.Name = "labelTotalFromClosing";
            this.labelTotalFromClosing.Size = new System.Drawing.Size(0, 16);
            this.labelTotalFromClosing.TabIndex = 7;
            this.labelTotalFromClosing.Click += new System.EventHandler(this.labelTotalFromClosing_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExit.Location = new System.Drawing.Point(352, 590);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(152, 40);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Cerrar";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(398, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cierres";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(398, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Detalle";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridViewTextBoxConcept
            // 
            this.dataGridViewTextBoxConcept.HeaderText = "Concepto";
            this.dataGridViewTextBoxConcept.Name = "dataGridViewTextBoxConcept";
            this.dataGridViewTextBoxConcept.ReadOnly = true;
            this.dataGridViewTextBoxConcept.Width = 300;
            // 
            // Income
            // 
            this.Income.HeaderText = "Ingreso";
            this.Income.Name = "Income";
            this.Income.ReadOnly = true;
            this.Income.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Outcome
            // 
            this.Outcome.HeaderText = "Egreso";
            this.Outcome.Name = "Outcome";
            this.Outcome.ReadOnly = true;
            this.Outcome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxDate
            // 
            this.dataGridViewTextBoxDate.HeaderText = "Fecha";
            this.dataGridViewTextBoxDate.Name = "dataGridViewTextBoxDate";
            this.dataGridViewTextBoxDate.ReadOnly = true;
            this.dataGridViewTextBoxDate.Width = 150;
            // 
            // User
            // 
            this.User.HeaderText = "Usuario";
            this.User.Name = "User";
            this.User.ReadOnly = true;
            this.User.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PreviousForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(857, 653);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelTotalFromClosing);
            this.Controls.Add(this.dataGridViewMovements);
            this.Controls.Add(this.dataGridViewPreviousClosing);
            this.Name = "PreviousForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cierres y Movimientos";
            this.Load += new System.EventHandler(this.PreviousForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPreviousClosing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewPreviousClosing;
        private System.Windows.Forms.DataGridView dataGridViewMovements;
        private System.Windows.Forms.Label labelTotalFromClosing;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClosingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserClosing;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxConcept;
        private System.Windows.Forms.DataGridViewTextBoxColumn Income;
        private System.Windows.Forms.DataGridViewTextBoxColumn Outcome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
    }
}
