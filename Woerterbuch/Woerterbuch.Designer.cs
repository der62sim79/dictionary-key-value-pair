namespace Woerterbuch
{
    partial class Woerterbuch
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbGermanWord = new System.Windows.Forms.TextBox();
            this.lbTranslation = new System.Windows.Forms.Label();
            this.tbEnglishWord = new System.Windows.Forms.TextBox();
            this.lBoxGermanWords = new System.Windows.Forms.ListBox();
            this.tbTranslation = new System.Windows.Forms.TextBox();
            this.btnExportToCsv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(237, 79);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 33);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Hinzufügen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbGermanWord
            // 
            this.tbGermanWord.Location = new System.Drawing.Point(43, 41);
            this.tbGermanWord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbGermanWord.Name = "tbGermanWord";
            this.tbGermanWord.Size = new System.Drawing.Size(192, 20);
            this.tbGermanWord.TabIndex = 1;
            // 
            // lbTranslation
            // 
            this.lbTranslation.AutoSize = true;
            this.lbTranslation.Location = new System.Drawing.Point(274, 45);
            this.lbTranslation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTranslation.Name = "lbTranslation";
            this.lbTranslation.Size = new System.Drawing.Size(49, 13);
            this.lbTranslation.TabIndex = 3;
            this.lbTranslation.Text = "DE<>EN";
            // 
            // tbEnglishWord
            // 
            this.tbEnglishWord.Location = new System.Drawing.Point(362, 41);
            this.tbEnglishWord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEnglishWord.Name = "tbEnglishWord";
            this.tbEnglishWord.Size = new System.Drawing.Size(211, 20);
            this.tbEnglishWord.TabIndex = 4;
            // 
            // lBoxGermanWords
            // 
            this.lBoxGermanWords.FormattingEnabled = true;
            this.lBoxGermanWords.Location = new System.Drawing.Point(43, 133);
            this.lBoxGermanWords.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lBoxGermanWords.Name = "lBoxGermanWords";
            this.lBoxGermanWords.Size = new System.Drawing.Size(279, 186);
            this.lBoxGermanWords.TabIndex = 5;
            this.lBoxGermanWords.SelectedIndexChanged += new System.EventHandler(this.lBoxGermanWords_SelectedIndexChanged);
            // 
            // tbTranslation
            // 
            this.tbTranslation.Location = new System.Drawing.Point(362, 133);
            this.tbTranslation.Name = "tbTranslation";
            this.tbTranslation.Size = new System.Drawing.Size(211, 20);
            this.tbTranslation.TabIndex = 6;
            // 
            // btnExportToCsv
            // 
            this.btnExportToCsv.Location = new System.Drawing.Point(362, 312);
            this.btnExportToCsv.Name = "btnExportToCsv";
            this.btnExportToCsv.Size = new System.Drawing.Size(211, 29);
            this.btnExportToCsv.TabIndex = 7;
            this.btnExportToCsv.Text = "Export CSV";
            this.btnExportToCsv.UseVisualStyleBackColor = true;
            this.btnExportToCsv.Click += new System.EventHandler(this.btnExportToCsv_Click);
            // 
            // Woerterbuch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnExportToCsv);
            this.Controls.Add(this.tbTranslation);
            this.Controls.Add(this.lBoxGermanWords);
            this.Controls.Add(this.tbEnglishWord);
            this.Controls.Add(this.lbTranslation);
            this.Controls.Add(this.tbGermanWord);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Woerterbuch";
            this.Text = "Wörterbuch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbGermanWord;
        private System.Windows.Forms.Label lbTranslation;
        private System.Windows.Forms.TextBox tbEnglishWord;
        private System.Windows.Forms.ListBox lBoxGermanWords;
        private System.Windows.Forms.TextBox tbTranslation;
        private System.Windows.Forms.Button btnExportToCsv;
    }
}

