using laba14;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba14
{
    public partial class Form4 : Form
    {
        private Form1 mainForm;

        // змінні для буфера обміну
        private string clipboardPath = "";
        private bool isCutOperation = false;

        public Form4(Form1 form)
        {
            InitializeComponent();
            mainForm = form; // посилання на головну форму
        }

        // створення каталогу
        private void btnCreateDir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtObjectName.Text))
            {
                MessageBox.Show("напиши ім'я каталогу!");
                return;
            }

            // CurrentPath з головної форми
            string path = Path.Combine(mainForm.CurrentPath, txtObjectName.Text);
            DirectoryInfo dirInfo = new DirectoryInfo(path);

            if (!dirInfo.Exists)
            {
                dirInfo.Create();
                mainForm.RefreshLists(); // примусове оновлення списків на головній формі
                txtObjectName.Clear();
            }
            else MessageBox.Show("такий каталог вже існує!");
        }

        // створення файлу
        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtObjectName.Text))
            {
                MessageBox.Show("напиши ім'я файлу (напр. new.txt)!");
                return;
            }

            string path = Path.Combine(mainForm.CurrentPath, txtObjectName.Text);
            FileInfo fileInfo = new FileInfo(path);

            if (!fileInfo.Exists)
            {
                fileInfo.Create().Close();
                mainForm.RefreshLists();
                txtObjectName.Clear();
            }
            else MessageBox.Show("такий файл вже існує!");
        }

        // видалення
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // виділений елемент з головної форми
            string targetPath = mainForm.SelectedItemPath;
            if (targetPath == null) return;

            if (MessageBox.Show($"ти точно хочеш видалити {Path.GetFileName(targetPath)}?", "Підтвердження", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (File.Exists(targetPath))
                        new FileInfo(targetPath).Delete();
                    else if (Directory.Exists(targetPath))
                        new DirectoryInfo(targetPath).Delete(true);

                    mainForm.RefreshLists();
                }
                catch (Exception ex) { MessageBox.Show("Помилка видалення: " + ex.Message); }
            }
        }

        // копіювання / переміщення
        private void btnCopyMove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(clipboardPath))
            {
                string targetPath = mainForm.SelectedItemPath;
                if (targetPath == null) { MessageBox.Show("вибери об'єкт для копіювання/вирізання у головному вікні"); return; }

                clipboardPath = targetPath;
                DialogResult dr = MessageBox.Show("Вирізати об'єкт? (нажми 'Ні', якщо хочеш скопіювати)", "Дія", MessageBoxButtons.YesNoCancel);

                if (dr == DialogResult.Yes) isCutOperation = true;
                else if (dr == DialogResult.No) isCutOperation = false;
                else clipboardPath = "";

                if (!string.IsNullOrEmpty(clipboardPath))
                    btnCopyMove.Text = "вставити сюди";
            }
            else
            {
                string destPath = Path.Combine(mainForm.CurrentPath, Path.GetFileName(clipboardPath));
                try
                {
                    if (File.Exists(clipboardPath))
                    {
                        // файли
                        if (isCutOperation) File.Move(clipboardPath, destPath);
                        else File.Copy(clipboardPath, destPath, true);
                    }
                    else if (Directory.Exists(clipboardPath))
                    {
                        // папки
                        if (isCutOperation)
                        {
                            Directory.Move(clipboardPath, destPath);
                        }
                        else
                        {
                            // копіювання
                            CopyDirectory(clipboardPath, destPath);
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show("Помилка: " + ex.Message); }
                finally
                {
                    clipboardPath = "";
                    isCutOperation = false;
                    btnCopyMove.Text = "Копіювати / Перемістити";
                    mainForm.RefreshLists();
                }
            }
        }

        // збереження тексту
        private void btnSaveText_Click(object sender, EventArgs e)
        {
            string filePath = mainForm.SelectedItemPath;
            if (filePath == null || !File.Exists(filePath))
            {
                MessageBox.Show("вибери файл для збереження у головному вікні.");
                return;
            }

            try
            {
                // текст з rtbTextPreview на головній формі
                File.WriteAllText(filePath, mainForm.GetTextPreviewContent());
                MessageBox.Show("зміни успішно збережено!");
            }
            catch (Exception ex) { MessageBox.Show("помилка запису: " + ex.Message); }
        }

        // архівація ZIP
        private void btnZip_Click(object sender, EventArgs e)
        {
            string targetPath = mainForm.SelectedItemPath;
            if (targetPath == null || !Directory.Exists(targetPath)) { MessageBox.Show("вибери папку для архівації у головному вікні"); return; }

            string zipPath = targetPath + ".zip";
            try
            {
                ZipFile.CreateFromDirectory(targetPath, zipPath);
                MessageBox.Show("архів створено!");
                mainForm.RefreshLists();
            }
            catch (Exception ex) { MessageBox.Show("помилка архівації: " + ex.Message); }
        }

        // розархівація UNZIP
        private void btnUnzip_Click(object sender, EventArgs e)
        {
            string targetPath = mainForm.SelectedItemPath;
            if (targetPath == null || !targetPath.EndsWith(".zip"))
            {
                MessageBox.Show("вибери ZIP-архів для розпакування у головному вікні"); return;
            }

            string extractPath = targetPath.Replace(".zip", "");
            try
            {
                ZipFile.ExtractToDirectory(targetPath, extractPath);
                MessageBox.Show("архів розархівовано!");
                mainForm.RefreshLists();
            }
            catch (Exception ex) { MessageBox.Show("помилка розархівації: " + ex.Message); }
        }

        // метод для оновлення чекбоксу з Form1
        public void UpdateReadOnlyCheckbox(string filePath)
        {
            try
            {
                chkReadOnly.CheckedChanged -= chkReadOnly_CheckedChanged;
                chkReadOnly.Checked = (File.GetAttributes(filePath) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly;
                chkReadOnly.CheckedChanged += chkReadOnly_CheckedChanged;
            }
            catch { chkReadOnly.Checked = false; }
        }

        // readOnly
        private void chkReadOnly_CheckedChanged(object sender, EventArgs e)
        {
            string targetPath = mainForm.SelectedItemPath;
            if (targetPath == null) return;

            try
            {
                FileAttributes attributes = File.GetAttributes(targetPath);
                if (chkReadOnly.Checked)
                    File.SetAttributes(targetPath, attributes | FileAttributes.ReadOnly);
                else
                    File.SetAttributes(targetPath, attributes & ~FileAttributes.ReadOnly);
            }
            catch { }
        }

        // копіювання папок з усім вмістом
        private void CopyDirectory(string sourceDir, string destinationDir)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDir);

            if (!dir.Exists)
                throw new DirectoryNotFoundException($"Вихідна папка не знайдена: {dir.FullName}");

            DirectoryInfo[] dirs = dir.GetDirectories();
            Directory.CreateDirectory(destinationDir);

            foreach (FileInfo file in dir.GetFiles())
            {
                string targetFilePath = Path.Combine(destinationDir, file.Name);
                file.CopyTo(targetFilePath, true); // true означає перезапис
            }

            // копія для всіх вкладених папок
            foreach (DirectoryInfo subDir in dirs)
            {
                string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
                CopyDirectory(subDir.FullName, newDestinationDir);
            }
        }
    }
}