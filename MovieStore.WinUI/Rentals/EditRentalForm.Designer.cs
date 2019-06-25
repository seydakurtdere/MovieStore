namespace MovieStore.WinUI.Rentals
{
    partial class EditRentalForm
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
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBeginDate = new System.Windows.Forms.DateTimePicker();
            this.cbMovies = new System.Windows.Forms.ComboBox();
            this.cbCustomers = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRentals = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbRecordStatuses = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpEndDate.Location = new System.Drawing.Point(448, 221);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(186, 23);
            this.dtpEndDate.TabIndex = 22;
            // 
            // dtpBeginDate
            // 
            this.dtpBeginDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpBeginDate.Location = new System.Drawing.Point(448, 189);
            this.dtpBeginDate.Name = "dtpBeginDate";
            this.dtpBeginDate.Size = new System.Drawing.Size(186, 23);
            this.dtpBeginDate.TabIndex = 23;
            // 
            // cbMovies
            // 
            this.cbMovies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbMovies.FormattingEnabled = true;
            this.cbMovies.Location = new System.Drawing.Point(448, 156);
            this.cbMovies.Name = "cbMovies";
            this.cbMovies.Size = new System.Drawing.Size(186, 24);
            this.cbMovies.TabIndex = 20;
            // 
            // cbCustomers
            // 
            this.cbCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbCustomers.FormattingEnabled = true;
            this.cbCustomers.Location = new System.Drawing.Point(448, 123);
            this.cbCustomers.Name = "cbCustomers";
            this.cbCustomers.Size = new System.Drawing.Size(186, 24);
            this.cbCustomers.TabIndex = 21;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.PaleGreen;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(448, 348);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(186, 28);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTotalPrice.Location = new System.Drawing.Point(447, 253);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(186, 23);
            this.txtTotalPrice.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(393, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Film:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(337, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Toplam Fiyat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(372, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Müşteri:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(317, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Başlangıç Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(352, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Bitiş Tarihi:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kiralama Düzenleme";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbRentals
            // 
            this.lbRentals.FormattingEnabled = true;
            this.lbRentals.Location = new System.Drawing.Point(27, 84);
            this.lbRentals.Name = "lbRentals";
            this.lbRentals.Size = new System.Drawing.Size(236, 264);
            this.lbRentals.TabIndex = 24;
            this.lbRentals.DoubleClick += new System.EventHandler(this.lbRentals_DoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(376, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Durum:";
            // 
            // cbRecordStatuses
            // 
            this.cbRecordStatuses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRecordStatuses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbRecordStatuses.FormattingEnabled = true;
            this.cbRecordStatuses.Location = new System.Drawing.Point(448, 293);
            this.cbRecordStatuses.Name = "cbRecordStatuses";
            this.cbRecordStatuses.Size = new System.Drawing.Size(186, 24);
            this.cbRecordStatuses.TabIndex = 21;
            // 
            // EditRentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbRentals);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpBeginDate);
            this.Controls.Add(this.cbMovies);
            this.Controls.Add(this.cbRecordStatuses);
            this.Controls.Add(this.cbCustomers);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditRentalForm";
            this.Text = "EditRentalForm";
            this.Load += new System.EventHandler(this.EditRentalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpBeginDate;
        private System.Windows.Forms.ComboBox cbMovies;
        private System.Windows.Forms.ComboBox cbCustomers;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbRentals;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbRecordStatuses;
    }
}