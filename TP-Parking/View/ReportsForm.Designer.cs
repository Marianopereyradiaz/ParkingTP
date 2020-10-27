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
            this.buttonDailyRentals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDailyRentals.Location = new System.Drawing.Point(38, 12);
            this.buttonDailyRentals.Name = "buttonDailyRentals";
            this.buttonDailyRentals.Size = new System.Drawing.Size(131, 41);
            this.buttonDailyRentals.TabIndex = 0;
            this.buttonDailyRentals.Text = "Alquileres del Día";
            this.buttonDailyRentals.UseVisualStyleBackColor = true;
            this.buttonDailyRentals.Click += new System.EventHandler(this.buttonDailyRental_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(38, 142);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(131, 41);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Cerrar";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonPreviousClosings
            // 
            this.buttonPreviousClosings.Location = new System.Drawing.Point(38, 59);
            this.buttonPreviousClosings.Name = "buttonPreviousClosings";
            this.buttonPreviousClosings.Size = new System.Drawing.Size(131, 41);
            this.buttonPreviousClosings.TabIndex = 2;
            this.buttonPreviousClosings.Text = "Cierres Anteriores";
            this.buttonPreviousClosings.UseVisualStyleBackColor = true;
            this.buttonPreviousClosings.Click += new System.EventHandler(this.buttonPreviousClosings_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 195);
            this.Controls.Add(this.buttonPreviousClosings);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonDailyRentals);
            this.Name = "ReportsForm";
            this.Text = "Reportes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDailyRentals;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonPreviousClosings;
    }
}
