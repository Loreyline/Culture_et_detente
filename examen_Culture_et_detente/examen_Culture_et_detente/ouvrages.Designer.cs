namespace examen_Culture_et_detente
{
    partial class ouvrages
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTitle = new System.Windows.Forms.Label();
            this.comboBoxTitle = new System.Windows.Forms.ComboBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.comboBoxAuthor = new System.Windows.Forms.ComboBox();
            this.dataGridViewOuvrage = new System.Windows.Forms.DataGridView();
            this.buttonValidChoice = new System.Windows.Forms.Button();
            this.buttonTestEmail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOuvrage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(39, 23);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(89, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Titre de l\'ouvrage";
            // 
            // comboBoxTitle
            // 
            this.comboBoxTitle.AllowDrop = true;
            this.comboBoxTitle.AutoCompleteCustomSource.AddRange(new string[] {
            ""});
            this.comboBoxTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTitle.FormattingEnabled = true;
            this.comboBoxTitle.Items.AddRange(new object[] {
            ""});
            this.comboBoxTitle.Location = new System.Drawing.Point(42, 57);
            this.comboBoxTitle.Name = "comboBoxTitle";
            this.comboBoxTitle.Size = new System.Drawing.Size(237, 21);
            this.comboBoxTitle.Sorted = true;
            this.comboBoxTitle.TabIndex = 1;
            this.comboBoxTitle.SelectedIndexChanged += new System.EventHandler(this.comboBoxTitle_SelectedIndexChanged);
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(339, 23);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(38, 13);
            this.labelAuthor.TabIndex = 2;
            this.labelAuthor.Text = "Auteur";
            // 
            // comboBoxAuthor
            // 
            this.comboBoxAuthor.FormattingEnabled = true;
            this.comboBoxAuthor.Location = new System.Drawing.Point(342, 56);
            this.comboBoxAuthor.Name = "comboBoxAuthor";
            this.comboBoxAuthor.Size = new System.Drawing.Size(313, 21);
            this.comboBoxAuthor.TabIndex = 3;
            this.comboBoxAuthor.SelectedIndexChanged += new System.EventHandler(this.comboBoxAuthor_SelectedIndexChanged);
            // 
            // dataGridViewOuvrage
            // 
            this.dataGridViewOuvrage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOuvrage.Location = new System.Drawing.Point(42, 118);
            this.dataGridViewOuvrage.Name = "dataGridViewOuvrage";
            this.dataGridViewOuvrage.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOuvrage.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewOuvrage.Size = new System.Drawing.Size(1074, 328);
            this.dataGridViewOuvrage.TabIndex = 4;
            // 
            // buttonValidChoice
            // 
            this.buttonValidChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonValidChoice.Location = new System.Drawing.Point(690, 54);
            this.buttonValidChoice.Name = "buttonValidChoice";
            this.buttonValidChoice.Size = new System.Drawing.Size(92, 23);
            this.buttonValidChoice.TabIndex = 5;
            this.buttonValidChoice.Text = "valider le choix";
            this.buttonValidChoice.UseVisualStyleBackColor = false;
            this.buttonValidChoice.Click += new System.EventHandler(this.buttonValidChoice_Click);
            // 
            // buttonTestEmail
            // 
            this.buttonTestEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonTestEmail.Location = new System.Drawing.Point(837, 54);
            this.buttonTestEmail.Name = "buttonTestEmail";
            this.buttonTestEmail.Size = new System.Drawing.Size(75, 23);
            this.buttonTestEmail.TabIndex = 6;
            this.buttonTestEmail.Text = "test d\'email";
            this.buttonTestEmail.UseVisualStyleBackColor = false;
            this.buttonTestEmail.Click += new System.EventHandler(this.buttonTestEmail_Click);
            // 
            // ouvrages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1164, 509);
            this.Controls.Add(this.buttonTestEmail);
            this.Controls.Add(this.buttonValidChoice);
            this.Controls.Add(this.dataGridViewOuvrage);
            this.Controls.Add(this.comboBoxAuthor);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.comboBoxTitle);
            this.Controls.Add(this.labelTitle);
            this.Name = "ouvrages";
            this.Text = "ouvrages";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOuvrage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox comboBoxTitle;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.ComboBox comboBoxAuthor;
        private System.Windows.Forms.DataGridView dataGridViewOuvrage;
        private System.Windows.Forms.Button buttonValidChoice;
        private System.Windows.Forms.Button buttonTestEmail;
    }
}