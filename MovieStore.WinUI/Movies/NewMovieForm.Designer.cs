namespace MovieStore.WinUI.Movies
{
    partial class NewMovieForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDirectorName = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbGenres = new System.Windows.Forms.ComboBox();
            this.dtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtImdbScore = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMovieActor = new System.Windows.Forms.TextBox();
            this.lbActors = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Location = new System.Drawing.Point(133, 343);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(186, 28);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUnitPrice.Location = new System.Drawing.Point(134, 287);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(186, 23);
            this.txtUnitPrice.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(49, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Birim Fiyatı:";
            // 
            // txtDirectorName
            // 
            this.txtDirectorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDirectorName.Location = new System.Drawing.Point(134, 147);
            this.txtDirectorName.Name = "txtDirectorName";
            this.txtDirectorName.Size = new System.Drawing.Size(186, 23);
            this.txtDirectorName.TabIndex = 16;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtQuantity.Location = new System.Drawing.Point(134, 252);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(186, 23);
            this.txtQuantity.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(50, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Yönetmeni:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(76, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Miktarı:";
            // 
            // txtMovieName
            // 
            this.txtMovieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMovieName.Location = new System.Drawing.Point(134, 76);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(186, 23);
            this.txtMovieName.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(68, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 14;
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
            this.label1.TabIndex = 10;
            this.label1.Text = "Yeni Film Kaydı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(47, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Filmin Türü:";
            // 
            // cbGenres
            // 
            this.cbGenres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbGenres.FormattingEnabled = true;
            this.cbGenres.Location = new System.Drawing.Point(134, 111);
            this.cbGenres.Name = "cbGenres";
            this.cbGenres.Size = new System.Drawing.Size(186, 24);
            this.cbGenres.TabIndex = 20;
            // 
            // dtpReleaseDate
            // 
            this.dtpReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpReleaseDate.Location = new System.Drawing.Point(133, 182);
            this.dtpReleaseDate.Name = "dtpReleaseDate";
            this.dtpReleaseDate.Size = new System.Drawing.Size(186, 23);
            this.dtpReleaseDate.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(35, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Vizyon Tarihi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(47, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Imdb Puanı:";
            // 
            // txtImdbScore
            // 
            this.txtImdbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtImdbScore.Location = new System.Drawing.Point(134, 219);
            this.txtImdbScore.Name = "txtImdbScore";
            this.txtImdbScore.Size = new System.Drawing.Size(186, 23);
            this.txtImdbScore.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(400, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Oyuncu Adı:";
            // 
            // txtMovieActor
            // 
            this.txtMovieActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMovieActor.Location = new System.Drawing.Point(491, 73);
            this.txtMovieActor.Name = "txtMovieActor";
            this.txtMovieActor.Size = new System.Drawing.Size(186, 23);
            this.txtMovieActor.TabIndex = 18;
            // 
            // lbActors
            // 
            this.lbActors.FormattingEnabled = true;
            this.lbActors.Location = new System.Drawing.Point(491, 171);
            this.lbActors.Name = "lbActors";
            this.lbActors.Size = new System.Drawing.Size(186, 264);
            this.lbActors.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(491, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 36);
            this.button1.TabIndex = 23;
            this.button1.Text = "Oyuncu Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbActors);
            this.Controls.Add(this.dtpReleaseDate);
            this.Controls.Add(this.cbGenres);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDirectorName);
            this.Controls.Add(this.txtImdbScore);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMovieActor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMovieName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewMovieForm";
            this.Text = "Yeni Film";
            this.Load += new System.EventHandler(this.NewMovieForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDirectorName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbGenres;
        private System.Windows.Forms.DateTimePicker dtpReleaseDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtImdbScore;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMovieActor;
        private System.Windows.Forms.ListBox lbActors;
        private System.Windows.Forms.Button button1;
    }
}