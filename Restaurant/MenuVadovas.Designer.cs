
namespace Restaurant
{
    partial class MenuVadovas
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
            this.btn_darbuotojai = new System.Windows.Forms.Button();
            this.btn_uzsakymai = new System.Windows.Forms.Button();
            this.btn_atsiliepimai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_atsijungti
            // 
            this.btn_atsijungti.Location = new System.Drawing.Point(680, 22);
            this.btn_atsijungti.Name = "btn_atsijungti";
            this.btn_atsijungti.Size = new System.Drawing.Size(101, 32);
            this.btn_atsijungti.TabIndex = 7;
            this.btn_atsijungti.Text = "Atsijungti";
            this.btn_atsijungti.UseVisualStyleBackColor = true;
            this.btn_atsijungti.Click += new System.EventHandler(this.btn_atsijungti_Click);
            // 
            // btn_darbuotojai
            // 
            this.btn_darbuotojai.Location = new System.Drawing.Point(510, 88);
            this.btn_darbuotojai.Name = "btn_darbuotojai";
            this.btn_darbuotojai.Size = new System.Drawing.Size(141, 59);
            this.btn_darbuotojai.TabIndex = 6;
            this.btn_darbuotojai.Text = "Darbuotojai";
            this.btn_darbuotojai.UseVisualStyleBackColor = true;
            this.btn_darbuotojai.Click += new System.EventHandler(this.btn_uzrezervuoti_Click);
            // 
            // btn_uzsakymai
            // 
            this.btn_uzsakymai.Location = new System.Drawing.Point(298, 88);
            this.btn_uzsakymai.Name = "btn_uzsakymai";
            this.btn_uzsakymai.Size = new System.Drawing.Size(141, 59);
            this.btn_uzsakymai.TabIndex = 5;
            this.btn_uzsakymai.Text = "Uzsakymai";
            this.btn_uzsakymai.UseVisualStyleBackColor = true;
            this.btn_uzsakymai.Click += new System.EventHandler(this.btn_uzsisakyti_Click);
            // 
            // btn_atsiliepimai
            // 
            this.btn_atsiliepimai.Location = new System.Drawing.Point(72, 89);
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
            this.label1.Location = new System.Drawing.Point(330, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // MenuVadovas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 218);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_atsijungti);
            this.Controls.Add(this.btn_darbuotojai);
            this.Controls.Add(this.btn_uzsakymai);
            this.Controls.Add(this.btn_atsiliepimai);
            this.Name = "MenuVadovas";
            this.Text = "MenuVadovas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_atsijungti;
        private System.Windows.Forms.Button btn_darbuotojai;
        private System.Windows.Forms.Button btn_uzsakymai;
        private System.Windows.Forms.Button btn_atsiliepimai;
        private System.Windows.Forms.Label label1;
    }
}