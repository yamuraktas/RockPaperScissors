﻿
namespace TasKagitMakas
{
    partial class FormIntro
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHamleSayisi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(32, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 106);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kullanıcı \r\nVs \r\nBilgisayar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(272, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 106);
            this.button2.TabIndex = 1;
            this.button2.Text = "Bilgisayar\r\nVs \r\nBilgisayar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hamle Sayısı :";
            // 
            // txtHamleSayisi
            // 
            this.txtHamleSayisi.Location = new System.Drawing.Point(153, 21);
            this.txtHamleSayisi.Name = "txtHamleSayisi";
            this.txtHamleSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtHamleSayisi.TabIndex = 3;
            this.txtHamleSayisi.Text = "10";
            // 
            // FormIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 227);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtHamleSayisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "FormIntro";
            this.Text = "FormIntro";
            this.Load += new System.EventHandler(this.FormIntro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHamleSayisi;
    }
}