using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// Libraria MySql
using MySql.Data;
using MySql.Data.MySqlClient;

namespace bibloteka
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public LoginForm()
        {
            InitializeComponent();
            // Making connection  
            con = new MySqlConnection("server=127.0.0.1;user id=root;password=123456;persistsecurityinfo=True;port=3305;database=bibloteka;");
        }

        private void kyqu_Click(object sender, EventArgs e)
        {
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM puntori WHERE emri_i_perdoruesit='" + emri_përdoruesit.Text + "' AND fjalekalimi='" + fjalekalimi.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                Ballina nextForm = new Ballina();
                this.Hide();
                nextForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            con.Close();
        }



        private void anulo_Click(object sender, EventArgs e)
        {
            emri_përdoruesit.Text = "";
            fjalekalimi.Text = "";
        }
    }
}
