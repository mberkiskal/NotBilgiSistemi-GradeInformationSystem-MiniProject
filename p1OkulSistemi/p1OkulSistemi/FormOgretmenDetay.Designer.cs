namespace p1OkulSistemi
{
    partial class FormOgretmenDetay
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.mskNumara = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSınav1 = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtSınav3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSınav2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblKalan = new System.Windows.Forms.Label();
            this.lblGeçen = new System.Windows.Forms.Label();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oGRIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRNUMARADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRSOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRS1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRS2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRS3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRTALAMADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dURUMDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tableDersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p1OkulSistemiDataSet1 = new p1OkulSistemi.p1OkulSistemiDataSet1();
            this.table_DersTableAdapter = new p1OkulSistemi.p1OkulSistemiDataSet1TableAdapters.Table_DersTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1OkulSistemiDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.mskNumara);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 307);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Ekle";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Bisque;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Location = new System.Drawing.Point(83, 240);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(165, 35);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Öğrenci Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(167, 179);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(165, 33);
            this.txtSoyad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Öğrenci Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Öğrenci Ad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(167, 125);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(165, 33);
            this.txtAd.TabIndex = 2;
            // 
            // mskNumara
            // 
            this.mskNumara.Location = new System.Drawing.Point(167, 72);
            this.mskNumara.Mask = "0000";
            this.mskNumara.Name = "mskNumara";
            this.mskNumara.Size = new System.Drawing.Size(165, 33);
            this.mskNumara.TabIndex = 1;
            this.mskNumara.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Numara:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSınav1);
            this.groupBox2.Controls.Add(this.btnGuncelle);
            this.groupBox2.Controls.Add(this.txtSınav3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtSınav2);
            this.groupBox2.Location = new System.Drawing.Point(391, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 307);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sınavlar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sınav 1:";
            // 
            // txtSınav1
            // 
            this.txtSınav1.Location = new System.Drawing.Point(143, 75);
            this.txtSınav1.Name = "txtSınav1";
            this.txtSınav1.Size = new System.Drawing.Size(165, 33);
            this.txtSınav1.TabIndex = 7;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Bisque;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Location = new System.Drawing.Point(104, 240);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(165, 35);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtSınav3
            // 
            this.txtSınav3.Location = new System.Drawing.Point(143, 182);
            this.txtSınav3.Name = "txtSınav3";
            this.txtSınav3.Size = new System.Drawing.Size(165, 33);
            this.txtSınav3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sınav 3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Sınav 2:";
            // 
            // txtSınav2
            // 
            this.txtSınav2.Location = new System.Drawing.Point(143, 128);
            this.txtSınav2.Name = "txtSınav2";
            this.txtSınav2.Size = new System.Drawing.Size(165, 33);
            this.txtSınav2.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblKalan);
            this.groupBox3.Controls.Add(this.lblGeçen);
            this.groupBox3.Controls.Add(this.lblOrtalama);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(770, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(373, 307);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sınıf Durum";
            // 
            // lblKalan
            // 
            this.lblKalan.AutoSize = true;
            this.lblKalan.Location = new System.Drawing.Point(248, 201);
            this.lblKalan.Name = "lblKalan";
            this.lblKalan.Size = new System.Drawing.Size(32, 25);
            this.lblKalan.TabIndex = 11;
            this.lblKalan.Text = "00";
            // 
            // lblGeçen
            // 
            this.lblGeçen.AutoSize = true;
            this.lblGeçen.Location = new System.Drawing.Point(248, 147);
            this.lblGeçen.Name = "lblGeçen";
            this.lblGeçen.Size = new System.Drawing.Size(32, 25);
            this.lblGeçen.TabIndex = 10;
            this.lblGeçen.Text = "00";
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Location = new System.Drawing.Point(248, 99);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(32, 25);
            this.lblOrtalama.TabIndex = 9;
            this.lblOrtalama.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Öğrenci Ortalaması:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(118, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Kalan Sayısı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(112, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Geçen Sayısı:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(12, 325);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1131, 250);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sınav Notları";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oGRIDDataGridViewTextBoxColumn,
            this.oGRNUMARADataGridViewTextBoxColumn,
            this.oGRADDataGridViewTextBoxColumn,
            this.oGRSOYADDataGridViewTextBoxColumn,
            this.oGRS1DataGridViewTextBoxColumn,
            this.oGRS2DataGridViewTextBoxColumn,
            this.oGRS3DataGridViewTextBoxColumn,
            this.oRTALAMADataGridViewTextBoxColumn,
            this.dURUMDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tableDersBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1125, 218);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // oGRIDDataGridViewTextBoxColumn
            // 
            this.oGRIDDataGridViewTextBoxColumn.DataPropertyName = "OGRID";
            this.oGRIDDataGridViewTextBoxColumn.HeaderText = "OGRID";
            this.oGRIDDataGridViewTextBoxColumn.Name = "oGRIDDataGridViewTextBoxColumn";
            this.oGRIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oGRNUMARADataGridViewTextBoxColumn
            // 
            this.oGRNUMARADataGridViewTextBoxColumn.DataPropertyName = "OGRNUMARA";
            this.oGRNUMARADataGridViewTextBoxColumn.HeaderText = "OGRNUMARA";
            this.oGRNUMARADataGridViewTextBoxColumn.Name = "oGRNUMARADataGridViewTextBoxColumn";
            // 
            // oGRADDataGridViewTextBoxColumn
            // 
            this.oGRADDataGridViewTextBoxColumn.DataPropertyName = "OGRAD";
            this.oGRADDataGridViewTextBoxColumn.HeaderText = "OGRAD";
            this.oGRADDataGridViewTextBoxColumn.Name = "oGRADDataGridViewTextBoxColumn";
            // 
            // oGRSOYADDataGridViewTextBoxColumn
            // 
            this.oGRSOYADDataGridViewTextBoxColumn.DataPropertyName = "OGRSOYAD";
            this.oGRSOYADDataGridViewTextBoxColumn.HeaderText = "OGRSOYAD";
            this.oGRSOYADDataGridViewTextBoxColumn.Name = "oGRSOYADDataGridViewTextBoxColumn";
            // 
            // oGRS1DataGridViewTextBoxColumn
            // 
            this.oGRS1DataGridViewTextBoxColumn.DataPropertyName = "OGRS1";
            this.oGRS1DataGridViewTextBoxColumn.HeaderText = "OGRS1";
            this.oGRS1DataGridViewTextBoxColumn.Name = "oGRS1DataGridViewTextBoxColumn";
            // 
            // oGRS2DataGridViewTextBoxColumn
            // 
            this.oGRS2DataGridViewTextBoxColumn.DataPropertyName = "OGRS2";
            this.oGRS2DataGridViewTextBoxColumn.HeaderText = "OGRS2";
            this.oGRS2DataGridViewTextBoxColumn.Name = "oGRS2DataGridViewTextBoxColumn";
            // 
            // oGRS3DataGridViewTextBoxColumn
            // 
            this.oGRS3DataGridViewTextBoxColumn.DataPropertyName = "OGRS3";
            this.oGRS3DataGridViewTextBoxColumn.HeaderText = "OGRS3";
            this.oGRS3DataGridViewTextBoxColumn.Name = "oGRS3DataGridViewTextBoxColumn";
            // 
            // oRTALAMADataGridViewTextBoxColumn
            // 
            this.oRTALAMADataGridViewTextBoxColumn.DataPropertyName = "ORTALAMA";
            this.oRTALAMADataGridViewTextBoxColumn.HeaderText = "ORTALAMA";
            this.oRTALAMADataGridViewTextBoxColumn.Name = "oRTALAMADataGridViewTextBoxColumn";
            // 
            // dURUMDataGridViewCheckBoxColumn
            // 
            this.dURUMDataGridViewCheckBoxColumn.DataPropertyName = "DURUM";
            this.dURUMDataGridViewCheckBoxColumn.HeaderText = "DURUM";
            this.dURUMDataGridViewCheckBoxColumn.Name = "dURUMDataGridViewCheckBoxColumn";
            // 
            // tableDersBindingSource
            // 
            this.tableDersBindingSource.DataMember = "Table_Ders";
            this.tableDersBindingSource.DataSource = this.p1OkulSistemiDataSet1;
            // 
            // p1OkulSistemiDataSet1
            // 
            this.p1OkulSistemiDataSet1.DataSetName = "p1OkulSistemiDataSet1";
            this.p1OkulSistemiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_DersTableAdapter
            // 
            this.table_DersTableAdapter.ClearBeforeFill = true;
            // 
            // FormOgretmenDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1154, 587);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOgretmenDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğretmen Bilgilendirme Sistemi";
            this.Load += new System.EventHandler(this.FormOgretmenDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1OkulSistemiDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.MaskedTextBox mskNumara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSınav1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtSınav3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSınav2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblKalan;
        private System.Windows.Forms.Label lblGeçen;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private p1OkulSistemiDataSet1 p1OkulSistemiDataSet1;
        private System.Windows.Forms.BindingSource tableDersBindingSource;
        private p1OkulSistemiDataSet1TableAdapters.Table_DersTableAdapter table_DersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRNUMARADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRSOYADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRS1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRS2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRS3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRTALAMADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dURUMDataGridViewCheckBoxColumn;
    }
}