using System;
using System.Windows.Forms;

using Microsoft.WindowsAPICodePack.Dialogs;

namespace HateksPasswordGenerator
{
    public partial class Form1 : Form
    {

        string[] passList;
        string path = "";
        string newpath = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExcell_Click(object sender, EventArgs e)
        {
            OpenFileDialog();
        }
        private void OpenFileDialog()
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Excel Dosyası |*.xlsx";
            if (file.ShowDialog() == DialogResult.OK)
            {
                string path = file.FileName;
                string name = file.SafeFileName;
                OpenFile(path);
            }
        }

        private void OpenFile(string path)
        {
            Excel excel = new Excel(path, 1);
            passList = new string[excel.GetColumsNumber()];
            this.path = path;

        }
        private void OpenFileAndWritePassWord(string path, string[] passList)
        {
            Excel excel = new Excel(path, 1);

            for (int i = 0; i < passList.Length; i++)
            {
                excel.WriteToCell(i, (int)npRow.Value - 1, passList[i]);
            }

            if (String.IsNullOrEmpty(txtFileName.Text))
                excel.SaveAs(newpath + "/GeneratedPassword.xlsx");
            else excel.SaveAs(newpath + "/" + txtFileName.Text + ".xlsx");
            excel.Close();
            MessageBox.Show("Başarıyla Kaydedildi!");
        }

        private void btnGenratePassword_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(newpath))
            {
                MessageBox.Show("2. Adımdan Kayıt Yerini Seçiniz");
            }
            else
            {
                for (int i = 0; i < passList.Length; i++)
                {

                    String password = "";
                    if (cbRandom.Checked)
                    {
                        password += PasswordGenerator.Generate((int)npRandom.Value);
                    }
                    else
                    {
                        if (cbUpper.Checked)
                        {
                            password += PasswordGenerator.GenerateUpper((int)npupper.Value);
                        }
                        if (cbSpecial.Checked)
                        {
                            password += PasswordGenerator.GenerateSpecial((int)npspecial.Value);
                        }
                        if (cbLower.Checked)
                        {
                            password += PasswordGenerator.GenerateLower((int)nplower.Value);
                        }

                        if (cbNumeric.Checked)
                        {
                            password += PasswordGenerator.GenerateNumeric((int)npnumeric.Value);
                        }
                    }

                    passList[i] = password;
                }
                OpenFileAndWritePassWord(path, passList);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbCheckState(true);
            npMinValue(1);

        }

        private void npMinValue(int i)
        {

            nplower.Minimum = i;
            npnumeric.Minimum = i;
            npRandom.Minimum = i;
            npspecial.Minimum = i;
            npupper.Minimum = i;

        }
        private void cbCheckState(bool b)
        {
            cbUpper.Checked = b;
            cbNumeric.Checked = b;
            cbSpecial.Checked = b;
            cbLower.Checked = b;
        }

        private void btnSaveHere_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(path))
            {
                MessageBox.Show("1. Adımdan Excel Dosyasını Seçiniz");
            }
            else
            {
                CommonOpenFileDialog dialog = new CommonOpenFileDialog();
                dialog.IsFolderPicker = true;
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    newpath = dialog.FileName;
                    label1.Text = dialog.FileName;
                }
            }

        }

        private void cbRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRandom.Checked)
            {
                cbCheckState(false);
            }
            else
            {
                cbCheckState(true);
            }
        }
    }
}
