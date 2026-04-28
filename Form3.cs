using laba14;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba14
{
    public partial class Form3 : Form
    {
        public Form3(string imagePath)
        {
            InitializeComponent();
            UpdateImage(imagePath); // завантаження першого фото
        }

        // метод для оновлення картинки
        public void UpdateImage(string imagePath)
        {
            try
            {
                // звільнення пам'яті від попереднього фото, щоб файл не блокувався
                if (picPreview.Image != null)
                {
                    picPreview.Image.Dispose();
                }

                // завантаження нового фото
                picPreview.Image = Image.FromFile(imagePath);
                this.Text = "Перегляд: " + Path.GetFileName(imagePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалося завантажити зображення: " + ex.Message);
            }
        }
    }
}
