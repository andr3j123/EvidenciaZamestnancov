namespace EvidenciaZamestnancov
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sektorComboBox = new System.Windows.Forms.ComboBox();
            this.radnikListView = new System.Windows.Forms.ListView();
            this.sifraHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prezimeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.odHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.doHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.podaciOSektoruTextBox = new System.Windows.Forms.TextBox();
            this.zatvoriBtn = new System.Windows.Forms.Button();
            this.analizaBtn = new System.Windows.Forms.Button();
            this.promenaRukovodiocaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sektor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Podaci o sektoru";
            // 
            // sektorComboBox
            // 
            this.sektorComboBox.FormattingEnabled = true;
            this.sektorComboBox.Location = new System.Drawing.Point(105, 111);
            this.sektorComboBox.Name = "sektorComboBox";
            this.sektorComboBox.Size = new System.Drawing.Size(216, 21);
            this.sektorComboBox.TabIndex = 4;
            this.sektorComboBox.SelectedIndexChanged += new System.EventHandler(this.sektorComboBox_SelectedIndexChanged);
            // 
            // radnikListView
            // 
            this.radnikListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sifraHeader,
            this.imeHeader,
            this.prezimeHeader,
            this.odHeader,
            this.doHeader});
            this.radnikListView.FullRowSelect = true;
            this.radnikListView.HideSelection = false;
            this.radnikListView.Location = new System.Drawing.Point(372, 111);
            this.radnikListView.Name = "radnikListView";
            this.radnikListView.Size = new System.Drawing.Size(416, 231);
            this.radnikListView.TabIndex = 6;
            this.radnikListView.UseCompatibleStateImageBehavior = false;
            this.radnikListView.View = System.Windows.Forms.View.Details;
            // 
            // sifraHeader
            // 
            this.sifraHeader.Text = "Sifra";
            // 
            // imeHeader
            // 
            this.imeHeader.Text = "Ime";
            // 
            // prezimeHeader
            // 
            this.prezimeHeader.Text = "Prezime";
            // 
            // odHeader
            // 
            this.odHeader.Text = "Od";
            // 
            // doHeader
            // 
            this.doHeader.Text = "Do";
            // 
            // podaciOSektoruTextBox
            // 
            this.podaciOSektoruTextBox.Location = new System.Drawing.Point(105, 154);
            this.podaciOSektoruTextBox.Multiline = true;
            this.podaciOSektoruTextBox.Name = "podaciOSektoruTextBox";
            this.podaciOSektoruTextBox.ReadOnly = true;
            this.podaciOSektoruTextBox.Size = new System.Drawing.Size(216, 140);
            this.podaciOSektoruTextBox.TabIndex = 8;
            // 
            // zatvoriBtn
            // 
            this.zatvoriBtn.Image = global::EvidenciaZamestnancov.Properties.Resources.icons8_power_button_50;
            this.zatvoriBtn.Location = new System.Drawing.Point(93, 12);
            this.zatvoriBtn.Name = "zatvoriBtn";
            this.zatvoriBtn.Size = new System.Drawing.Size(75, 59);
            this.zatvoriBtn.TabIndex = 1;
            this.zatvoriBtn.UseVisualStyleBackColor = true;
            this.zatvoriBtn.Click += new System.EventHandler(this.zatvoriBtn_Click);
            // 
            // analizaBtn
            // 
            this.analizaBtn.Image = global::EvidenciaZamestnancov.Properties.Resources.icons8_graph_50;
            this.analizaBtn.Location = new System.Drawing.Point(12, 12);
            this.analizaBtn.Name = "analizaBtn";
            this.analizaBtn.Size = new System.Drawing.Size(75, 59);
            this.analizaBtn.TabIndex = 0;
            this.analizaBtn.UseVisualStyleBackColor = true;
            this.analizaBtn.Click += new System.EventHandler(this.analizaBtn_Click);
            // 
            // promenaRukovodiocaBtn
            // 
            this.promenaRukovodiocaBtn.Location = new System.Drawing.Point(105, 311);
            this.promenaRukovodiocaBtn.Name = "promenaRukovodiocaBtn";
            this.promenaRukovodiocaBtn.Size = new System.Drawing.Size(216, 31);
            this.promenaRukovodiocaBtn.TabIndex = 9;
            this.promenaRukovodiocaBtn.Text = "Promena rukovodioca";
            this.promenaRukovodiocaBtn.UseVisualStyleBackColor = true;
            this.promenaRukovodiocaBtn.Click += new System.EventHandler(this.promenaRukovodiocaBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 354);
            this.Controls.Add(this.promenaRukovodiocaBtn);
            this.Controls.Add(this.podaciOSektoruTextBox);
            this.Controls.Add(this.radnikListView);
            this.Controls.Add(this.sektorComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zatvoriBtn);
            this.Controls.Add(this.analizaBtn);
            this.Name = "Form1";
            this.Text = "Sektori";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button analizaBtn;
        private System.Windows.Forms.Button zatvoriBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sektorComboBox;
        private System.Windows.Forms.ListView radnikListView;
        private System.Windows.Forms.TextBox podaciOSektoruTextBox;
        private System.Windows.Forms.ColumnHeader sifraHeader;
        private System.Windows.Forms.ColumnHeader imeHeader;
        private System.Windows.Forms.ColumnHeader prezimeHeader;
        private System.Windows.Forms.ColumnHeader odHeader;
        private System.Windows.Forms.ColumnHeader doHeader;
        private System.Windows.Forms.Button promenaRukovodiocaBtn;
    }
}

