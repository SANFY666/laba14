namespace laba14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbDrives = new System.Windows.Forms.ComboBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.lstDirectories = new System.Windows.Forms.ListBox();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.rtbProperties = new System.Windows.Forms.RichTextBox();
            this.rtbTextPreview = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnOpenFilters = new System.Windows.Forms.Button();
            this.btnOpenPreview = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbDrives
            // 
            this.cmbDrives.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cmbDrives.ForeColor = System.Drawing.Color.White;
            this.cmbDrives.FormattingEnabled = true;
            this.cmbDrives.Location = new System.Drawing.Point(32, 109);
            this.cmbDrives.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDrives.Name = "cmbDrives";
            this.cmbDrives.Size = new System.Drawing.Size(241, 23);
            this.cmbDrives.TabIndex = 0;
            this.cmbDrives.SelectedIndexChanged += new System.EventHandler(this.CmbDrives_SelectedIndexChanged);
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtPath.ForeColor = System.Drawing.Color.White;
            this.txtPath.Location = new System.Drawing.Point(293, 109);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(272, 23);
            this.txtPath.TabIndex = 1;
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.ForeColor = System.Drawing.Color.White;
            this.btnUp.Location = new System.Drawing.Point(87, 140);
            this.btnUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(141, 25);
            this.btnUp.TabIndex = 2;
            this.btnUp.Text = "Вернутися назад";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.BtnUp_Click);
            // 
            // lstDirectories
            // 
            this.lstDirectories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lstDirectories.ForeColor = System.Drawing.Color.White;
            this.lstDirectories.FormattingEnabled = true;
            this.lstDirectories.ItemHeight = 15;
            this.lstDirectories.Location = new System.Drawing.Point(32, 224);
            this.lstDirectories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstDirectories.Name = "lstDirectories";
            this.lstDirectories.Size = new System.Drawing.Size(243, 184);
            this.lstDirectories.TabIndex = 6;
            this.lstDirectories.SelectedIndexChanged += new System.EventHandler(this.LstDirectories_SelectedIndexChanged);
            this.lstDirectories.DoubleClick += new System.EventHandler(this.LstDirectories_DoubleClick);
            // 
            // lstFiles
            // 
            this.lstFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lstFiles.ForeColor = System.Drawing.Color.White;
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.ItemHeight = 15;
            this.lstFiles.Location = new System.Drawing.Point(296, 224);
            this.lstFiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(272, 184);
            this.lstFiles.TabIndex = 7;
            this.lstFiles.SelectedIndexChanged += new System.EventHandler(this.LstFiles_SelectedIndexChanged);
            // 
            // rtbProperties
            // 
            this.rtbProperties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.rtbProperties.ForeColor = System.Drawing.Color.White;
            this.rtbProperties.Location = new System.Drawing.Point(32, 463);
            this.rtbProperties.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbProperties.Name = "rtbProperties";
            this.rtbProperties.Size = new System.Drawing.Size(243, 115);
            this.rtbProperties.TabIndex = 8;
            this.rtbProperties.Text = "";
            // 
            // rtbTextPreview
            // 
            this.rtbTextPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.rtbTextPreview.ForeColor = System.Drawing.Color.White;
            this.rtbTextPreview.Location = new System.Drawing.Point(296, 463);
            this.rtbTextPreview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbTextPreview.Name = "rtbTextPreview";
            this.rtbTextPreview.Size = new System.Drawing.Size(272, 115);
            this.rtbTextPreview.TabIndex = 9;
            this.rtbTextPreview.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(366, 431);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Текст файлу";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(54, 431);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Інформація про файл";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(355, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Поточний шлях";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(82, 79);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Поточний диск";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(75, 194);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Перегляд папок";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(323, 194);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Перегляд вмісту папок";
            // 
            // btnOpenFilters
            // 
            this.btnOpenFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnOpenFilters.Location = new System.Drawing.Point(32, 28);
            this.btnOpenFilters.Name = "btnOpenFilters";
            this.btnOpenFilters.Size = new System.Drawing.Size(110, 34);
            this.btnOpenFilters.TabIndex = 34;
            this.btnOpenFilters.Text = "Фільтри";
            this.btnOpenFilters.UseVisualStyleBackColor = false;
            this.btnOpenFilters.Click += new System.EventHandler(this.btnOpenFilters_Click);
            // 
            // btnOpenPreview
            // 
            this.btnOpenPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnOpenPreview.Location = new System.Drawing.Point(155, 28);
            this.btnOpenPreview.Name = "btnOpenPreview";
            this.btnOpenPreview.Size = new System.Drawing.Size(121, 34);
            this.btnOpenPreview.TabIndex = 35;
            this.btnOpenPreview.Text = "Картинка";
            this.btnOpenPreview.UseVisualStyleBackColor = false;
            this.btnOpenPreview.Click += new System.EventHandler(this.btnOpenPreview_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.button1.Location = new System.Drawing.Point(296, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 34);
            this.button1.TabIndex = 36;
            this.button1.Text = "Операції з файлами та каталогами";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnOpenOperations_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(596, 610);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOpenPreview);
            this.Controls.Add(this.btnOpenFilters);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbTextPreview);
            this.Controls.Add(this.rtbProperties);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.lstDirectories);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.cmbDrives);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Лабораторна робота №14 Зубко Олександр 201-ТК";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDrives;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.ListBox lstDirectories;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.RichTextBox rtbProperties;
        private System.Windows.Forms.RichTextBox rtbTextPreview;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnOpenFilters;
        private System.Windows.Forms.Button btnOpenPreview;
        private System.Windows.Forms.Button button1;
    }
}

