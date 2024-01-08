namespace Öğrenci_Not_Takip_Sistemi
{
    partial class Ayarlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ayarlar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxTema = new System.Windows.Forms.GroupBox();
            this.radioButtonYesil = new System.Windows.Forms.RadioButton();
            this.radioButtonPembe = new System.Windows.Forms.RadioButton();
            this.radioButtonGri = new System.Windows.Forms.RadioButton();
            this.radioButtonMavi = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBoxTema.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.groupBoxTema);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 287);
            this.panel1.TabIndex = 0;
            // 
            // groupBoxTema
            // 
            this.groupBoxTema.Controls.Add(this.radioButtonYesil);
            this.groupBoxTema.Controls.Add(this.radioButtonPembe);
            this.groupBoxTema.Controls.Add(this.radioButtonGri);
            this.groupBoxTema.Controls.Add(this.radioButtonMavi);
            this.groupBoxTema.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxTema.Location = new System.Drawing.Point(12, 15);
            this.groupBoxTema.Name = "groupBoxTema";
            this.groupBoxTema.Size = new System.Drawing.Size(203, 257);
            this.groupBoxTema.TabIndex = 3;
            this.groupBoxTema.TabStop = false;
            this.groupBoxTema.Text = "Tema Rengi";
            // 
            // radioButtonYesil
            // 
            this.radioButtonYesil.AutoSize = true;
            this.radioButtonYesil.ForeColor = System.Drawing.Color.Green;
            this.radioButtonYesil.Location = new System.Drawing.Point(32, 144);
            this.radioButtonYesil.Name = "radioButtonYesil";
            this.radioButtonYesil.Size = new System.Drawing.Size(50, 18);
            this.radioButtonYesil.TabIndex = 3;
            this.radioButtonYesil.Text = "Yeşil";
            this.radioButtonYesil.UseVisualStyleBackColor = true;
            this.radioButtonYesil.CheckedChanged += new System.EventHandler(this.radioButtonYesil_CheckedChanged);
            // 
            // radioButtonPembe
            // 
            this.radioButtonPembe.AutoSize = true;
            this.radioButtonPembe.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.radioButtonPembe.Location = new System.Drawing.Point(32, 109);
            this.radioButtonPembe.Name = "radioButtonPembe";
            this.radioButtonPembe.Size = new System.Drawing.Size(62, 18);
            this.radioButtonPembe.TabIndex = 1;
            this.radioButtonPembe.Text = "Pembe";
            this.radioButtonPembe.UseVisualStyleBackColor = true;
            this.radioButtonPembe.CheckedChanged += new System.EventHandler(this.radioButtonPembe_CheckedChanged);
            // 
            // radioButtonGri
            // 
            this.radioButtonGri.AutoSize = true;
            this.radioButtonGri.ForeColor = System.Drawing.Color.DimGray;
            this.radioButtonGri.Location = new System.Drawing.Point(32, 75);
            this.radioButtonGri.Name = "radioButtonGri";
            this.radioButtonGri.Size = new System.Drawing.Size(40, 18);
            this.radioButtonGri.TabIndex = 2;
            this.radioButtonGri.Text = "Gri";
            this.radioButtonGri.UseVisualStyleBackColor = true;
            this.radioButtonGri.CheckedChanged += new System.EventHandler(this.radioButtonGri_CheckedChanged);
            // 
            // radioButtonMavi
            // 
            this.radioButtonMavi.AutoSize = true;
            this.radioButtonMavi.Checked = true;
            this.radioButtonMavi.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.radioButtonMavi.Location = new System.Drawing.Point(32, 41);
            this.radioButtonMavi.Name = "radioButtonMavi";
            this.radioButtonMavi.Size = new System.Drawing.Size(50, 18);
            this.radioButtonMavi.TabIndex = 0;
            this.radioButtonMavi.TabStop = true;
            this.radioButtonMavi.Text = "Mavi";
            this.radioButtonMavi.UseVisualStyleBackColor = true;
            this.radioButtonMavi.CheckedChanged += new System.EventHandler(this.radioButtonMavi_CheckedChanged);
            // 
            // Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(252, 311);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(268, 350);
            this.MinimumSize = new System.Drawing.Size(268, 350);
            this.Name = "Ayarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            this.panel1.ResumeLayout(false);
            this.groupBoxTema.ResumeLayout(false);
            this.groupBoxTema.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxTema;
        private System.Windows.Forms.RadioButton radioButtonPembe;
        private System.Windows.Forms.RadioButton radioButtonGri;
        private System.Windows.Forms.RadioButton radioButtonMavi;
        private System.Windows.Forms.RadioButton radioButtonYesil;
    }
}