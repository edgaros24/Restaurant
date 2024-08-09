
namespace Restaurant
{
    partial class MenuDarbuotojams
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
            this.btn_atsijungti = new System.Windows.Forms.Button();
            this.btn_uzrezervuoti = new System.Windows.Forms.Button();
            this.btn_uzsisakyti = new System.Windows.Forms.Button();
            this.btn_atsiliepimai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_atsijungti
            // 
            this.btn_atsijungti.Location = new System.Drawing.Point(680, 14);
            this.btn_atsijungti.Name = "btn_atsijungti";
            this.btn_atsijungti.Size = new System.Drawing.Size(101, 32);
            this.btn_atsijungti.TabIndex = 7;
            this.btn_atsijungti.Text = "Atsijungti";
            this.btn_atsijungti.UseVisualStyleBackColor = true;
            this.btn_atsijungti.Click += new System.EventHandler(this.btn_atsijungti_Click);
            // 
            // btn_uzrezervuoti
            // 
            this.btn_uzrezervuoti.Location = new System.Drawing.Point(510, 80);
            this.btn_uzrezervuoti.Name = "btn_uzrezervuoti";
            this.btn_uzrezervuoti.Size = new System.Drawing.Size(141, 59);
            this.btn_uzrezervuoti.TabIndex = 6;
            this.btn_uzrezervuoti.Text = "Darbo laikas";
            this.btn_uzrezervuoti.UseVisualStyleBackColor = true;
            this.btn_uzrezervuoti.Click += new System.EventHandler(this.btn_uzrezervuoti_Click);
            // 
            // btn_uzsisakyti
            // 
            this.btn_uzsisakyti.Location = new System.Drawing.Point(298, 80);
            this.btn_uzsisakyti.Name = "btn_uzsisakyti";
            this.btn_uzsisakyti.Size = new System.Drawing.Size(141, 59);
            this.btn_uzsisakyti.TabIndex = 5;
            this.btn_uzsisakyti.Text = "Uzsakymai";
            this.btn_uzsisakyti.UseVisualStyleBackColor = true;
            this.btn_uzsisakyti.Click += new System.EventHandler(this.btn_uzsisakyti_Click);
            // 
            // btn_atsiliepimai
            // 
            this.btn_atsiliepimai.Location = new System.Drawing.Point(72, 81);
            this.btn_atsiliepimai.Name = "btn_atsiliepimai";
            this.btn_atsiliepimai.Size = new System.Drawing.Size(141, 59);
            this.btn_atsiliepimai.TabIndex = 4;
            this.btn_atsiliepimai.Text = "Atsiliepimai";
            this.btn_atsiliepimai.UseVisualStyleBackColor = true;
            this.btn_atsiliepimai.Click += new System.EventHandler(this.btn_atsiliepimai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // MenuDarbuotojams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 222);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_atsijungti);
            this.Controls.Add(this.btn_uzrezervuoti);
            this.Controls.Add(this.btn_uzsisakyti);
            this.Controls.Add(this.btn_atsiliepimai);
            this.Name = "MenuDarbuotojams";
            this.Text = "MenuDarbuotojams";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_atsijungti;
        private System.Windows.Forms.Button btn_uzrezervuoti;
        private System.Windows.Forms.Button btn_uzsisakyti;
        private System.Windows.Forms.Button btn_atsiliepimai;
        private System.Windows.Forms.Label label1;
    }
}