namespace examen_Culture_et_detente
{
    partial class FormeEmail
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.buttonValidEmail = new System.Windows.Forms.Button();
            this.buttonCloseEmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(12, 59);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(260, 20);
            this.textBoxEmail.TabIndex = 0;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(12, 24);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(31, 13);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "email";
            // 
            // buttonValidEmail
            // 
            this.buttonValidEmail.Location = new System.Drawing.Point(34, 128);
            this.buttonValidEmail.Name = "buttonValidEmail";
            this.buttonValidEmail.Size = new System.Drawing.Size(197, 51);
            this.buttonValidEmail.TabIndex = 2;
            this.buttonValidEmail.Text = "Valider";
            this.buttonValidEmail.UseVisualStyleBackColor = true;
            this.buttonValidEmail.Click += new System.EventHandler(this.buttonValidEmail_Click);
            // 
            // buttonCloseEmail
            // 
            this.buttonCloseEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCloseEmail.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseEmail.ForeColor = System.Drawing.Color.White;
            this.buttonCloseEmail.Location = new System.Drawing.Point(34, 210);
            this.buttonCloseEmail.Name = "buttonCloseEmail";
            this.buttonCloseEmail.Size = new System.Drawing.Size(197, 40);
            this.buttonCloseEmail.TabIndex = 3;
            this.buttonCloseEmail.Text = "fermer la fenêtre";
            this.buttonCloseEmail.UseVisualStyleBackColor = false;
            this.buttonCloseEmail.Click += new System.EventHandler(this.buttonCloseEmail_Click);
            // 
            // FormeEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonCloseEmail);
            this.Controls.Add(this.buttonValidEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Name = "FormeEmail";
            this.Text = "email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button buttonValidEmail;
        private System.Windows.Forms.Button buttonCloseEmail;
    }
}

