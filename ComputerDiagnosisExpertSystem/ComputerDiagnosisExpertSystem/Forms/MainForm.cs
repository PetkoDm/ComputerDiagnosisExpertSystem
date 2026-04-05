using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ComputerDiagnosisExpertSystem.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text))
            {
                MessageBox.Show("Моля, въведете потребителско име.");
                return;
            }
            if (!Regex.IsMatch(txtUser.Text, @"^[a-zA-Zа-яА-Я\s]+$"))
            {
                MessageBox.Show("Името може да съдържа само букви и интервали!");
                return;
            }
            DiagnosisForm form = new DiagnosisForm(txtUser.Text);
            form.Show();
            this.Hide();
        }
    }
}