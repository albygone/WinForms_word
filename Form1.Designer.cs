namespace Es20Word
{
    partial class frmWord
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCrea = new System.Windows.Forms.Button();
            this.txtTesto = new System.Windows.Forms.TextBox();
            this.lblTesto = new System.Windows.Forms.Label();
            this.btnInserisciTesto = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.cmbFont = new System.Windows.Forms.ComboBox();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.cmbSottolineato = new System.Windows.Forms.ComboBox();
            this.grbFont = new System.Windows.Forms.GroupBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.Allineamento = new System.Windows.Forms.Label();
            this.cmbAllineamento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbRighe = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbColonne = new System.Windows.Forms.ComboBox();
            this.btnTabella = new System.Windows.Forms.Button();
            this.grbFont.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrea
            // 
            this.btnCrea.Location = new System.Drawing.Point(12, 12);
            this.btnCrea.Name = "btnCrea";
            this.btnCrea.Size = new System.Drawing.Size(240, 71);
            this.btnCrea.TabIndex = 0;
            this.btnCrea.Text = "Crea Documento Word";
            this.btnCrea.UseVisualStyleBackColor = true;
            this.btnCrea.Click += new System.EventHandler(this.btnCrea_Click);
            // 
            // txtTesto
            // 
            this.txtTesto.Location = new System.Drawing.Point(351, 413);
            this.txtTesto.Name = "txtTesto";
            this.txtTesto.Size = new System.Drawing.Size(256, 29);
            this.txtTesto.TabIndex = 1;
            // 
            // lblTesto
            // 
            this.lblTesto.AutoSize = true;
            this.lblTesto.Location = new System.Drawing.Point(201, 413);
            this.lblTesto.Name = "lblTesto";
            this.lblTesto.Size = new System.Drawing.Size(144, 25);
            this.lblTesto.TabIndex = 2;
            this.lblTesto.Text = "Inserisci Testo:";
            // 
            // btnInserisciTesto
            // 
            this.btnInserisciTesto.Location = new System.Drawing.Point(625, 400);
            this.btnInserisciTesto.Name = "btnInserisciTesto";
            this.btnInserisciTesto.Size = new System.Drawing.Size(183, 56);
            this.btnInserisciTesto.TabIndex = 3;
            this.btnInserisciTesto.Text = "Inserisci Testo";
            this.btnInserisciTesto.UseVisualStyleBackColor = true;
            this.btnInserisciTesto.Click += new System.EventHandler(this.btnInserisciTesto_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(6, 86);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(121, 25);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Dimensione:";
            // 
            // cmbFont
            // 
            this.cmbFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFont.FormattingEnabled = true;
            this.cmbFont.Location = new System.Drawing.Point(180, 45);
            this.cmbFont.Name = "cmbFont";
            this.cmbFont.Size = new System.Drawing.Size(229, 32);
            this.cmbFont.TabIndex = 5;
            // 
            // cmbSize
            // 
            this.cmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Location = new System.Drawing.Point(180, 83);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(229, 32);
            this.cmbSize.TabIndex = 6;
            // 
            // cmbSottolineato
            // 
            this.cmbSottolineato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSottolineato.FormattingEnabled = true;
            this.cmbSottolineato.Location = new System.Drawing.Point(180, 121);
            this.cmbSottolineato.Name = "cmbSottolineato";
            this.cmbSottolineato.Size = new System.Drawing.Size(229, 32);
            this.cmbSottolineato.TabIndex = 8;
            // 
            // grbFont
            // 
            this.grbFont.Controls.Add(this.cmbColor);
            this.grbFont.Controls.Add(this.chkItalic);
            this.grbFont.Controls.Add(this.label4);
            this.grbFont.Controls.Add(this.chkBold);
            this.grbFont.Controls.Add(this.Allineamento);
            this.grbFont.Controls.Add(this.cmbAllineamento);
            this.grbFont.Controls.Add(this.label3);
            this.grbFont.Controls.Add(this.label2);
            this.grbFont.Controls.Add(this.cmbSottolineato);
            this.grbFont.Controls.Add(this.lbl1);
            this.grbFont.Controls.Add(this.cmbFont);
            this.grbFont.Controls.Add(this.cmbSize);
            this.grbFont.Location = new System.Drawing.Point(270, 22);
            this.grbFont.Name = "grbFont";
            this.grbFont.Size = new System.Drawing.Size(435, 315);
            this.grbFont.TabIndex = 9;
            this.grbFont.TabStop = false;
            this.grbFont.Text = "Font";
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Location = new System.Drawing.Point(175, 252);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(116, 29);
            this.chkItalic.TabIndex = 16;
            this.chkItalic.Text = "Corsivo?";
            this.chkItalic.UseVisualStyleBackColor = true;
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Location = new System.Drawing.Point(13, 252);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(133, 29);
            this.chkBold.TabIndex = 15;
            this.chkBold.Text = "Grassetto?";
            this.chkBold.UseVisualStyleBackColor = true;
            // 
            // Allineamento
            // 
            this.Allineamento.AutoSize = true;
            this.Allineamento.Location = new System.Drawing.Point(6, 162);
            this.Allineamento.Name = "Allineamento";
            this.Allineamento.Size = new System.Drawing.Size(127, 25);
            this.Allineamento.TabIndex = 12;
            this.Allineamento.Text = "Alineamento:";
            // 
            // cmbAllineamento
            // 
            this.cmbAllineamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAllineamento.FormattingEnabled = true;
            this.cmbAllineamento.Location = new System.Drawing.Point(180, 159);
            this.cmbAllineamento.Name = "cmbAllineamento";
            this.cmbAllineamento.Size = new System.Drawing.Size(229, 32);
            this.cmbAllineamento.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sottolineatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tipo:";
            // 
            // cmbColor
            // 
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(182, 197);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(229, 32);
            this.cmbColor.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Colore:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTabella);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbColonne);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbRighe);
            this.groupBox1.Location = new System.Drawing.Point(743, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 225);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabella";
            // 
            // cmbRighe
            // 
            this.cmbRighe.FormattingEnabled = true;
            this.cmbRighe.Location = new System.Drawing.Point(101, 34);
            this.cmbRighe.Name = "cmbRighe";
            this.cmbRighe.Size = new System.Drawing.Size(162, 32);
            this.cmbRighe.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Righe:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Colonne:";
            // 
            // cmbColonne
            // 
            this.cmbColonne.FormattingEnabled = true;
            this.cmbColonne.Location = new System.Drawing.Point(101, 79);
            this.cmbColonne.Name = "cmbColonne";
            this.cmbColonne.Size = new System.Drawing.Size(162, 32);
            this.cmbColonne.TabIndex = 2;
            // 
            // btnTabella
            // 
            this.btnTabella.Location = new System.Drawing.Point(11, 130);
            this.btnTabella.Name = "btnTabella";
            this.btnTabella.Size = new System.Drawing.Size(252, 57);
            this.btnTabella.TabIndex = 4;
            this.btnTabella.Text = "Crea";
            this.btnTabella.UseVisualStyleBackColor = true;
            this.btnTabella.Click += new System.EventHandler(this.btnTabella_Click);
            // 
            // frmWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 559);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbFont);
            this.Controls.Add(this.btnInserisciTesto);
            this.Controls.Add(this.lblTesto);
            this.Controls.Add(this.txtTesto);
            this.Controls.Add(this.btnCrea);
            this.Name = "frmWord";
            this.Text = "AlbyWord";
            this.Load += new System.EventHandler(this.frmWord_Load);
            this.grbFont.ResumeLayout(false);
            this.grbFont.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrea;
        private System.Windows.Forms.TextBox txtTesto;
        private System.Windows.Forms.Label lblTesto;
        private System.Windows.Forms.Button btnInserisciTesto;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ComboBox cmbFont;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.ComboBox cmbSottolineato;
        private System.Windows.Forms.GroupBox grbFont;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Allineamento;
        private System.Windows.Forms.ComboBox cmbAllineamento;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTabella;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbColonne;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbRighe;
    }
}

