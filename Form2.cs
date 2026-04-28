using laba14;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba14
{
    public partial class Form2 : Form
    {
        // змінна для звязку з головною формою
        private Form1 mainForm;

        // бере з Form1
        public Form2(Form1 form)
        {
            InitializeComponent();
            mainForm = form; // посилання на головну форму

            cmbFileFilter.Items.Add("*.* (Всі файли)");
            cmbFileFilter.Items.Add("*.txt;*.log (Текстові документи)");
            cmbFileFilter.Items.Add("*.png;*.jpg;*.jpeg;*.bmp (Зображення)");
            cmbFileFilter.Items.Add("*.exe;*.dll (Програми)");

            // значення з Form1
            txtDirFilter.Text = mainForm.currentDirFilter;

            if (cmbFileFilter.Items.Contains(mainForm.currentFileFilter))
                cmbFileFilter.SelectedItem = mainForm.currentFileFilter;
            else
                cmbFileFilter.SelectedIndex = 0;
        }

        // застосувати фільтри
        private void btnApplyFilters_Click(object sender, EventArgs e)
        {
            string dFilter = txtDirFilter.Text;
            string fFilter = cmbFileFilter.SelectedItem.ToString();

            // команда головній формі
            mainForm.ApplyFiltersFromForm2(dFilter, fFilter);
        }

        // скинути фільтри
        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            txtDirFilter.Text = "*";
            cmbFileFilter.SelectedIndex = 0;

            // Відправляємо стандартні значення головній формі
            mainForm.ApplyFiltersFromForm2("*", "*.* (Всі файли)");
        }
    }
}
