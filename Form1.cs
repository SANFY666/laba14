using laba14;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression; 
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace laba14
{
    public partial class Form1 : Form
    {
        private string currentPath = "";

        // змінні для додаткових вікон
        private Form3 previewForm = null;
        private Form4 operationsForm = null;

        // фільтри
        public string currentDirFilter = "*";
        public string currentFileFilter = "*.* (Всі файли)";

        // фотки
        private string selectedImagePath = "";

        // властивості та методи для Form4
        public string CurrentPath => currentPath;

        // метод для отримання шляху до вибраного елемента
        public string SelectedItemPath
        {
            get
            {
                if (lstFiles.SelectedItem != null)
                    return Path.Combine(currentPath, lstFiles.SelectedItem.ToString());
                if (lstDirectories.SelectedItem != null)
                    return Path.Combine(currentPath, lstDirectories.SelectedItem.ToString());
                return null;
            }
        }

        // метод для отримання вмісту текстового файлу
        public string GetTextPreviewContent()
        {
            return rtbTextPreview.Text;
        }

        // метод для оновлення списків каталогів та файлів
        public void RefreshLists()
        {
            LoadDirectory(currentPath);
        }

        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
            LoadDrives();
        }

        // метод для ініціалізації додаткових компонентів та обробників подій
        private void InitializeCustomComponents()
        {
            cmbDrives.SelectedIndexChanged += CmbDrives_SelectedIndexChanged;
            lstDirectories.DoubleClick += LstDirectories_DoubleClick;
            lstDirectories.SelectedIndexChanged += LstDirectories_SelectedIndexChanged;
            lstFiles.SelectedIndexChanged += LstFiles_SelectedIndexChanged;
            btnUp.Click += BtnUp_Click;
        }

        // Завантаження доступних дисків у ComboBox
        private void LoadDrives()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (drive.IsReady)
                {
                    cmbDrives.Items.Add(drive.Name);
                }
            }
            if (cmbDrives.Items.Count > 0)
                cmbDrives.SelectedIndex = 0;
        }

        // обробник події зміни вибору диска
        private void CmbDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            string driveName = cmbDrives.SelectedItem.ToString();
            DriveInfo drive = new DriveInfo(driveName);

            double totalSizeGB = drive.TotalSize / (1024.0 * 1024.0 * 1024.0);
            double freeSpaceGB = drive.TotalFreeSpace / (1024.0 * 1024.0 * 1024.0);
            double freePercent = (freeSpaceGB / totalSizeGB) * 100;
            string label = string.IsNullOrEmpty(drive.VolumeLabel) ? "Немає" : drive.VolumeLabel;

            rtbProperties.Text = $"--- Властивості диска ---\n";
            rtbProperties.Text += $"Назва: {drive.Name}\n";
            rtbProperties.Text += $"Тип: {drive.DriveType}\n";
            rtbProperties.Text += $"Файлова система: {drive.DriveFormat}\n";
            rtbProperties.Text += $"Об'єм диску: {totalSizeGB:F2} ГБ\n";
            rtbProperties.Text += $"Вільний простір: {freeSpaceGB:F2} ГБ ({freePercent:F0}%)\n";
            rtbProperties.Text += $"Мітка диску: {label}\n";

            LoadDirectory(driveName);
        }

        // метод для завантаження вмісту каталогу
        private void LoadDirectory(string path)
        {
            try
            {
                currentPath = path;
                txtPath.Text = currentPath;
                lstDirectories.Items.Clear();
                lstFiles.Items.Clear();

                DirectoryInfo dirInfo = new DirectoryInfo(path);

                string dirFilter = string.IsNullOrWhiteSpace(currentDirFilter) ? "*" : currentDirFilter;
                DirectoryInfo[] dirs = dirInfo.GetDirectories(dirFilter);
                foreach (DirectoryInfo dir in dirs)
                {
                    lstDirectories.Items.Add(dir.Name);
                }

                string rawFilters = currentFileFilter.Split(' ')[0];
                string[] filePatterns = rawFilters.Split(';');

                foreach (string pattern in filePatterns)
                {
                    FileInfo[] files = dirInfo.GetFiles(pattern);
                    foreach (FileInfo file in files)
                    {
                        if (!lstFiles.Items.Contains(file.Name))
                        {
                            lstFiles.Items.Add(file.Name);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка доступу: " + ex.Message);
            }
        }

        // метод для отримання шляху
        public void ApplyFiltersFromForm2(string newDirFilter, string newFileFilter)
        {
            currentDirFilter = newDirFilter;
            currentFileFilter = newFileFilter;
            LoadDirectory(currentPath);
        }

        // обробник події подвійного кліку по каталогу
        private void LstDirectories_DoubleClick(object sender, EventArgs e)
        {
            if (lstDirectories.SelectedItem != null)
            {
                string newPath = Path.Combine(currentPath, lstDirectories.SelectedItem.ToString());
                LoadDirectory(newPath);
            }
        }

        // обробник події кнопки вгору
        private void BtnUp_Click(object sender, EventArgs e)
        {
            DirectoryInfo currentDir = new DirectoryInfo(currentPath);
            if (currentDir.Parent != null)
            {
                LoadDirectory(currentDir.Parent.FullName);
            }
        }

        // обробник події зміни вибору каталогу
        private void LstDirectories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDirectories.SelectedItem == null) return;

            string path = Path.Combine(currentPath, lstDirectories.SelectedItem.ToString());
            DirectoryInfo dirInfo = new DirectoryInfo(path);

            rtbProperties.Text = $"--- Властивості каталогу ---\n";
            rtbProperties.Text += $"Назва: {dirInfo.Name}\n";
            rtbProperties.Text += $"Повний шлях: {dirInfo.FullName}\n";
            rtbProperties.Text += $"Час створення: {dirInfo.CreationTime}\n";
            rtbProperties.Text += $"Остання зміна: {dirInfo.LastWriteTime}\n";

            try
            {
                DirectorySecurity dirSecurity = dirInfo.GetAccessControl();
                rtbProperties.Text += $"Власник: {dirSecurity.GetOwner(typeof(System.Security.Principal.NTAccount))}\n";
            }
            catch { rtbProperties.Text += "Власник: Немає доступу\n"; }

            // Оновлюємо чекбокс на Form4 (якщо вона відкрита)
            if (operationsForm != null && !operationsForm.IsDisposed)
            {
                operationsForm.UpdateReadOnlyCheckbox(path);
            }
        }

        // обробник події зміни вибору файлу
        private void LstFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFiles.SelectedItem == null) return;

            string filePath = Path.Combine(currentPath, lstFiles.SelectedItem.ToString());
            FileInfo fileInfo = new FileInfo(filePath);

            rtbProperties.Text = $"--- Властивості файлу ---\n";
            rtbProperties.Text += $"Ім'я: {fileInfo.Name}\n";
            rtbProperties.Text += $"Розширення: {fileInfo.Extension}\n";
            rtbProperties.Text += $"Розмір: {fileInfo.Length} байт\n";
            rtbProperties.Text += $"Створено: {fileInfo.CreationTime}\n";

            try
            {
                FileSecurity security = fileInfo.GetAccessControl();
                rtbProperties.Text += $"Власник: {security.GetOwner(typeof(System.Security.Principal.NTAccount))}\n";
            }
            catch { rtbProperties.Text += "Власник: Немає доступу\n"; }

            rtbTextPreview.Text = "";
            selectedImagePath = "";

            string ext = fileInfo.Extension.ToLower();

            if (ext == ".png" || ext == ".jpg" || ext == ".jpeg" || ext == ".bmp" || ext == ".gif")
            {
                selectedImagePath = filePath;
            }
            else if (ext == ".txt" || ext == ".log" || ext == ".cs" || ext == ".xml")
            {
                try { rtbTextPreview.Text = File.ReadAllText(filePath); }
                catch { rtbTextPreview.Text = "Помилка читання файлу."; }
            }

            // оновлюю картинку на Form3 
            if (previewForm != null && !previewForm.IsDisposed && !string.IsNullOrEmpty(selectedImagePath))
            {
                previewForm.UpdateImage(selectedImagePath);
            }

            // оновлюю чекбокс на Form4 
            if (operationsForm != null && !operationsForm.IsDisposed)
            {
                operationsForm.UpdateReadOnlyCheckbox(filePath);
            }
        }

        // відкриття нових вікон 

        private void btnOpenFilters_Click(object sender, EventArgs e)
        {
            Form2 filterForm = new Form2(this);
            filterForm.Show(this);
        }

        // відкриття вікна попереднього перегляду зображення
        private void btnOpenPreview_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedImagePath))
            {
                MessageBox.Show("Будь ласка, виберіть зображення у списку файлів.");
                return;
            }

            if (previewForm == null || previewForm.IsDisposed)
            {
                previewForm = new Form3(selectedImagePath);
                previewForm.Show(this);
            }
            else
            {
                previewForm.UpdateImage(selectedImagePath);
                previewForm.BringToFront();
            }
        }

        // відкриття вікна операцій з файлами та каталогами
        private void btnOpenOperations_Click(object sender, EventArgs e)
        {
            if (operationsForm == null || operationsForm.IsDisposed)
            {
                operationsForm = new Form4(this);
                operationsForm.Show(this);
            }
            else
            {
                operationsForm.BringToFront();
            }
        }
    }
}