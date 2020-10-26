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
            this.dataGridViewPreviousClosing = new System.Windows.Forms.DataGridView();
            this.ClosingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserClosing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewMovements = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxConcept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPreviousClosing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovements)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPreviousClosing
            // 
            this.dataGridViewPreviousClosing.AllowUserToAddRows = false;
            this.dataGridViewPreviousClosing.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewPreviousClosing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPreviousClosing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClosingDate,
            this.UserClosing});
            this.dataGridViewPreviousClosing.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewPreviousClosing.Location = new System.Drawing.Point(128, 12);
            this.dataGridViewPreviousClosing.Name = "dataGridViewPreviousClosing";
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
            this.ClosingDate.Width = 150;
            // 
            // UserClosing
            // 
            this.UserClosing.HeaderText = "Usuario";
            this.UserClosing.Name = "UserClosing";
            // 
            // dataGridViewMovements
            // 
            this.dataGridViewMovements.AllowUserToAddRows = false;
            this.dataGridViewMovements.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewMovements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxConcept,
            this.Value,
            this.dataGridViewTextBoxDate,
            this.User});
            this.dataGridViewMovements.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewMovements.Location = new System.Drawing.Point(33, 246);
            this.dataGridViewMovements.Name = "dataGridViewMovements";
            this.dataGridViewMovements.RowHeadersWidth = 50;
            this.dataGridViewMovements.Size = new System.Drawing.Size(503, 228);
            this.dataGridViewMovements.TabIndex = 6;
            // 
            // dataGridViewTextBoxConcept
            // 
            this.dataGridViewTextBoxConcept.HeaderText = "Concepto";
            this.dataGridViewTextBoxConcept.Name = "dataGridViewTextBoxConcept";
            this.dataGridViewTextBoxConcept.Width = 150;
            // 
            // Value
            // 
            this.Value.HeaderText = "Valor";
            this.Value.Name = "Value";
            // 
            // dataGridViewTextBoxDate
            // 
            this.dataGridViewTextBoxDate.HeaderText = "Fecha";
            this.dataGridViewTextBoxDate.Name = "dataGridViewTextBoxDate";
            // 
            // User
            // 
            this.User.HeaderText = "Usuario";
            this.User.Name = "User";
            // 
            // PreviousForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 511);
            this.Controls.Add(this.dataGridViewMovements);
            this.Controls.Add(this.dataGridViewPreviousClosing);
            this.Name = "PreviousForm";
            this.Text = "PreviousForm";
            this.Load += new System.EventHandler(this.PreviousForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPreviousClosing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovements)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewPreviousClosing;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClosingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserClosing;
        private System.Windows.Forms.DataGridView dataGridViewMovements;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxConcept;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
    }
}
