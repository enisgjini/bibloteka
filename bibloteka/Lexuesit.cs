using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace bibloteka
{
    public partial class Lexuesit : DevExpress.XtraEditors.XtraUserControl
    {
        private static Lexuesit _instance;
        string connectionString = "server=127.0.0.1;user id=root;persistsecurityinfo=True;port=3305;database=bibloteka;password=123456;"; //Set your MySQL connection string here.

        public static Lexuesit Instance
        {
            get
            {

                if (_instance == null)
                    _instance = new Lexuesit();
                return _instance;
            }
        }


        public Lexuesit()
        {
            InitializeComponent();
        }

        private void Lexuesit_Load(object sender, EventArgs e)
        {

            string query = "SELECT * FROM klienti"; // set query to fetch data "Select * from  tabelname"; 
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView2.DataSource = ds.Tables[0];
                }
            }
            
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txtEmri.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txtEmriIPrindit.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txtDataELindjes.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txtGjinia.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("es-ES");

            txtLexuesIRregullt.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
        }

        private void shto_Click(object sender, EventArgs e)
        {
            try
            {

                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "INSERT INTO bibloteka.klienti(emri, emri_i_prindit, data_e_lindjes, gjinia, data_e_antarsimit, lexues_i_rregullt) values('" + this.txtEmri.Text + "','" + this.txtEmriIPrindit.Text + "','" + this.txtDataELindjes.Text + "','" + this.txtGjinia.Text + "','" + this.dateTimePicker1.Text + "','" + this.txtLexuesIRregullt.Text + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(connectionString);
                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Save Data");
                string query = "SELECT * FROM klienti"; // set query to fetch data "Select * from  tabelname"; 
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView2.DataSource = ds.Tables[0];
                    }
                }
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void perditso_Click(object sender, EventArgs e)
        {
            try
            {

                //This is my update query in which i am taking input from the user through windows forms and update the record.  
                string Query = "UPDATE bibloteka.klienti SET emri='" + this.txtEmri.Text + "',emri_i_prindit='" + this.txtEmriIPrindit.Text + "',data_e_lindjes='" + this.txtDataELindjes.Text + "',gjinia='" + this.txtGjinia.Text + "',data_e_antarsimit='" + this.dateTimePicker1.Text + "',lexues_i_rregullt='" + this.txtLexuesIRregullt.Text + "' WHERE id_klienti='" + this.txtId.Text + "';";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(connectionString);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Updated");
                string query = "SELECT * FROM klienti"; // set query to fetch data "Select * from  tabelname"; 
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView2.DataSource = ds.Tables[0];
                    }
                }
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();//Connection closed here  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fshij_Click(object sender, EventArgs e)
        {
            try
            {

                string Query = "DELETE FROM bibloteka.klienti where id_klienti='" + this.txtId.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(connectionString);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Deleted");
                string query = "SELECT * FROM klienti"; // set query to fetch data "Select * from  tabelname"; 
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView2.DataSource = ds.Tables[0];
                    }
                }

                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM klienti"; // set query to fetch data "Select * from  tabelname"; 
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView2.DataSource = ds.Tables[0];
                }
            }
        }
    }
}
