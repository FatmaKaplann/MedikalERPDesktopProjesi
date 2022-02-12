
namespace IEA_ErpProject102_Main.BilgiGirisIslemleri.Hastaneler
{
    partial class frmHastaneGirisEkrani
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
            this.pnlUst = new System.Windows.Forms.Panel();
            this.pnlAlt = new System.Windows.Forms.Panel();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtYetAdi1 = new System.Windows.Forms.TextBox();
            this.txtYetDep1 = new System.Windows.Forms.ComboBox();
            this.txtYetAdi2 = new System.Windows.Forms.TextBox();
            this.txtYetDep2 = new System.Windows.Forms.ComboBox();
            this.txtYetAdi3 = new System.Windows.Forms.TextBox();
            this.txtYetDep3 = new System.Windows.Forms.ComboBox();
            this.txtYetTel1 = new System.Windows.Forms.MaskedTextBox();
            this.txtYetCep1 = new System.Windows.Forms.MaskedTextBox();
            this.txtYetEmail1 = new System.Windows.Forms.TextBox();
            this.txtYetTel2 = new System.Windows.Forms.MaskedTextBox();
            this.txtYetCep2 = new System.Windows.Forms.MaskedTextBox();
            this.txtYetEmail2 = new System.Windows.Forms.TextBox();
            this.txtYetTel3 = new System.Windows.Forms.MaskedTextBox();
            this.txtYetCep3 = new System.Windows.Forms.MaskedTextBox();
            this.txtYetEmail3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtHastTipi = new System.Windows.Forms.ComboBox();
            this.txtHastAdi = new System.Windows.Forms.TextBox();
            this.txtHastUnvan = new System.Windows.Forms.TextBox();
            this.txtAdres2 = new System.Windows.Forms.TextBox();
            this.txtAdres1 = new System.Windows.Forms.TextBox();
            this.txtHastTel = new System.Windows.Forms.MaskedTextBox();
            this.txtHastMail = new System.Windows.Forms.TextBox();
            this.txtSehir = new System.Windows.Forms.ComboBox();
            this.txtVergiD = new System.Windows.Forms.TextBox();
            this.txtVnTc = new System.Windows.Forms.MaskedTextBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.BtnKayit = new System.Windows.Forms.Button();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlUst.Controls.Add(this.btnCikis);
            this.pnlUst.Controls.Add(this.btnSil);
            this.pnlUst.Controls.Add(this.btnGuncelle);
            this.pnlUst.Controls.Add(this.BtnKayit);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(1200, 71);
            this.pnlUst.TabIndex = 0;
            // 
            // pnlAlt
            // 
            this.pnlAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAlt.Location = new System.Drawing.Point(0, 579);
            this.pnlAlt.Name = "pnlAlt";
            this.pnlAlt.Size = new System.Drawing.Size(1200, 36);
            this.pnlAlt.TabIndex = 1;
            // 
            // Liste
            // 
            this.Liste.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Liste.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Liste.Location = new System.Drawing.Point(0, 379);
            this.Liste.Name = "Liste";
            this.Liste.RowHeadersWidth = 51;
            this.Liste.RowTemplate.Height = 24;
            this.Liste.Size = new System.Drawing.Size(1200, 200);
            this.Liste.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 363);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1200, 16);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(22, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hastane Adi :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hastane Unvan :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(22, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adres 1 :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(454, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Adres 2 :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(22, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vergi Dairesi :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(298, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 48);
            this.label6.TabIndex = 4;
            this.label6.Text = "Vergi No - Tc No :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(22, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Hastane Tel :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(620, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Departmani";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(994, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 4;
            this.label9.Text = "E-Mail";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(876, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 23);
            this.label10.TabIndex = 4;
            this.label10.Text = "Cep Telefonu";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(766, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 4;
            this.label11.Text = "Telefon";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(488, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 4;
            this.label12.Text = "Yetkili Adi";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtYetAdi1
            // 
            this.txtYetAdi1.Location = new System.Drawing.Point(457, 104);
            this.txtYetAdi1.Name = "txtYetAdi1";
            this.txtYetAdi1.Size = new System.Drawing.Size(160, 22);
            this.txtYetAdi1.TabIndex = 10;
            // 
            // txtYetDep1
            // 
            this.txtYetDep1.FormattingEnabled = true;
            this.txtYetDep1.Location = new System.Drawing.Point(623, 104);
            this.txtYetDep1.Name = "txtYetDep1";
            this.txtYetDep1.Size = new System.Drawing.Size(137, 24);
            this.txtYetDep1.TabIndex = 11;
            // 
            // txtYetAdi2
            // 
            this.txtYetAdi2.Location = new System.Drawing.Point(457, 132);
            this.txtYetAdi2.Name = "txtYetAdi2";
            this.txtYetAdi2.Size = new System.Drawing.Size(160, 22);
            this.txtYetAdi2.TabIndex = 15;
            // 
            // txtYetDep2
            // 
            this.txtYetDep2.FormattingEnabled = true;
            this.txtYetDep2.Location = new System.Drawing.Point(623, 132);
            this.txtYetDep2.Name = "txtYetDep2";
            this.txtYetDep2.Size = new System.Drawing.Size(137, 24);
            this.txtYetDep2.TabIndex = 16;
            // 
            // txtYetAdi3
            // 
            this.txtYetAdi3.Location = new System.Drawing.Point(457, 160);
            this.txtYetAdi3.Name = "txtYetAdi3";
            this.txtYetAdi3.Size = new System.Drawing.Size(160, 22);
            this.txtYetAdi3.TabIndex = 20;
            // 
            // txtYetDep3
            // 
            this.txtYetDep3.FormattingEnabled = true;
            this.txtYetDep3.Location = new System.Drawing.Point(623, 160);
            this.txtYetDep3.Name = "txtYetDep3";
            this.txtYetDep3.Size = new System.Drawing.Size(137, 24);
            this.txtYetDep3.TabIndex = 21;
            // 
            // txtYetTel1
            // 
            this.txtYetTel1.Location = new System.Drawing.Point(766, 104);
            this.txtYetTel1.Mask = "(999) 000-0000";
            this.txtYetTel1.Name = "txtYetTel1";
            this.txtYetTel1.Size = new System.Drawing.Size(107, 22);
            this.txtYetTel1.TabIndex = 12;
            // 
            // txtYetCep1
            // 
            this.txtYetCep1.Location = new System.Drawing.Point(879, 104);
            this.txtYetCep1.Mask = "(999) 000-0000";
            this.txtYetCep1.Name = "txtYetCep1";
            this.txtYetCep1.Size = new System.Drawing.Size(109, 22);
            this.txtYetCep1.TabIndex = 13;
            // 
            // txtYetEmail1
            // 
            this.txtYetEmail1.Location = new System.Drawing.Point(994, 104);
            this.txtYetEmail1.Name = "txtYetEmail1";
            this.txtYetEmail1.Size = new System.Drawing.Size(192, 22);
            this.txtYetEmail1.TabIndex = 14;
            // 
            // txtYetTel2
            // 
            this.txtYetTel2.Location = new System.Drawing.Point(766, 130);
            this.txtYetTel2.Mask = "(999) 000-0000";
            this.txtYetTel2.Name = "txtYetTel2";
            this.txtYetTel2.Size = new System.Drawing.Size(107, 22);
            this.txtYetTel2.TabIndex = 17;
            // 
            // txtYetCep2
            // 
            this.txtYetCep2.Location = new System.Drawing.Point(879, 130);
            this.txtYetCep2.Mask = "(999) 000-0000";
            this.txtYetCep2.Name = "txtYetCep2";
            this.txtYetCep2.Size = new System.Drawing.Size(109, 22);
            this.txtYetCep2.TabIndex = 18;
            // 
            // txtYetEmail2
            // 
            this.txtYetEmail2.Location = new System.Drawing.Point(994, 130);
            this.txtYetEmail2.Name = "txtYetEmail2";
            this.txtYetEmail2.Size = new System.Drawing.Size(192, 22);
            this.txtYetEmail2.TabIndex = 19;
            // 
            // txtYetTel3
            // 
            this.txtYetTel3.Location = new System.Drawing.Point(766, 158);
            this.txtYetTel3.Mask = "(999) 000-0000";
            this.txtYetTel3.Name = "txtYetTel3";
            this.txtYetTel3.Size = new System.Drawing.Size(107, 22);
            this.txtYetTel3.TabIndex = 22;
            // 
            // txtYetCep3
            // 
            this.txtYetCep3.Location = new System.Drawing.Point(879, 158);
            this.txtYetCep3.Mask = "(999) 000-0000";
            this.txtYetCep3.Name = "txtYetCep3";
            this.txtYetCep3.Size = new System.Drawing.Size(109, 22);
            this.txtYetCep3.TabIndex = 23;
            // 
            // txtYetEmail3
            // 
            this.txtYetEmail3.Location = new System.Drawing.Point(994, 158);
            this.txtYetEmail3.Name = "txtYetEmail3";
            this.txtYetEmail3.Size = new System.Drawing.Size(192, 22);
            this.txtYetEmail3.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(25, 281);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 4;
            this.label13.Text = "Hastane Mail :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(22, 170);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 4;
            this.label14.Text = "Sehir :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(22, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 4;
            this.label15.Text = "Hastane Tip :";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHastTipi
            // 
            this.txtHastTipi.FormattingEnabled = true;
            this.txtHastTipi.Location = new System.Drawing.Point(128, 77);
            this.txtHastTipi.Name = "txtHastTipi";
            this.txtHastTipi.Size = new System.Drawing.Size(178, 24);
            this.txtHastTipi.TabIndex = 0;
            // 
            // txtHastAdi
            // 
            this.txtHastAdi.Location = new System.Drawing.Point(128, 111);
            this.txtHastAdi.Name = "txtHastAdi";
            this.txtHastAdi.Size = new System.Drawing.Size(319, 22);
            this.txtHastAdi.TabIndex = 1;
            // 
            // txtHastUnvan
            // 
            this.txtHastUnvan.Location = new System.Drawing.Point(128, 142);
            this.txtHastUnvan.Name = "txtHastUnvan";
            this.txtHastUnvan.Size = new System.Drawing.Size(319, 22);
            this.txtHastUnvan.TabIndex = 2;
            // 
            // txtAdres2
            // 
            this.txtAdres2.Location = new System.Drawing.Point(560, 200);
            this.txtAdres2.Multiline = true;
            this.txtAdres2.Name = "txtAdres2";
            this.txtAdres2.Size = new System.Drawing.Size(319, 46);
            this.txtAdres2.TabIndex = 5;
            // 
            // txtAdres1
            // 
            this.txtAdres1.Location = new System.Drawing.Point(128, 200);
            this.txtAdres1.Multiline = true;
            this.txtAdres1.Name = "txtAdres1";
            this.txtAdres1.Size = new System.Drawing.Size(319, 46);
            this.txtAdres1.TabIndex = 4;
            // 
            // txtHastTel
            // 
            this.txtHastTel.Location = new System.Drawing.Point(128, 252);
            this.txtHastTel.Mask = "(999) 000-0000";
            this.txtHastTel.Name = "txtHastTel";
            this.txtHastTel.Size = new System.Drawing.Size(117, 22);
            this.txtHastTel.TabIndex = 6;
            // 
            // txtHastMail
            // 
            this.txtHastMail.Location = new System.Drawing.Point(128, 280);
            this.txtHastMail.Name = "txtHastMail";
            this.txtHastMail.Size = new System.Drawing.Size(158, 22);
            this.txtHastMail.TabIndex = 7;
            // 
            // txtSehir
            // 
            this.txtSehir.FormattingEnabled = true;
            this.txtSehir.Location = new System.Drawing.Point(128, 170);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(178, 24);
            this.txtSehir.TabIndex = 3;
            // 
            // txtVergiD
            // 
            this.txtVergiD.Location = new System.Drawing.Point(128, 312);
            this.txtVergiD.Name = "txtVergiD";
            this.txtVergiD.Size = new System.Drawing.Size(158, 22);
            this.txtVergiD.TabIndex = 8;
            // 
            // txtVnTc
            // 
            this.txtVnTc.Location = new System.Drawing.Point(372, 312);
            this.txtVnTc.Mask = "00000000000";
            this.txtVnTc.Name = "txtVnTc";
            this.txtVnTc.Size = new System.Drawing.Size(100, 22);
            this.txtVnTc.TabIndex = 9;
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.BackgroundImage = global::IEA_ErpProject102_Main.Properties.Resources.exit_64;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.Location = new System.Drawing.Point(1111, 8);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 56);
            this.btnCikis.TabIndex = 0;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = global::IEA_ErpProject102_Main.Properties.Resources.cop24x24;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.Location = new System.Drawing.Point(132, 12);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(54, 46);
            this.btnSil.TabIndex = 0;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundImage = global::IEA_ErpProject102_Main.Properties.Resources.Update32x32;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.Location = new System.Drawing.Point(72, 12);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(54, 46);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // BtnKayit
            // 
            this.BtnKayit.BackgroundImage = global::IEA_ErpProject102_Main.Properties.Resources.Save_icon64x64;
            this.BtnKayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnKayit.Location = new System.Drawing.Point(12, 12);
            this.BtnKayit.Name = "BtnKayit";
            this.BtnKayit.Size = new System.Drawing.Size(54, 46);
            this.BtnKayit.TabIndex = 0;
            this.BtnKayit.Tag = "";
            this.BtnKayit.UseVisualStyleBackColor = true;
            this.BtnKayit.Click += new System.EventHandler(this.BtnKayit_Click);
            // 
            // frmHastaneGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 615);
            this.Controls.Add(this.txtVnTc);
            this.Controls.Add(this.txtVergiD);
            this.Controls.Add(this.txtSehir);
            this.Controls.Add(this.txtHastMail);
            this.Controls.Add(this.txtHastTel);
            this.Controls.Add(this.txtHastUnvan);
            this.Controls.Add(this.txtAdres1);
            this.Controls.Add(this.txtAdres2);
            this.Controls.Add(this.txtHastAdi);
            this.Controls.Add(this.txtHastTipi);
            this.Controls.Add(this.txtYetEmail3);
            this.Controls.Add(this.txtYetCep3);
            this.Controls.Add(this.txtYetEmail2);
            this.Controls.Add(this.txtYetCep2);
            this.Controls.Add(this.txtYetTel3);
            this.Controls.Add(this.txtYetEmail1);
            this.Controls.Add(this.txtYetTel2);
            this.Controls.Add(this.txtYetCep1);
            this.Controls.Add(this.txtYetTel1);
            this.Controls.Add(this.txtYetDep3);
            this.Controls.Add(this.txtYetDep2);
            this.Controls.Add(this.txtYetDep1);
            this.Controls.Add(this.txtYetAdi3);
            this.Controls.Add(this.txtYetAdi2);
            this.Controls.Add(this.txtYetAdi1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.pnlAlt);
            this.Controls.Add(this.pnlUst);
            this.Name = "frmHastaneGirisEkrani";
            this.Text = "frmHastaneGirisEkrani";
            this.pnlUst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Panel pnlAlt;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtYetAdi1;
        private System.Windows.Forms.ComboBox txtYetDep1;
        private System.Windows.Forms.TextBox txtYetAdi2;
        private System.Windows.Forms.ComboBox txtYetDep2;
        private System.Windows.Forms.TextBox txtYetAdi3;
        private System.Windows.Forms.ComboBox txtYetDep3;
        private System.Windows.Forms.MaskedTextBox txtYetTel1;
        private System.Windows.Forms.MaskedTextBox txtYetCep1;
        private System.Windows.Forms.TextBox txtYetEmail1;
        private System.Windows.Forms.MaskedTextBox txtYetTel2;
        private System.Windows.Forms.MaskedTextBox txtYetCep2;
        private System.Windows.Forms.TextBox txtYetEmail2;
        private System.Windows.Forms.MaskedTextBox txtYetTel3;
        private System.Windows.Forms.MaskedTextBox txtYetCep3;
        private System.Windows.Forms.TextBox txtYetEmail3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox txtHastTipi;
        private System.Windows.Forms.TextBox txtHastAdi;
        private System.Windows.Forms.TextBox txtHastUnvan;
        private System.Windows.Forms.TextBox txtAdres2;
        private System.Windows.Forms.TextBox txtAdres1;
        private System.Windows.Forms.MaskedTextBox txtHastTel;
        private System.Windows.Forms.TextBox txtHastMail;
        private System.Windows.Forms.ComboBox txtSehir;
        private System.Windows.Forms.TextBox txtVergiD;
        private System.Windows.Forms.MaskedTextBox txtVnTc;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button BtnKayit;
    }
}