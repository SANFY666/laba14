namespace laba14
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label10 = new System.Windows.Forms.Label();
            this.chkReadOnly = new System.Windows.Forms.CheckBox();
            this.btnUnzip = new System.Windows.Forms.Button();
            this.btnZip = new System.Windows.Forms.Button();
            this.btnSaveText = new System.Windows.Forms.Button();
            this.btnCopyMove = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.btnCreateDir = new System.Windows.Forms.Button();
            this.txtObjectName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(118, 27);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(249, 25);
            this.label10.TabIndex = 43;
            this.label10.Text = "Ім\'я для нової папки/файлу";
            // 
            // chkReadOnly
            // 
            this.chkReadOnly.AutoSize = true;
            this.chkReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.chkReadOnly.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chkReadOnly.FlatAppearance.BorderSize = 2;
            this.chkReadOnly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkReadOnly.Location = new System.Drawing.Point(63, 269);
            this.chkReadOnly.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkReadOnly.Name = "chkReadOnly";
            this.chkReadOnly.Padding = new System.Windows.Forms.Padding(5, 5, 25, 5);
            this.chkReadOnly.Size = new System.Drawing.Size(137, 29);
            this.chkReadOnly.TabIndex = 42;
            this.chkReadOnly.Text = "Тільки читання";
            this.chkReadOnly.UseVisualStyleBackColor = false;
            this.chkReadOnly.CheckedChanged += new System.EventHandler(this.chkReadOnly_CheckedChanged);
            // 
            // btnUnzip
            // 
            this.btnUnzip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnUnzip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnzip.Location = new System.Drawing.Point(245, 269);
            this.btnUnzip.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUnzip.Name = "btnUnzip";
            this.btnUnzip.Size = new System.Drawing.Size(195, 29);
            this.btnUnzip.TabIndex = 41;
            this.btnUnzip.Text = "Розпакувати ZIP";
            this.btnUnzip.UseVisualStyleBackColor = false;
            this.btnUnzip.Click += new System.EventHandler(this.btnUnzip_Click);
            // 
            // btnZip
            // 
            this.btnZip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnZip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZip.Location = new System.Drawing.Point(245, 233);
            this.btnZip.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnZip.Name = "btnZip";
            this.btnZip.Size = new System.Drawing.Size(195, 29);
            this.btnZip.TabIndex = 40;
            this.btnZip.Text = "В архів ZIP";
            this.btnZip.UseVisualStyleBackColor = false;
            this.btnZip.Click += new System.EventHandler(this.btnZip_Click);
            // 
            // btnSaveText
            // 
            this.btnSaveText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnSaveText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveText.Location = new System.Drawing.Point(245, 178);
            this.btnSaveText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSaveText.Name = "btnSaveText";
            this.btnSaveText.Size = new System.Drawing.Size(195, 29);
            this.btnSaveText.TabIndex = 39;
            this.btnSaveText.Text = "Зберегти текст";
            this.btnSaveText.UseVisualStyleBackColor = false;
            this.btnSaveText.Click += new System.EventHandler(this.btnSaveText_Click);
            // 
            // btnCopyMove
            // 
            this.btnCopyMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnCopyMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyMove.Location = new System.Drawing.Point(245, 142);
            this.btnCopyMove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCopyMove.Name = "btnCopyMove";
            this.btnCopyMove.Size = new System.Drawing.Size(195, 30);
            this.btnCopyMove.TabIndex = 38;
            this.btnCopyMove.Text = "Копіювати/Перемістити";
            this.btnCopyMove.UseVisualStyleBackColor = false;
            this.btnCopyMove.Click += new System.EventHandler(this.btnCopyMove_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(64, 233);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 29);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "Видалити";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnCreateFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateFile.Location = new System.Drawing.Point(64, 178);
            this.btnCreateFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(136, 29);
            this.btnCreateFile.TabIndex = 36;
            this.btnCreateFile.Text = "Створити файл";
            this.btnCreateFile.UseVisualStyleBackColor = false;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // btnCreateDir
            // 
            this.btnCreateDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnCreateDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateDir.Location = new System.Drawing.Point(64, 143);
            this.btnCreateDir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCreateDir.Name = "btnCreateDir";
            this.btnCreateDir.Size = new System.Drawing.Size(136, 29);
            this.btnCreateDir.TabIndex = 35;
            this.btnCreateDir.Text = "Створити папку";
            this.btnCreateDir.UseVisualStyleBackColor = false;
            this.btnCreateDir.Click += new System.EventHandler(this.btnCreateDir_Click);
            // 
            // txtObjectName
            // 
            this.txtObjectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtObjectName.ForeColor = System.Drawing.Color.White;
            this.txtObjectName.Location = new System.Drawing.Point(64, 67);
            this.txtObjectName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtObjectName.Name = "txtObjectName";
            this.txtObjectName.Size = new System.Drawing.Size(375, 23);
            this.txtObjectName.TabIndex = 34;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(496, 338);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.chkReadOnly);
            this.Controls.Add(this.btnUnzip);
            this.Controls.Add(this.btnZip);
            this.Controls.Add(this.btnSaveText);
            this.Controls.Add(this.btnCopyMove);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.btnCreateDir);
            this.Controls.Add(this.txtObjectName);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form4";
            this.Text = "Операції з файлами та каталогами";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkReadOnly;
        private System.Windows.Forms.Button btnUnzip;
        private System.Windows.Forms.Button btnZip;
        private System.Windows.Forms.Button btnSaveText;
        private System.Windows.Forms.Button btnCopyMove;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Button btnCreateDir;
        private System.Windows.Forms.TextBox txtObjectName;
    }
}