﻿
namespace SystemIOWindowsFormApp
{
    partial class Form1
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
            this.groupBoxPersonelListe = new System.Windows.Forms.GroupBox();
            this.groupBoxPersonelDetay = new System.Windows.Forms.GroupBox();
            this.listBoxPersoneller = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFirma = new System.Windows.Forms.TextBox();
            this.txtUlke = new System.Windows.Forms.TextBox();
            this.btnPersonelKaydet = new System.Windows.Forms.Button();
            this.btnPersonelGetir = new System.Windows.Forms.Button();
            this.groupBoxPersonelListe.SuspendLayout();
            this.groupBoxPersonelDetay.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPersonelListe
            // 
            this.groupBoxPersonelListe.Controls.Add(this.btnPersonelGetir);
            this.groupBoxPersonelListe.Controls.Add(this.listBoxPersoneller);
            this.groupBoxPersonelListe.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPersonelListe.Name = "groupBoxPersonelListe";
            this.groupBoxPersonelListe.Size = new System.Drawing.Size(239, 426);
            this.groupBoxPersonelListe.TabIndex = 0;
            this.groupBoxPersonelListe.TabStop = false;
            this.groupBoxPersonelListe.Text = "Personel Listesi";
            // 
            // groupBoxPersonelDetay
            // 
            this.groupBoxPersonelDetay.Controls.Add(this.txtUlke);
            this.groupBoxPersonelDetay.Controls.Add(this.txtFirma);
            this.groupBoxPersonelDetay.Controls.Add(this.txtEmail);
            this.groupBoxPersonelDetay.Controls.Add(this.txtSoyisim);
            this.groupBoxPersonelDetay.Controls.Add(this.txtIsim);
            this.groupBoxPersonelDetay.Controls.Add(this.label5);
            this.groupBoxPersonelDetay.Controls.Add(this.label1);
            this.groupBoxPersonelDetay.Controls.Add(this.label2);
            this.groupBoxPersonelDetay.Controls.Add(this.label3);
            this.groupBoxPersonelDetay.Controls.Add(this.label4);
            this.groupBoxPersonelDetay.Location = new System.Drawing.Point(257, 12);
            this.groupBoxPersonelDetay.Name = "groupBoxPersonelDetay";
            this.groupBoxPersonelDetay.Size = new System.Drawing.Size(398, 244);
            this.groupBoxPersonelDetay.TabIndex = 1;
            this.groupBoxPersonelDetay.TabStop = false;
            this.groupBoxPersonelDetay.Text = "Personel Bilgileri";
            // 
            // listBoxPersoneller
            // 
            this.listBoxPersoneller.FormattingEnabled = true;
            this.listBoxPersoneller.ItemHeight = 16;
            this.listBoxPersoneller.Location = new System.Drawing.Point(6, 21);
            this.listBoxPersoneller.Name = "listBoxPersoneller";
            this.listBoxPersoneller.Size = new System.Drawing.Size(233, 340);
            this.listBoxPersoneller.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "İsim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyisim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "E-Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Firma:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ülke:";
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(67, 33);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(325, 22);
            this.txtIsim.TabIndex = 7;
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(67, 70);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(325, 22);
            this.txtSoyisim.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(67, 114);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(325, 22);
            this.txtEmail.TabIndex = 9;
            // 
            // txtFirma
            // 
            this.txtFirma.Location = new System.Drawing.Point(67, 160);
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.Size = new System.Drawing.Size(325, 22);
            this.txtFirma.TabIndex = 10;
            // 
            // txtUlke
            // 
            this.txtUlke.Location = new System.Drawing.Point(67, 199);
            this.txtUlke.Name = "txtUlke";
            this.txtUlke.Size = new System.Drawing.Size(325, 22);
            this.txtUlke.TabIndex = 11;
            // 
            // btnPersonelKaydet
            // 
            this.btnPersonelKaydet.Location = new System.Drawing.Point(257, 262);
            this.btnPersonelKaydet.Name = "btnPersonelKaydet";
            this.btnPersonelKaydet.Size = new System.Drawing.Size(398, 53);
            this.btnPersonelKaydet.TabIndex = 2;
            this.btnPersonelKaydet.Text = "PERSONELİ BİLGİSAYARIMA KAYDET";
            this.btnPersonelKaydet.UseVisualStyleBackColor = true;
            // 
            // btnPersonelGetir
            // 
            this.btnPersonelGetir.Location = new System.Drawing.Point(6, 379);
            this.btnPersonelGetir.Name = "btnPersonelGetir";
            this.btnPersonelGetir.Size = new System.Drawing.Size(227, 41);
            this.btnPersonelGetir.TabIndex = 3;
            this.btnPersonelGetir.Text = "PERSONEL GETİR";
            this.btnPersonelGetir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.btnPersonelKaydet);
            this.Controls.Add(this.groupBoxPersonelDetay);
            this.Controls.Add(this.groupBoxPersonelListe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxPersonelListe.ResumeLayout(false);
            this.groupBoxPersonelDetay.ResumeLayout(false);
            this.groupBoxPersonelDetay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPersonelListe;
        private System.Windows.Forms.Button btnPersonelGetir;
        private System.Windows.Forms.ListBox listBoxPersoneller;
        private System.Windows.Forms.GroupBox groupBoxPersonelDetay;
        private System.Windows.Forms.TextBox txtUlke;
        private System.Windows.Forms.TextBox txtFirma;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPersonelKaydet;
    }
}

