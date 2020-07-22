namespace UniverseProject
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button_showAddGalaxyForm = new System.Windows.Forms.Button();
            this.button_showAddStarForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_update = new System.Windows.Forms.Button();
            this.universeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.universeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.universeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universeBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.button_sortNumberOfStars = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universeBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // button_showAddGalaxyForm
            // 
            this.button_showAddGalaxyForm.Location = new System.Drawing.Point(52, 53);
            this.button_showAddGalaxyForm.Name = "button_showAddGalaxyForm";
            this.button_showAddGalaxyForm.Size = new System.Drawing.Size(128, 48);
            this.button_showAddGalaxyForm.TabIndex = 0;
            this.button_showAddGalaxyForm.Text = "Dodaj nowa galaktyke";
            this.button_showAddGalaxyForm.UseVisualStyleBackColor = true;
            this.button_showAddGalaxyForm.Click += new System.EventHandler(this.button_showAddGalaxyForm_Click);
            // 
            // button_showAddStarForm
            // 
            this.button_showAddStarForm.Location = new System.Drawing.Point(228, 53);
            this.button_showAddStarForm.Name = "button_showAddStarForm";
            this.button_showAddStarForm.Size = new System.Drawing.Size(150, 48);
            this.button_showAddStarForm.TabIndex = 1;
            this.button_showAddStarForm.Text = "Dodaj nową gwiazdę";
            this.button_showAddStarForm.UseVisualStyleBackColor = true;
            this.button_showAddStarForm.Click += new System.EventHandler(this.button_showAddStarForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Galaktyki";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(628, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(695, 159);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(116, 65);
            this.button_update.TabIndex = 5;
            this.button_update.Text = "Pokaz galaktyki";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // universeBindingSource2
            // 
            this.universeBindingSource2.DataSource = typeof(UniverseProject.Models.Universe);
            // 
            // universeBindingSource1
            // 
            this.universeBindingSource1.DataSource = typeof(UniverseProject.Models.Universe);
            // 
            // universeBindingSource
            // 
            this.universeBindingSource.DataSource = typeof(UniverseProject.Models.Universe);
            // 
            // universeBindingSource3
            // 
            this.universeBindingSource3.DataSource = typeof(UniverseProject.Models.Universe);
            // 
            // button_sortNumberOfStars
            // 
            this.button_sortNumberOfStars.Location = new System.Drawing.Point(695, 231);
            this.button_sortNumberOfStars.Name = "button_sortNumberOfStars";
            this.button_sortNumberOfStars.Size = new System.Drawing.Size(116, 78);
            this.button_sortNumberOfStars.TabIndex = 6;
            this.button_sortNumberOfStars.Text = "Sortuj wg liczby gwiazd";
            this.button_sortNumberOfStars.UseVisualStyleBackColor = true;
            this.button_sortNumberOfStars.Click += new System.EventHandler(this.button_sortNumberOfStars_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 543);
            this.Controls.Add(this.button_sortNumberOfStars);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_showAddStarForm);
            this.Controls.Add(this.button_showAddGalaxyForm);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universeBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_showAddGalaxyForm;
        private System.Windows.Forms.Button button_showAddStarForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource universeBindingSource;
        private System.Windows.Forms.BindingSource universeBindingSource1;
        private System.Windows.Forms.BindingSource universeBindingSource2;
        private System.Windows.Forms.BindingSource universeBindingSource3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_sortNumberOfStars;
    }
}

