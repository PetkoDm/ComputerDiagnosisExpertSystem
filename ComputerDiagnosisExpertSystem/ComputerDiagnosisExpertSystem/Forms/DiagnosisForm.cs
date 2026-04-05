using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ComputerDiagnosisExpertSystem.Logic;

namespace ComputerDiagnosisExpertSystem.Forms
{
    public partial class DiagnosisForm : Form
    {
        private string username;

        public DiagnosisForm(string user)
        {
            InitializeComponent();
            username = user;
        }

        private void DiagnosisForm_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add("G001 - Няма картина на монитора");
            checkedListBox1.Items.Add("G002 - Компютърът не реагира при включване");
            checkedListBox1.Items.Add("G003 - LED индикаторът не свети");
            checkedListBox1.Items.Add("G004 - Вентилаторът на захранването не се върти");
            checkedListBox1.Items.Add("G005 - LED индикаторите светват");
            checkedListBox1.Items.Add("G007 - Вентилаторът на захранването работи");
            checkedListBox1.Items.Add("G008 - Вентилаторът на процесора работи");
            checkedListBox1.Items.Add("G009 - Липсва звуков сигнал (beep)");
            checkedListBox1.Items.Add("G010 - Няма BIOS екран");
            checkedListBox1.Items.Add("G011 - Има BIOS сигнал (аларма)");
            checkedListBox1.Items.Add("G012 - Компютърът се изключва внезапно");
            checkedListBox1.Items.Add("G014 - Появява се „син екран“");
            checkedListBox1.Items.Add("G016 - Странен шум от твърдия диск");
            checkedListBox1.Items.Add("G017 - Забиване при работа с приложения");
            checkedListBox1.Items.Add("G019 - Стартира се scandisk при всяко включване");
            checkedListBox1.Items.Add("G020 - Повредени файлове");
            checkedListBox1.Items.Add("G022 - Устройство не се разпознава в BIOS");
            checkedListBox1.Items.Add("G023 - Линии на монитора");
            checkedListBox1.Items.Add("G025 - Проблем при запис на CD/DVD");
            checkedListBox1.Items.Add("G029 - Драйверът не се разпознава");
            checkedListBox1.Items.Add("G030 - Няма звук");
            checkedListBox1.Items.Add("G034 - Мишката не реагира");
        }

        private void btnDiagnose_Click(object sender, EventArgs e)
        {
            List<string> selected = new List<string>();

            foreach (var item in checkedListBox1.CheckedItems)
            {
                string code = item.ToString().Split('-')[0].Trim();
                selected.Add(code);
            }

            var result = InferenceEngine.Diagnose(selected);


            ResultForm form = new ResultForm(username, result);
            form.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
       "Сигурни ли сте, че искате да излезете?",
       "Потвърждение",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}