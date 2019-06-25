namespace MovieStore.WinUI.Movies
{
    partial class EditMoviesForm
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
            this.dtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.cbGenres = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDirectorName = new System.Windows.Forms.TextBox();
            this.txtImdbScore = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMovies = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbRecordStatuses = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dtpReleaseDate
            // 
            this.dtpReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpReleaseDate.Location = new System.Drawing.Point(130, 172);
            this.dtpReleaseDate.Name = "dtpReleaseDate";
            this.dtpReleaseDate.Size = new System.Drawing.Size(186, 23);
            this.dtpReleaseDate.TabIndex = 37;
            // 
            // cbGenres
            // 
            this.cbGenres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbGenres.FormattingEnabled = true;
            this.cbGenres.Location = new System.Drawing.Point(131, 101);
            this.cbGenres.Name = "cbGenres";
            this.cbGenres.Size = new System.Drawing.Size(186, 24);
            this.cbGenres.TabIndex = 36;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.PaleGreen;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(130, 333);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(186, 28);
            this.btnUpdate.TabIndex = 35;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUnitPrice.Location = new System.Drawing.Point(131, 277);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(186, 23);
            this.txtUnitPrice.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(46, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Birim Fiyatı:";
            // 
            // txtDirectorName
            // 
            this.txtDirectorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDirectorName.Location = new System.Drawing.Point(131, 137);
            this.txtDirectorName.Name = "txtDirectorName";
            this.txtDirectorName.Size = new System.Drawing.Size(186, 23);
            this.txtDirectorName.TabIndex = 31;
            // 
            // txtImdbScore
            // 
            this.txtImdbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtImdbScore.Location = new System.Drawing.Point(131, 209);
            this.txtImdbScore.Name = "txtImdbScore";
            this.txtImdbScore.Size = new System.Drawing.Size(186, 23);
            this.txtImdbScore.TabIndex = 32;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtQuantity.Location = new System.Drawing.Point(131, 242);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(186, 23);
            this.txtQuantity.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(44, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Filmin Türü:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(44, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Imdb Puanı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(32, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Vizyon Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(47, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Yönetmeni:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(73, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Miktarı:";
            // 
            // txtMovieName
            // 
            this.txtMovieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMovieName.Location = new System.Drawing.Point(131, 66);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(186, 23);
            this.txtMovieName.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(65, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Film Adı:";
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
            this.label1.TabIndex = 22;
            this.label1.Text = "Film Güncelleme";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMovies
            // 
            this.lbMovies.FormattingEnabled = true;
            this.lbMovies.Location = new System.Drawing.Point(420, 61);
            this.lbMovies.Name = "lbMovies";
            this.lbMovies.Size = new System.Drawing.Size(295, 316);
            this.lbMovies.TabIndex = 38;
            this.lbMovies.DoubleClick += new System.EventHandler(this.lbMovies_DoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(32, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Kayıt Durumu:";
            // 
            // cbRecordStatuses
            // 
            this.cbRecordStatuses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRecordStatuses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbRecordStatuses.FormattingEnabled = true;
            this.cbRecordStatuses.Location = new System.Drawing.Point(131, 306);
            this.cbRecordStatuses.Name = "cbRecordStatuses";
            this.cbRecordStatuses.Size = new System.Drawing.Size(186, 24);
            this.cbRecordStatuses.TabIndex = 36;
            // 
            // EditMoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbMovies);
            this.Controls.Add(this.dtpReleaseDate);
            this.Controls.Add(this.cbRecordStatuses);
            this.Controls.Add(this.cbGenres);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDirectorName);
            this.Controls.Add(this.txtImdbScore);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMovieName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditMoviesForm";
            this.Text = "Film Düzenle";
            this.Load += new System.EventHandler(this.EditMoviesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpReleaseDate;
        private System.Windows.Forms.ComboBox cbGenres;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDirectorName;
        private System.Windows.Forms.TextBox txtImdbScore;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbMovies;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbRecordStatuses;
    }
}