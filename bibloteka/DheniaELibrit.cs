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
    public partial class DheniaELibrit : DevExpress.XtraEditors.XtraUserControl
    {
        private static DheniaELibrit _instance;

        MySqlConnection connection = new MySqlConnection("server=127.0.0.1;user id=root;persistsecurityinfo=True;port=3305;database=bibloteka;password=123456;");

        string connectionString = "server=127.0.0.1;user id=root;persistsecurityinfo=True;port=3305;database=bibloteka;password=123456;";
        MySqlCommand command;
        MySqlDataReader mdr;



        public static DheniaELibrit Instance
        {
            get
            {

                if (_instance == null)
                    _instance = new DheniaELibrit();
                return _instance;
            }
        }

        public DheniaELibrit()
        {
            InitializeComponent();



        }

        private void txtIdKlienti_OnValueChanged(object sender, EventArgs e)
        {
            connection.Open();
            try
            {
                string selectQuery = "SELECT * FROM bibloteka.klienti WHERE id_klienti=" + int.Parse(txtIdKlienti.Text);
                command = new MySqlCommand(selectQuery, connection);
                mdr = command.ExecuteReader();
                if (mdr.Read())
                {
                    txtEmri.Text = mdr.GetString("emri");
                    txtEmriIPrindit.Text = mdr.GetString("emri_i_prindit");
                    txtDataELindjes.Text = mdr.GetString("data_e_lindjes");
                    txtGjinia.Text = mdr.GetString("gjinia");
                    txtDataEAntarsimit.Text = mdr.GetString("data_e_antarsimit");
                    txtLexuesIRregullt.Text = mdr.GetString("lexues_i_rregullt");
                }
                else
                {
                    MessageBox.Show("No Data For This Id");
                }
            }
            catch (Exception)
            {
                //code for any other type of exception
            }

            connection.Close();
        }

        private void bunifuMetroTextbox7_OnValueChanged(object sender, EventArgs e)
        {

            connection.Open();
            try
            {
                string selectQuery = "SELECT * FROM bibloteka.libri WHERE ID=" + int.Parse(txtIdLibri.Text);
                command = new MySqlCommand(selectQuery, connection);
                mdr = command.ExecuteReader();
                if (mdr.Read())
                {
                    txtTitulli.Text = mdr.GetString("Titulli");
                    txtAutori.Text = mdr.GetString("Autori");
                }

                else
                {
                    MessageBox.Show("No Data For This Id");
                }
            }
            catch (Exception)
            {
                //code for any other type of exception
            }
            connection.Close();
        }

        private void DheniaELibrit_Load(object sender, EventArgs e)
        {
            timer1.Start();
            string query = "SELECT * FROM kartela_klientit"; // set query to fetch data "Select * from  tabelname"; 
            using (MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;persistsecurityinfo=True;port=3305;database=bibloteka;password=123456;"))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    libratEDhene.DataSource = ds.Tables[0];
                }
            }
            string query1 = "SELECT * FROM librat_e_kthyer";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query1, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    libratEKthyer.DataSource = ds.Tables[0];
                }

            }

            string query2 = "SELECT id_klienti,emri FROM klienti"; // set query to fetch data "Select * from  tabelname"; 
            using (MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;persistsecurityinfo=True;port=3305;database=bibloteka;password=123456;"))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query2, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    id_dhe_emri.DataSource = ds.Tables[0];
                }
            }

            string query3 = "SELECT ID,Titulli,Autori FROM libri"; // set query to fetch data "Select * from  tabelname"; 
            using (MySqlConnection conn = new MySqlConnection("server=127.0.0.1;user id=root;persistsecurityinfo=True;port=3305;database=bibloteka;password=123456;"))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query3, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    titulli_dhe_autori.DataSource = ds.Tables[0];
                }
            }
        }

        private void jep_Click(object sender, EventArgs e)
        {
            try
            {

                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "INSERT INTO bibloteka.kartela_klientit (Id, Emri, Titulli_librit, Autori, Data_e_marrjes, Data_e_kthimit, Vrejtje) values('" + this.txtIdKlienti.Text + "','" + this.txtEmri.Text + "','" + this.txtTitulli.Text + "','" + this.txtAutori.Text + "','" + this.txtDataEMarrjes.Text + "','" + this.txtDataEKthimit.Text + "','" + this.txtVrejtje.Text + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(connectionString);
                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Save Data");
                string query = "SELECT * FROM kartela_klientit"; // set query to fetch data "Select * from  tabelname"; 
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        libratEDhene.DataSource = ds.Tables[0];
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            label19.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();

        }

        private void pastro_Click(object sender, EventArgs e)
        {
            txtIdLibri.Text = "";
            txtTitulli.Text = "";
            txtAutori.Text = "";
            txtDataEMarrjes.Text = "";
            txtDataEKthimit.Text = "";

        }

     
       

        

        private void txtIdEKthyesit_OnValueChanged(object sender, EventArgs e)
        {
            connection.Open();
            try
            { 
            string selectQuery = "SELECT * FROM bibloteka.kartela_klientit WHERE Id=" + int.Parse(txtIdEKthyesit.Text);
            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            if (mdr.Read())
            {
                txtEmriIKthyesit.Text = mdr.GetString("Emri");
                txtTitulliLibritKthyes.Text = mdr.GetString("Titulli_librit");
                txtDataEKthimit1.Text = mdr.GetString("Data_e_kthimit");
                txtVrejtjeKthimi.Text = mdr.GetString("Vrejtje");
                
            }
            else
            {
                MessageBox.Show("No Data For This Id");
            }
            }
            catch (Exception)
            {

            }
            connection.Close();
        }

        private void kthe_Click(object sender, EventArgs e)
        {
            try
            {
                string Query =
                    "INSERT INTO bibloteka.librat_e_kthyer(Emri, Titulli_librit, Data_e_kthimit, Vrejtje) values('" +
                    this.txtEmriIKthyesit.Text + "','" + this.txtTitulliLibritKthyes.Text +
                    "','" + this.txtDataEKthimit1.Text + "','" + this.txtVrejtjeKthimi.Text +
                    "');";

                MySqlConnection MyConn2 = new MySqlConnection(connectionString);

                MySqlCommand MyCommand1 = new MySqlCommand(Query, MyConn2);

                MySqlDataReader MyReader1;

                MyConn2.Open();

                MyReader1 = MyCommand1.ExecuteReader();

                string query1 = "SELECT * FROM librat_e_kthyer";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query1, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        libratEKthyer.DataSource = ds.Tables[0];
                    }
                }

                while (MyReader1.Read())
                {
                }

                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {

                string Query = "DELETE FROM bibloteka.kartela_klientit WHERE Id='" + this.txtIdEKthyesit.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(connectionString);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Të dhënat u fshinë");
                string query = "SELECT * FROM kartela_klientit"; 
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        libratEDhene.DataSource = ds.Tables[0];
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
    }
}
