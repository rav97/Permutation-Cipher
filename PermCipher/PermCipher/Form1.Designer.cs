namespace PermCipher
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.start = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.RichTextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.RichTextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.opFile = new System.Windows.Forms.Button();
            this.FileExport = new System.Windows.Forms.Button();
            this.cipher = new System.Windows.Forms.CheckBox();
            this.fromFile = new System.Windows.Forms.CheckBox();
            this.manually = new System.Windows.Forms.CheckBox();
            this.decipher = new System.Windows.Forms.CheckBox();
            this.key = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(12, 243);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(518, 39);
            this.start.TabIndex = 0;
            this.start.Text = "START";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(12, 67);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(518, 80);
            this.input.TabIndex = 3;
            this.input.Text = "";
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(10, 51);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(60, 13);
            this.inputLabel.TabIndex = 4;
            this.inputLabel.Text = "Podaj tekst";
            this.inputLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(12, 301);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(518, 85);
            this.output.TabIndex = 5;
            this.output.Text = "";
            this.output.TextChanged += new System.EventHandler(this.output_TextChanged);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(12, 285);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(59, 13);
            this.outputLabel.TabIndex = 6;
            this.outputLabel.Text = "Szyfrogram";
            this.outputLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // opFile
            // 
            this.opFile.Location = new System.Drawing.Point(397, 8);
            this.opFile.Name = "opFile";
            this.opFile.Size = new System.Drawing.Size(75, 23);
            this.opFile.TabIndex = 7;
            this.opFile.Text = "Wybierz plik";
            this.opFile.UseVisualStyleBackColor = true;
            this.opFile.Click += new System.EventHandler(this.opFile_Click);
            // 
            // FileExport
            // 
            this.FileExport.Location = new System.Drawing.Point(13, 394);
            this.FileExport.Name = "FileExport";
            this.FileExport.Size = new System.Drawing.Size(75, 23);
            this.FileExport.TabIndex = 10;
            this.FileExport.Text = "Zapisz do pliku";
            this.FileExport.UseVisualStyleBackColor = true;
            this.FileExport.Click += new System.EventHandler(this.FileExport_Click);
            // 
            // cipher
            // 
            this.cipher.AutoSize = true;
            this.cipher.Location = new System.Drawing.Point(209, 207);
            this.cipher.Name = "cipher";
            this.cipher.Size = new System.Drawing.Size(57, 17);
            this.cipher.TabIndex = 11;
            this.cipher.Text = "Szyfruj";
            this.cipher.UseVisualStyleBackColor = true;
            this.cipher.CheckedChanged += new System.EventHandler(this.cipher_CheckedChanged);
            // 
            // fromFile
            // 
            this.fromFile.AutoSize = true;
            this.fromFile.Location = new System.Drawing.Point(12, 8);
            this.fromFile.Name = "fromFile";
            this.fromFile.Size = new System.Drawing.Size(133, 17);
            this.fromFile.TabIndex = 12;
            this.fromFile.Text = "Wybieram dane z pliku";
            this.fromFile.UseVisualStyleBackColor = true;
            this.fromFile.CheckedChanged += new System.EventHandler(this.fromFile_CheckedChanged);
            // 
            // manually
            // 
            this.manually.AutoSize = true;
            this.manually.Location = new System.Drawing.Point(12, 31);
            this.manually.Name = "manually";
            this.manually.Size = new System.Drawing.Size(173, 17);
            this.manually.TabIndex = 13;
            this.manually.Text = "Wprowadzę dane samodzielnie";
            this.manually.UseVisualStyleBackColor = true;
            this.manually.CheckedChanged += new System.EventHandler(this.manually_CheckedChanged);
            // 
            // decipher
            // 
            this.decipher.AutoSize = true;
            this.decipher.Location = new System.Drawing.Point(272, 207);
            this.decipher.Name = "decipher";
            this.decipher.Size = new System.Drawing.Size(69, 17);
            this.decipher.TabIndex = 2;
            this.decipher.Text = "Deszyfruj";
            this.decipher.UseVisualStyleBackColor = true;
            this.decipher.CheckedChanged += new System.EventHandler(this.decipher_CheckedChanged);
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(12, 172);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(518, 20);
            this.key.TabIndex = 14;
            this.key.TextChanged += new System.EventHandler(this.key_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Klucz";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 429);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.key);
            this.Controls.Add(this.manually);
            this.Controls.Add(this.fromFile);
            this.Controls.Add(this.cipher);
            this.Controls.Add(this.FileExport);
            this.Controls.Add(this.opFile);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.output);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.input);
            this.Controls.Add(this.decipher);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Szyfr";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.RichTextBox input;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button opFile;
        private System.Windows.Forms.Button FileExport;
        private System.Windows.Forms.CheckBox cipher;
        private System.Windows.Forms.CheckBox fromFile;
        private System.Windows.Forms.CheckBox manually;
        private System.Windows.Forms.CheckBox decipher;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.Label label1;
    }
}

