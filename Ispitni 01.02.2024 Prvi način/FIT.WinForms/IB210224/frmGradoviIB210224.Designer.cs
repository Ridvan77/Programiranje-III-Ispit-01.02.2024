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
            lblDrzava = new Label();
            label1 = new Label();
            txtNoviGrad = new TextBox();
            button1 = new Button();
            dgvGradovi = new DataGridView();
            NazivGrada = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            PromijeniStatus = new DataGridViewButtonColumn();
            groupBox1 = new GroupBox();
            button2 = new Button();
            chbAktivni = new CheckBox();
            txtBrojGradova = new TextBox();
            txtInfo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbZastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGradovi).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
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
            // lblDrzava
            // 
            lblDrzava.AutoSize = true;
            lblDrzava.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrzava.Location = new Point(140, 24);
            lblDrzava.Name = "lblDrzava";
            lblDrzava.Size = new Size(0, 28);
            lblDrzava.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 88);
            label1.Name = "label1";
            label1.Size = new Size(149, 15);
            label1.TabIndex = 2;
            label1.Text = "Unesite naziv novog grada:";
            // 
            // txtNoviGrad
            // 
            txtNoviGrad.Location = new Point(171, 85);
            txtNoviGrad.Name = "txtNoviGrad";
            txtNoviGrad.Size = new Size(232, 23);
            txtNoviGrad.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(416, 85);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
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
            dgvGradovi.Location = new Point(12, 125);
            dgvGradovi.Name = "dgvGradovi";
            dgvGradovi.ReadOnly = true;
            dgvGradovi.RowTemplate.Height = 25;
            dgvGradovi.Size = new Size(479, 140);
            dgvGradovi.TabIndex = 5;
            dgvGradovi.CellClick += dgvGradovi_CellClick;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(chbAktivni);
            groupBox1.Controls.Add(txtBrojGradova);
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 286);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(479, 192);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator";
            // 
            // button2
            // 
            button2.Location = new Point(299, 25);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Generisi";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // chbAktivni
            // 
            chbAktivni.AutoSize = true;
            chbAktivni.Location = new Point(218, 27);
            chbAktivni.Name = "chbAktivni";
            chbAktivni.Size = new Size(63, 19);
            chbAktivni.TabIndex = 4;
            chbAktivni.Text = "Aktivni";
            chbAktivni.UseVisualStyleBackColor = true;
            // 
            // txtBrojGradova
            // 
            txtBrojGradova.Location = new Point(96, 25);
            txtBrojGradova.Name = "txtBrojGradova";
            txtBrojGradova.Size = new Size(100, 23);
            txtBrojGradova.TabIndex = 3;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(10, 75);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(463, 111);
            txtInfo.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 57);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 1;
            label3.Text = "Info:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 28);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 0;
            label2.Text = "Broj gradova:";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmGradoviIB210224
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 490);
            Controls.Add(groupBox1);
            Controls.Add(dgvGradovi);
            Controls.Add(button1);
            Controls.Add(txtNoviGrad);
            Controls.Add(label1);
            Controls.Add(lblDrzava);
            Controls.Add(pbZastava);
            Name = "frmGradoviIB210224";
            Text = "Podaci o gradu";
            FormClosed += frmGradoviIB210224_FormClosed;
            Load += frmGradoviIB210224_Load;
            ((System.ComponentModel.ISupportInitialize)pbZastava).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGradovi).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbZastava;
        private Label lblDrzava;
        private Label label1;
        private TextBox txtNoviGrad;
        private Button button1;
        private DataGridView dgvGradovi;
        private GroupBox groupBox1;
        private Button button2;
        private CheckBox chbAktivni;
        private TextBox txtBrojGradova;
        private TextBox txtInfo;
        private Label label3;
        private Label label2;
        private DataGridViewTextBoxColumn NazivGrada;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn PromijeniStatus;
        private ErrorProvider err;
    }
}