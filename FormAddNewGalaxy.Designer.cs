namespace UniverseProject
{
    partial class FormAddNewGalaxy
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
            this.textBox_newGalaxyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_galaxyType = new System.Windows.Forms.ComboBox();
            this.button_addNewGalaxy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_numberOfStars = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa:";
            // 
            // textBox_newGalaxyName
            // 
            this.textBox_newGalaxyName.Location = new System.Drawing.Point(73, 24);
            this.textBox_newGalaxyName.Name = "textBox_newGalaxyName";
            this.textBox_newGalaxyName.Size = new System.Drawing.Size(150, 22);
            this.textBox_newGalaxyName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wybierz typ galaktyki:";
            // 
            // comboBox_galaxyType
            // 
            this.comboBox_galaxyType.FormattingEnabled = true;
            this.comboBox_galaxyType.Location = new System.Drawing.Point(185, 67);
            this.comboBox_galaxyType.Name = "comboBox_galaxyType";
            this.comboBox_galaxyType.Size = new System.Drawing.Size(121, 24);
            this.comboBox_galaxyType.TabIndex = 4;
            // 
            // button_addNewGalaxy
            // 
            this.button_addNewGalaxy.Location = new System.Drawing.Point(384, 32);
            this.button_addNewGalaxy.Name = "button_addNewGalaxy";
            this.button_addNewGalaxy.Size = new System.Drawing.Size(125, 59);
            this.button_addNewGalaxy.TabIndex = 5;
            this.button_addNewGalaxy.Text = "Dodaj";
            this.button_addNewGalaxy.UseVisualStyleBackColor = true;
            this.button_addNewGalaxy.Click += new System.EventHandler(this.button_addNewGalaxy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Liczba gwiazd:";
            // 
            // textBox_numberOfStars
            // 
            this.textBox_numberOfStars.Location = new System.Drawing.Point(123, 115);
            this.textBox_numberOfStars.Name = "textBox_numberOfStars";
            this.textBox_numberOfStars.Size = new System.Drawing.Size(100, 22);
            this.textBox_numberOfStars.TabIndex = 7;
            // 
            // FormAddNewGalaxy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 218);
            this.Controls.Add(this.textBox_numberOfStars);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_addNewGalaxy);
            this.Controls.Add(this.comboBox_galaxyType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_newGalaxyName);
            this.Controls.Add(this.label1);
            this.Name = "FormAddNewGalaxy";
            this.Text = "FormAddNewGalaxy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_newGalaxyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_galaxyType;
        private System.Windows.Forms.Button button_addNewGalaxy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_numberOfStars;
    }
}