namespace DLWMS.WinForms.IB210224
{
    partial class frmNovaPorukaIB210224
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbPredmet = new ComboBox();
            dtpValidnost = new DateTimePicker();
            cbHitnost = new ComboBox();
            pbSlike = new PictureBox();
            txtSadrzaj = new TextBox();
            button1 = new Button();
            button2 = new Button();
            openFileDialog1 = new OpenFileDialog();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbSlike).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 21);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Odaberite predmet";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(428, 21);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "Slika";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 85);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 2;
            label3.Text = "Poruka je validna do:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 153);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 3;
            label4.Text = "Hitnost poruke:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 223);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 4;
            label5.Text = "Sadrzaj poruke:";
            // 
            // cbPredmet
            // 
            cbPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPredmet.FormattingEnabled = true;
            cbPredmet.Location = new Point(21, 45);
            cbPredmet.Name = "cbPredmet";
            cbPredmet.Size = new Size(383, 23);
            cbPredmet.TabIndex = 5;
            // 
            // dtpValidnost
            // 
            dtpValidnost.Location = new Point(21, 111);
            dtpValidnost.Name = "dtpValidnost";
            dtpValidnost.Size = new Size(383, 23);
            dtpValidnost.TabIndex = 6;
            // 
            // cbHitnost
            // 
            cbHitnost.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHitnost.FormattingEnabled = true;
            cbHitnost.Items.AddRange(new object[] { "Niska", "Srednja", "Visoka" });
            cbHitnost.Location = new Point(21, 179);
            cbHitnost.Name = "cbHitnost";
            cbHitnost.Size = new Size(383, 23);
            cbHitnost.TabIndex = 7;
            // 
            // pbSlike
            // 
            pbSlike.Location = new Point(428, 45);
            pbSlike.Name = "pbSlike";
            pbSlike.Size = new Size(349, 348);
            pbSlike.TabIndex = 8;
            pbSlike.TabStop = false;
            pbSlike.DoubleClick += pbSlike_DoubleClick;
            // 
            // txtSadrzaj
            // 
            txtSadrzaj.Location = new Point(21, 250);
            txtSadrzaj.Multiline = true;
            txtSadrzaj.Name = "txtSadrzaj";
            txtSadrzaj.Size = new Size(383, 143);
            txtSadrzaj.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(659, 406);
            button1.Name = "button1";
            button1.Size = new Size(118, 23);
            button1.TabIndex = 10;
            button1.Text = "Sacuvaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(515, 406);
            button2.Name = "button2";
            button2.Size = new Size(122, 23);
            button2.TabIndex = 11;
            button2.Text = "Odustani";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmNovaPorukaIB210224
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtSadrzaj);
            Controls.Add(pbSlike);
            Controls.Add(cbHitnost);
            Controls.Add(dtpValidnost);
            Controls.Add(cbPredmet);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNovaPorukaIB210224";
            Text = "Poruka";
            Load += frmNovaPorukaIB210224_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlike).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbPredmet;
        private DateTimePicker dtpValidnost;
        private ComboBox cbHitnost;
        private PictureBox pbSlike;
        private TextBox txtSadrzaj;
        private Button button1;
        private Button button2;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider err;
    }
}