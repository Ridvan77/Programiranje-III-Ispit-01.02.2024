namespace DLWMS.WinForms.IB210224
{
    partial class frmPorukeIB210224
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            lblStudent = new Label();
            dgvPoruke = new DataGridView();
            Predmet = new DataGridViewTextBoxColumn();
            Sadrzaj = new DataGridViewTextBoxColumn();
            Slika = new DataGridViewImageColumn();
            Hitnost = new DataGridViewTextBoxColumn();
            Validnost = new DataGridViewTextBoxColumn();
            Brisi = new DataGridViewButtonColumn();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            txtInfo = new TextBox();
            btnDodaj = new Button();
            dtpValidnost = new DateTimePicker();
            cbPredmeti = new ComboBox();
            txtBrojPoruka = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvPoruke).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 15);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Poruke studenta:";
            // 
            // lblStudent
            // 
            lblStudent.Location = new Point(116, 15);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(190, 15);
            lblStudent.TabIndex = 1;
            // 
            // dgvPoruke
            // 
            dgvPoruke.AllowUserToAddRows = false;
            dgvPoruke.AllowUserToDeleteRows = false;
            dgvPoruke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPoruke.Columns.AddRange(new DataGridViewColumn[] { Predmet, Sadrzaj, Slika, Hitnost, Validnost, Brisi });
            dgvPoruke.Location = new Point(14, 46);
            dgvPoruke.Name = "dgvPoruke";
            dgvPoruke.ReadOnly = true;
            dgvPoruke.RowTemplate.Height = 25;
            dgvPoruke.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPoruke.Size = new Size(757, 281);
            dgvPoruke.TabIndex = 2;
            dgvPoruke.CellContentClick += dgvPoruke_CellContentClick;
            // 
            // Predmet
            // 
            Predmet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Predmet.DataPropertyName = "Predmet";
            Predmet.HeaderText = "Predmet";
            Predmet.Name = "Predmet";
            Predmet.ReadOnly = true;
            // 
            // Sadrzaj
            // 
            Sadrzaj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Sadrzaj.DataPropertyName = "Sadrzaj";
            Sadrzaj.HeaderText = "Sadrzaj";
            Sadrzaj.Name = "Sadrzaj";
            Sadrzaj.ReadOnly = true;
            // 
            // Slika
            // 
            Slika.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Slika.DataPropertyName = "Slika";
            Slika.HeaderText = "Slika";
            Slika.Name = "Slika";
            Slika.ReadOnly = true;
            // 
            // Hitnost
            // 
            Hitnost.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Hitnost.DataPropertyName = "Hitnost";
            Hitnost.HeaderText = "Hitnost";
            Hitnost.Name = "Hitnost";
            Hitnost.ReadOnly = true;
            // 
            // Validnost
            // 
            Validnost.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Validnost.DataPropertyName = "Validnost";
            Validnost.HeaderText = "Validnost";
            Validnost.Name = "Validnost";
            Validnost.ReadOnly = true;
            // 
            // Brisi
            // 
            Brisi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Brisi.HeaderText = "";
            Brisi.Name = "Brisi";
            Brisi.ReadOnly = true;
            Brisi.Text = "Brisi";
            Brisi.UseColumnTextForButtonValue = true;
            // 
            // button1
            // 
            button1.Location = new Point(665, 11);
            button1.Name = "button1";
            button1.Size = new Size(106, 23);
            button1.TabIndex = 3;
            button1.Text = "Nova poruka";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(665, 340);
            button2.Name = "button2";
            button2.Size = new Size(106, 23);
            button2.TabIndex = 4;
            button2.Text = "Printaj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(btnDodaj);
            groupBox1.Controls.Add(dtpValidnost);
            groupBox1.Controls.Add(cbPredmeti);
            groupBox1.Controls.Add(txtBrojPoruka);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(14, 383);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(761, 236);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodavanje poruka";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(328, 50);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(427, 176);
            txtInfo.TabIndex = 8;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(6, 203);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(305, 23);
            btnDodaj.TabIndex = 7;
            btnDodaj.Text = "Dodaj --->";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dtpValidnost
            // 
            dtpValidnost.Location = new Point(6, 171);
            dtpValidnost.Name = "dtpValidnost";
            dtpValidnost.Size = new Size(305, 23);
            dtpValidnost.TabIndex = 6;
            // 
            // cbPredmeti
            // 
            cbPredmeti.FormattingEnabled = true;
            cbPredmeti.Location = new Point(6, 113);
            cbPredmeti.Name = "cbPredmeti";
            cbPredmeti.Size = new Size(305, 23);
            cbPredmeti.TabIndex = 5;
            // 
            // txtBrojPoruka
            // 
            txtBrojPoruka.Location = new Point(6, 50);
            txtBrojPoruka.Name = "txtBrojPoruka";
            txtBrojPoruka.Size = new Size(305, 23);
            txtBrojPoruka.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(328, 29);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 3;
            label5.Text = "Info";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 148);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 2;
            label4.Text = "Poruka je validna do:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 90);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 1;
            label3.Text = "Predmet:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 29);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 0;
            label2.Text = "Broj poruka:";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmPorukeIB210224
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 625);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvPoruke);
            Controls.Add(lblStudent);
            Controls.Add(label1);
            Name = "frmPorukeIB210224";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPorukeIB210224";
            Load += frmPorukeIB210224_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPoruke).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblStudent;
        private DataGridView dgvPoruke;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Sadrzaj;
        private DataGridViewImageColumn Slika;
        private DataGridViewTextBoxColumn Hitnost;
        private DataGridViewTextBoxColumn Validnost;
        private DataGridViewButtonColumn Brisi;
        private GroupBox groupBox1;
        private Button btnDodaj;
        private DateTimePicker dtpValidnost;
        private ComboBox cbPredmeti;
        private TextBox txtBrojPoruka;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtInfo;
        private ErrorProvider err;
    }
}