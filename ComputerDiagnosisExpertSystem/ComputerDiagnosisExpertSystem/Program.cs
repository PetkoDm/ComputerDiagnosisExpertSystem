using System;
using System.Windows.Forms;
using ComputerDiagnosisExpertSystem.Forms;

namespace ComputerDiagnosisExpertSystem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}