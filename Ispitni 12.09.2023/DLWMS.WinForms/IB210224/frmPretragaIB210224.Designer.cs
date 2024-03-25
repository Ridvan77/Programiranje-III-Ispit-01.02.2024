namespace DLWMS.WinForms.IB210224
{
    partial class frmPretragaIB210224
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbOcjenaOd = new ComboBox();
            cbOcjenaDo = new ComboBox();
            dtpDatumOd = new DateTimePicker();
            dtpDatumDo = new DateTimePicker();
            chbAktivan = new CheckBox();
            dgvStudenti = new DataGridView();
            Indeks = new DataGridViewTextBoxColumn();
            Student = new DataGridViewTextBoxColumn();
            Predmet = new DataGridViewTextBoxColumn();
            Ocjena = new DataGridViewTextBoxColumn();
            Datum = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            Poruke = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Ocjena od";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(170, 21);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 1;
            label2.Text = "do";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(296, 21);
            label3.Name = "label3";
            label3.Size = new Size(126, 15);
            label3.TabIndex = 2;
            label3.Text = "polozena u periodu od";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(644, 21);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 3;
            label4.Text = "do";
            // 
            // cbOcjenaOd
            // 
            cbOcjenaOd.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOcjenaOd.FormattingEnabled = true;
            cbOcjenaOd.Items.AddRange(new object[] { "6", "7", "8", "9", "10" });
            cbOcjenaOd.Location = new Point(79, 18);
            cbOcjenaOd.Name = "cbOcjenaOd";
            cbOcjenaOd.Size = new Size(70, 23);
            cbOcjenaOd.TabIndex = 4;
            cbOcjenaOd.SelectedIndexChanged += cbOcjenaOd_SelectedIndexChanged;
            // 
            // cbOcjenaDo
            // 
            cbOcjenaDo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOcjenaDo.FormattingEnabled = true;
            cbOcjenaDo.Items.AddRange(new object[] { "10", "9", "8", "7", "6" });
            cbOcjenaDo.Location = new Point(200, 18);
            cbOcjenaDo.Name = "cbOcjenaDo";
            cbOcjenaDo.Size = new Size(71, 23);
            cbOcjenaDo.TabIndex = 5;
            cbOcjenaDo.SelectedIndexChanged += cbOcjenaDo_SelectedIndexChanged;
            // 
            // dtpDatumOd
            // 
            dtpDatumOd.Location = new Point(428, 18);
            dtpDatumOd.Name = "dtpDatumOd";
            dtpDatumOd.Size = new Size(194, 23);
            dtpDatumOd.TabIndex = 6;
            dtpDatumOd.ValueChanged += dtpDatumOd_ValueChanged;
            // 
            // dtpDatumDo
            // 
            dtpDatumDo.Location = new Point(672, 18);
            dtpDatumDo.Name = "dtpDatumDo";
            dtpDatumDo.Size = new Size(187, 23);
            dtpDatumDo.TabIndex = 7;
            dtpDatumDo.ValueChanged += dtpDatumDo_ValueChanged;
            // 
            // chbAktivan
            // 
            chbAktivan.AutoSize = true;
            chbAktivan.Location = new Point(880, 20);
            chbAktivan.Name = "chbAktivan";
            chbAktivan.Size = new Size(108, 19);
            chbAktivan.TabIndex = 8;
            chbAktivan.Text = "Student aktivan";
            chbAktivan.UseVisualStyleBackColor = true;
            chbAktivan.CheckedChanged += chbAktivan_CheckedChanged;
            // 
            // dgvStudenti
            // 
            dgvStudenti.AllowUserToAddRows = false;
            dgvStudenti.AllowUserToDeleteRows = false;
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { Indeks, Student, Predmet, Ocjena, Datum, Aktivan, Poruke });
            dgvStudenti.Location = new Point(12, 59);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.ReadOnly = true;
            dgvStudenti.RowTemplate.Height = 25;
            dgvStudenti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudenti.Size = new Size(976, 293);
            dgvStudenti.TabIndex = 9;
            dgvStudenti.CellContentClick += dgvStudenti_CellContentClick;
            // 
            // Indeks
            // 
            Indeks.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Indeks.DataPropertyName = "Indeks";
            Indeks.HeaderText = "Indeks";
            Indeks.Name = "Indeks";
            Indeks.ReadOnly = true;
            // 
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "Student";
            Student.HeaderText = "Ime i prezime";
            Student.Name = "Student";
            Student.ReadOnly = true;
            // 
            // Predmet
            // 
            Predmet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Predmet.DataPropertyName = "Predmet";
            Predmet.HeaderText = "Predmet";
            Predmet.Name = "Predmet";
            Predmet.ReadOnly = true;
            // 
            // Ocjena
            // 
            Ocjena.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ocjena.DataPropertyName = "Ocjena";
            Ocjena.HeaderText = "Ocjena";
            Ocjena.Name = "Ocjena";
            Ocjena.ReadOnly = true;
            // 
            // Datum
            // 
            Datum.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Datum.DataPropertyName = "Datum";
            Datum.HeaderText = "Datum polaganja";
            Datum.Name = "Datum";
            Datum.ReadOnly = true;
            // 
            // Aktivan
            // 
            Aktivan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            // 
            // Poruke
            // 
            Poruke.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Poruke.HeaderText = "";
            Poruke.Name = "Poruke";
            Poruke.ReadOnly = true;
            Poruke.Text = "Poruke";
            Poruke.UseColumnTextForButtonValue = true;
            // 
            // frmPretragaIB210224
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 363);
            Controls.Add(dgvStudenti);
            Controls.Add(chbAktivan);
            Controls.Add(dtpDatumDo);
            Controls.Add(dtpDatumOd);
            Controls.Add(cbOcjenaDo);
            Controls.Add(cbOcjenaOd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPretragaIB210224";
            Text = "frmPretragaIB210224";
            Load += frmPretragaIB210224_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbOcjenaOd;
        private ComboBox cbOcjenaDo;
        private DateTimePicker dtpDatumOd;
        private DateTimePicker dtpDatumDo;
        private CheckBox chbAktivan;
        private DataGridView dgvStudenti;
        private DataGridViewTextBoxColumn Indeks;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Ocjena;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn Poruke;
    }
}