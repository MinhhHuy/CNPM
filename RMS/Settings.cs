using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace RMS
{
    public partial class Settings : Sample
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void serverTxt_TextChanged(object sender, EventArgs e)
        {
            if(serverTxt.Text == "") 
            { 
                serverErrorLabel.Visible = true; 
            }
            else
            {
                serverErrorLabel.Visible = false;
            }
        }

        private void databaseTxt_TextChanged(object sender, EventArgs e)
        {
            if (databaseTxt.Text == "")
            {
                dbErrorLabel.Visible = true;
            }
            else
            {
                dbErrorLabel.Visible = false;
            }
        }

        private void userTxt_TextChanged(object sender, EventArgs e)
        {
            if (!isCB.Checked)
            {
                if (userTxt.Text == "")
                {
                    userErrorLabel.Visible = true;
                }
                else
                {
                    userErrorLabel.Visible = false;
                }
            }
        }

        private void passTxt_TextChanged(object sender, EventArgs e)
        {
            if (!isCB.Checked)
            {
                if (passTxt.Text == "")
                {
                    passErrorLabel.Visible = true;
                }
                else
                {
                    passErrorLabel.Visible = false;
                }
            }
        }

        private void isCB_CheckedChanged(object sender, EventArgs e)
        {
            if (isCB.Checked)
            {
                userErrorLabel.Visible = false;
                passErrorLabel.Visible = false;
                userTxt.Enabled = false;
                passTxt.Enabled = false;
                userTxt.Text = "";
                passTxt.Text = "";
            }
            else
            {
                userTxt.Enabled = true;
                passTxt.Enabled = true;
            }
        }
        string connection;
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (isCB.Checked)
            {
                //
                if (serverTxt.Text == "")
                {
                    serverErrorLabel.Visible = true;
                }
                else
                {
                    serverErrorLabel.Visible = false;
                }

                //
                if (databaseTxt.Text == "")
                {
                    dbErrorLabel.Visible = true;
                }
                else
                {
                    dbErrorLabel.Visible = false;
                }

                //
                if (serverErrorLabel.Visible || dbErrorLabel.Visible)
                {
                    MainClass.showMessage("Fields with * are mandatory.", "Error");
                }
                else
                {
                    connection = "Data Source=" + serverTxt.Text +
                                 ";Initial Catalog" + databaseTxt.Text + 
                                 ";Integrated Security=true;MultipleActiveResultSets= true;";
                    
                }
            }
            else
            {
                //
                if (serverTxt.Text == "")
                {
                    serverErrorLabel.Visible = true;
                }
                else
                {
                    serverErrorLabel.Visible = false;
                }

                //
                if (databaseTxt.Text == "")
                {
                    dbErrorLabel.Visible = true;
                }
                else
                {
                    dbErrorLabel.Visible = false;
                }

                //
                if (userTxt.Text == "")
                {
                    userErrorLabel.Visible = true;
                }
                else
                {
                    userErrorLabel.Visible = false;
                }

                //
                if (passTxt.Text == "")
                {
                    passErrorLabel.Visible = true;
                }
                else
                {
                    passErrorLabel.Visible = false;
                }

                //
                if (serverErrorLabel.Visible || dbErrorLabel.Visible || userErrorLabel.Visible || passErrorLabel.Visible)
                {
                    MainClass.showMessage("Fields with * are mandatory.", "Error");
                }
                else
                {
                    string connection 
                }

            }
        }
    }
}
