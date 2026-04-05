using ComputerDiagnosisExpertSystem.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace ComputerDiagnosisExpertSystem.Forms
{
    public partial class ResultForm : Form
    {
        public ResultForm(string user, Damage damage)
        {
            InitializeComponent();

            lblUser.Text = user;
            lblDate.Text = DateTime.Now.ToString();

            txtDamage.Text = damage.Name;
            txtSolution.Text = damage.Solution;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form != this)
                    form.Hide();
            }

            MainForm main = new MainForm();
            main.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File (*.txt)|*.txt";
            saveFileDialog.Title = "Запази диагностиката";
            saveFileDialog.FileName = "diagnosis.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string content = "=== ДИАГНОСТИКА НА КОМПЮТЪР ===\n\n";

                content += "Потребител: " + lblUser.Text + "\n";
                content += "Дата: " + lblDate.Text + "\n\n";

                content += "Диагностика:\n";
                content += txtDamage.Text + "\n\n";

                content += "Препоръка:\n";
                content += txtSolution.Text + "\n\n";

                content += "---------------------------------\n";
                content += "Генерирано от експертна система";

                File.WriteAllText(saveFileDialog.FileName, content);

                MessageBox.Show("Файлът е записан успешно!");
            }
        }
    }
}