namespace EvidenciaZamestnancov
{
    partial class NoviRukovodilac
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
            this.rukovodilacComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.unesiIzmenuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rukovodilacComboBox
            // 
            this.rukovodilacComboBox.FormattingEnabled = true;
            this.rukovodilacComboBox.Location = new System.Drawing.Point(54, 29);
            this.rukovodilacComboBox.Name = "rukovodilacComboBox";
            this.rukovodilacComboBox.Size = new System.Drawing.Size(213, 21);
            this.rukovodilacComboBox.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(54, 69);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(213, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // unesiIzmenuBtn
            // 
            this.unesiIzmenuBtn.Location = new System.Drawing.Point(167, 116);
            this.unesiIzmenuBtn.Name = "unesiIzmenuBtn";
            this.unesiIzmenuBtn.Size = new System.Drawing.Size(100, 39);
            this.unesiIzmenuBtn.TabIndex = 2;
            this.unesiIzmenuBtn.Text = "Unesi Izmenu";
            this.unesiIzmenuBtn.UseVisualStyleBackColor = true;
            this.unesiIzmenuBtn.Click += new System.EventHandler(this.unesiIzmenuBtn_Click);
            // 
            // NoviRukovodilac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 167);
            this.Controls.Add(this.unesiIzmenuBtn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.rukovodilacComboBox);
            this.Name = "NoviRukovodilac";
            this.Text = "Novi Rukovodilac";
            this.Load += new System.EventHandler(this.NoviRukovodilac_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox rukovodilacComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button unesiIzmenuBtn;
    }
}