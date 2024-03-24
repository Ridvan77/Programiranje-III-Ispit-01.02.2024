namespace FIT.WinForms.IB210224
{
    partial class frmGradoviIB210224
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
            pbZastava = new PictureBox();
            lblNazivDrzave = new Label();
            label2 = new Label();
            txtNazivGrada = new TextBox();
            button1 = new Button();
            dgvGradovi = new DataGridView();
            NazivGrada = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            PromijeniStatus = new DataGridViewButtonColumn();
            err = new ErrorProvider(components);
            groupBox1 = new GroupBox();
            label1 = new Label();
            txtBrojGradova = new TextBox();
            chbAktivni = new CheckBox();
            button2 = new Button();
            label3 = new Label();
            txtInfo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbZastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGradovi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pbZastava
            // 
            pbZastava.Location = new Point(12, 12);
            pbZastava.Name = "pbZastava";
            pbZastava.Size = new Size(100, 50);
            pbZastava.SizeMode = PictureBoxSizeMode.StretchImage;
            pbZastava.TabIndex = 0;
            pbZastava.TabStop = false;
            // 
            // lblNazivDrzave
            // 
            lblNazivDrzave.AutoSize = true;
            lblNazivDrzave.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNazivDrzave.Location = new Point(142, 25);
            lblNazivDrzave.Name = "lblNazivDrzave";
            lblNazivDrzave.Size = new Size(0, 25);
            lblNazivDrzave.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(149, 15);
            label2.TabIndex = 2;
            label2.Text = "Unesite naziv novog grada:";
            // 
            // txtNazivGrada
            // 
            txtNazivGrada.Location = new Point(179, 71);
            txtNazivGrada.Name = "txtNazivGrada";
            txtNazivGrada.Size = new Size(308, 23);
            txtNazivGrada.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(493, 71);
            button1.Name = "button1";
            button1.Size = new Size(107, 23);
            button1.TabIndex = 4;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvGradovi
            // 
            dgvGradovi.AllowUserToAddRows = false;
            dgvGradovi.AllowUserToDeleteRows = false;
            dgvGradovi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGradovi.Columns.AddRange(new DataGridViewColumn[] { NazivGrada, Aktivan, PromijeniStatus });
            dgvGradovi.Location = new Point(12, 100);
            dgvGradovi.Name = "dgvGradovi";
            dgvGradovi.ReadOnly = true;
            dgvGradovi.RowTemplate.Height = 25;
            dgvGradovi.Size = new Size(588, 189);
            dgvGradovi.TabIndex = 5;
            dgvGradovi.CellContentClick += dgvGradovi_CellContentClick;
            // 
            // NazivGrada
            // 
            NazivGrada.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NazivGrada.DataPropertyName = "NazivGrada";
            NazivGrada.HeaderText = "Naziv grada";
            NazivGrada.Name = "NazivGrada";
            NazivGrada.ReadOnly = true;
            // 
            // Aktivan
            // 
            Aktivan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Aktivan.DataPropertyName = "Status";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            // 
            // PromijeniStatus
            // 
            PromijeniStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PromijeniStatus.HeaderText = "";
            PromijeniStatus.Name = "PromijeniStatus";
            PromijeniStatus.ReadOnly = true;
            PromijeniStatus.Text = "Promijeni status";
            PromijeniStatus.UseColumnTextForButtonValue = true;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(chbAktivni);
            groupBox1.Controls.Add(txtBrojGradova);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 308);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(588, 200);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Broj gradova:";
            // 
            // txtBrojGradova
            // 
            txtBrojGradova.Location = new Point(89, 22);
            txtBrojGradova.Name = "txtBrojGradova";
            txtBrojGradova.Size = new Size(60, 23);
            txtBrojGradova.TabIndex = 1;
            // 
            // chbAktivni
            // 
            chbAktivni.AutoSize = true;
            chbAktivni.Location = new Point(168, 25);
            chbAktivni.Name = "chbAktivni";
            chbAktivni.Size = new Size(63, 19);
            chbAktivni.TabIndex = 2;
            chbAktivni.Text = "Aktivni";
            chbAktivni.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(253, 21);
            button2.Name = "button2";
            button2.Size = new Size(88, 23);
            button2.TabIndex = 7;
            button2.Text = "Generisi";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 53);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 8;
            label3.Text = "Info:";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(6, 71);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(576, 123);
            txtInfo.TabIndex = 9;
            // 
            // frmGradoviIB210224
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 520);
            Controls.Add(groupBox1);
            Controls.Add(dgvGradovi);
            Controls.Add(button1);
            Controls.Add(txtNazivGrada);
            Controls.Add(label2);
            Controls.Add(lblNazivDrzave);
            Controls.Add(pbZastava);
            Name = "frmGradoviIB210224";
            Text = "frmGradoviIB210224";
            Load += frmGradoviIB210224_Load;
            ((System.ComponentModel.ISupportInitialize)pbZastava).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGradovi).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbZastava;
        private Label lblNazivDrzave;
        private Label label2;
        private TextBox txtNazivGrada;
        private Button button1;
        private DataGridView dgvGradovi;
        private DataGridViewTextBoxColumn NazivGrada;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn PromijeniStatus;
        private ErrorProvider err;
        private GroupBox groupBox1;
        private Label label3;
        private Button button2;
        private CheckBox chbAktivni;
        private TextBox txtBrojGradova;
        private Label label1;
        private TextBox txtInfo;
    }
}