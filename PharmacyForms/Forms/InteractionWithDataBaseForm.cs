using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyForms.Forms
{
    public partial class InteractionWithDataBaseForm : Form
    {
        public InteractionWithDataBaseForm()
        {
            InitializeComponent();
        }
        SqlConnection conWithBase = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=PharmacyProject;Trusted_Connection=True;");
        SqlConnection conWithMaster = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;");
         
        private void InteractionWithDataBaseForm_Load(object sender, EventArgs e)
        {
            btnBackUp.Enabled = false;
        }
        private void btnBackUp_Click(object sender, EventArgs e)
        {
            try
            {
                TryBackUp();
                MessageBox.Show("Done");
            }
            catch(NullPathException nullPathException)
            {
                MessageBox.Show(nullPathException.Message);
            }
            catch(FailedConnectionException failedConnectionException)
            {
                MessageBox.Show(failedConnectionException.Message);
            }
        }
        private void TryBackUp()
        {
            if (tbPathForBackUp.Text == String.Empty)
                throw new NullPathException("Не указан путь.");
            try
            {
                conWithBase.Open();
                string database = conWithBase.Database.ToString();
                string date = DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss");
                //string cmd = $"BACKUP DATABASE [\"{database}\"] TO DISK = '{tbPathForBackUp.Text}\\{database}-{date}.bak'";
                //string cmd = "BACKUP DATABASE [" + database + "] TO DISK = '" + "tbPathForBackUp.Text" + "\\" + database + date + ".bak'";
                string cmd = "BACKUP DATABASE [" + database + "] TO DISK = '" + tbPathForBackUp.Text + "\\Pharma22y.bak'";
                SqlCommand command = new SqlCommand(cmd, conWithBase);
                command.ExecuteNonQuery();
                conWithBase.Close();
            }
            catch
            {
                throw new FailedConnectionException("Проблема с БД");
            }
        }
        private void btnBrowseForBackUp_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                tbPathForBackUp.Text = dlg.SelectedPath;
                btnBackUp.Enabled = true;
            }
        }
        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                string database = conWithMaster.Database.ToString();
                string sqlquery = "CREATE DATABASE PharmacyProject";
                SqlCommand cmd = new SqlCommand(sqlquery, conWithMaster);
                cmd.ExecuteNonQuery();

                string sqlquery2 = "RESTORE DATABASE PharmacyProject FROM DISK = 'E:\\Data\\Test.bak' WITH REPLACE";
                SqlCommand cmd2 = new SqlCommand(sqlquery2, conWithMaster);
                cmd2.ExecuteNonQuery();

                conWithMaster.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }


    }


    class NullPathException : Exception
    {
        public NullPathException(string message) : base(message)
        { }
    }
    class FailedConnectionException : Exception
    {
        public FailedConnectionException(string message) : base(message)
        { }
    }
}
