namespace UniverseProject
{
    partial class FormAddNewStar
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nameOfStar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_yearsOfStar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_galaxyOfStar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa gwiazdy";
            // 
            // textBox_nameOfStar
            // 
            this.textBox_nameOfStar.Location = new System.Drawing.Point(148, 34);
            this.textBox_nameOfStar.Name = "textBox_nameOfStar";
            this.textBox_nameOfStar.Size = new System.Drawing.Size(237, 22);
            this.textBox_nameOfStar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wiek (lata):";
            // 
            // textBox_yearsOfStar
            // 
            this.textBox_yearsOfStar.Location = new System.Drawing.Point(148, 69);
            this.textBox_yearsOfStar.Name = "textBox_yearsOfStar";
            this.textBox_yearsOfStar.Size = new System.Drawing.Size(100, 22);
            this.textBox_yearsOfStar.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(534, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 64);
            this.button1.TabIndex = 4;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_galaxyOfStar
            // 
            this.comboBox_galaxyOfStar.FormattingEnabled = true;
            this.comboBox_galaxyOfStar.Location = new System.Drawing.Point(148, 116);
            this.comboBox_galaxyOfStar.Name = "comboBox_galaxyOfStar";
            this.comboBox_galaxyOfStar.Size = new System.Drawing.Size(237, 24);
            this.comboBox_galaxyOfStar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Galaktyka:";
            // 
            // FormAddNewStar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 209);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_galaxyOfStar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_yearsOfStar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_nameOfStar);
            this.Controls.Add(this.label1);
            this.Name = "FormAddNewStar";
            this.Text = "FormAddNewStar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nameOfStar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_yearsOfStar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_galaxyOfStar;
        private System.Windows.Forms.Label label3;
    }
}