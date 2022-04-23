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
    public partial class Librat : DevExpress.XtraEditors.XtraUserControl
    {
        string connectionString = "server=127.0.0.1;user id=root;persistsecurityinfo=True;port=3305;database=bibloteka;password=123456;";
        public Librat()
        {
            InitializeComponent();
        }
        

        private static Librat _instance;
        public static Librat Instance
        {
            get
            {

                if (_instance == null)
                    _instance = new Librat();
                return _instance;
            }
        }

        private void Librat_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM libri"; // set query to fetch data "Select * from  tabelname"; 
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTitulli.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtAutoriILibrit.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtZhanri.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtShtepiaBotuese.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtVitiIBotimit.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtVrejtje.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void printo_Click(object sender, EventArgs e)
        {

        }

        private void shto_Click(object sender, EventArgs e)
        {
            try
            {

                 
                string Query = "INSERT INTO bibloteka.libri(Titulli, Autori, Zhanri, Shtepia_botuese, Viti_i_botimit, Vrejtje) values" +
                    "('" + this.txtTitulli.Text + "','" + this.txtAutoriILibrit.Text + "','" + this.txtZhanri.Text + "','" + this.txtShtepiaBotuese.Text + "','" + this.txtVitiIBotimit.Text + "','" + this.txtVrejtje.Text + "');";
                MySqlConnection MyConn2 = new MySqlConnection(connectionString);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();    
                MessageBox.Show("Save Data");
                string query = "SELECT * FROM libri";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
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

                  
                string Query = "UPDATE bibloteka.libri SET Titulli='" + this.txtTitulli.Text + "',Autori='" + this.txtAutoriILibrit.Text + "',Zhanri='" + this.txtZhanri.Text + "',Shtepia_botuese='" + this.txtShtepiaBotuese.Text + "',Viti_i_botimit='" + this.txtVitiIBotimit.Text + "',Vrejtje='" + this.txtVrejtje.Text + "' WHERE ID='" + this.txtId.Text + "';";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(connectionString);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Updated");
                string query = "SELECT * FROM libri"; // set query to fetch data "Select * from  tabelname"; 
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
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

                string Query = "DELETE FROM bibloteka.libri where ID='" + this.txtId.Text + "';";
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
                        dataGridView1.DataSource = ds.Tables[0];
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
