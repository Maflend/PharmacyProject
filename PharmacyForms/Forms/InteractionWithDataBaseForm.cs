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

        SqlConnection conWithBase;
        SqlConnection conWithMaster;
         
        private void InteractionWithDataBaseForm_Load(object sender, EventArgs e)
        {
            btnBackUp.Enabled = false;
            btnRestore.Enabled = false;
            if (CurrentUserStatic.EmergencyStart == true)
                btnBrowseForBackUp.Enabled = false;

           
        }
        private void btnBackUp_Click(object sender, EventArgs e)
        {
            try
            {
                TryBackUp();
                MessageBox.Show("Сохранение базы данных успешно.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void TryBackUp()
        {
            if (tbPathForBackUp.Text == String.Empty)
                throw new Exception("Не указан путь.");
            try
            {
                conWithBase.Open();
                string database = conWithBase.Database.ToString();
                string dateNow = DateTime.Now.ToString("yyyy.MM.dd-HHчmmм");
 
                string fileName = "'"+ tbPathForBackUp.Text + "\\" + database + "-" + dateNow + ")" + ".bak'";

                string cmd = "BACKUP DATABASE [" + database + "] TO DISK = "+ fileName;

                SqlCommand command = new SqlCommand(cmd, conWithBase);
                command.ExecuteNonQuery();
                conWithBase.Close();
            }
            catch
            {
                throw new Exception("Проблема с БД");
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
                TryRestore();
                if(CurrentUserStatic.EmergencyStart == true)
                    MessageBox.Show("Востановление базы данных успешно. Перезайдите в аккаунт.");
                else
                    MessageBox.Show("Востановление базы данных успешно.");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void TryRestore()
        {
            conWithMaster.Open();
            string database = conWithBase.Database.ToString();

            try
            {   
                string sqlquery = "IF db_id('[PharmacyProject]') IS NOT NULL CREATE DATABASE PharmacyProject";
                SqlCommand cmd = new SqlCommand(sqlquery, conWithMaster);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                conWithMaster.Close();
                throw new Exception("Проблема с проверкой существования бд");
            }
            try
            {
                SqlConnection conWithMaster1 = new SqlConnection(@"Server=localhost\SQLEXPRESS;Trusted_Connection=True;");
                string q1 = "alter database " + database + " set offline with rollback immediate";
                SqlCommand cmd3 = new SqlCommand(q1, conWithMaster);
                cmd3.ExecuteNonQuery();

                string sqlquery2 = " USE MASTER RESTORE DATABASE [" + database + "] FROM DISK = '" + tbPathForRestore.Text + "' WITH REPLACE";
                SqlCommand cmd2 = new SqlCommand(sqlquery2, conWithMaster);
                cmd2.ExecuteNonQuery();
            }
            catch
            {
                throw new Exception("Проблема с востановления бд");
            }
            finally
            {
                conWithMaster.Close();
            }
        }

        private void btnBrowseForRestore_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "(*.bak)|*.bak";
            dlg.Title = "Database restore";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                tbPathForRestore.Text = dlg.FileName;
                btnRestore.Enabled = true;
            }
        }

        private void tbNewConnectionString_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbNewConnectionString.Text))
            {
                btnBrowseForBackUp.Enabled = false;
                btnBrowseForRestore.Enabled = false;

            }
            conWithBase = new SqlConnection(@"Server=" + tbNewConnectionString.Text + "; Database=PharmacyProject;Trusted_Connection=True;");
            conWithMaster = new SqlConnection(@"Server=" + tbNewConnectionString.Text + ";Database=master;Trusted_Connection=True;");
        }
    }
}
