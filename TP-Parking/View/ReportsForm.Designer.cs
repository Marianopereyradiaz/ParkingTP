namespace TP_Parking
{
    partial class ReportsForm
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
            this.buttonDailyRentals = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonPreviousClosings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDailyRentals
            // 
            this.buttonDailyRentals.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonDailyRentals.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDailyRentals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDailyRentals.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDailyRentals.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDailyRentals.Location = new System.Drawing.Point(45, 14);
            this.buttonDailyRentals.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDailyRentals.Name = "buttonDailyRentals";
            this.buttonDailyRentals.Size = new System.Drawing.Size(153, 47);
            this.buttonDailyRentals.TabIndex = 0;
            this.buttonDailyRentals.Text = "Historial de Alquileres";
            this.buttonDailyRentals.UseVisualStyleBackColor = true;
            this.buttonDailyRentals.Click += new System.EventHandler(this.buttonDailyRental_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClose.Location = new System.Drawing.Point(45, 164);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(153, 47);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Cerrar";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonPreviousClosings
            // 
            this.buttonPreviousClosings.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonPreviousClosings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonPreviousClosings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreviousClosings.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPreviousClosings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPreviousClosings.Location = new System.Drawing.Point(45, 68);
            this.buttonPreviousClosings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonPreviousClosings.Name = "buttonPreviousClosings";
            this.buttonPreviousClosings.Size = new System.Drawing.Size(153, 47);
            this.buttonPreviousClosings.TabIndex = 2;
            this.buttonPreviousClosings.Text = "Cierres Anteriores";
            this.buttonPreviousClosings.UseVisualStyleBackColor = true;
            this.buttonPreviousClosings.Click += new System.EventHandler(this.buttonPreviousClosings_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(256, 225);
            this.Controls.Add(this.buttonPreviousClosings);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonDailyRentals);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDailyRentals;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonPreviousClosings;
    }
}
