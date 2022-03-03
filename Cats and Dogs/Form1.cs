using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cats_and_Dogs
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;

        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CatsAndDogsDB.Properties.Settings.PetsConnection"].ConnectionString;
        }

        private void PopulatePetsTabele()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter) new SqlDataAdapter("SELECT * FROM PetType", connection))
            {
                DataTable petTable = new DataTable();
                adapter.Fill(petTable);

                listPets.DisplayMember = "PetTypename";
                listPets.ValueMember = "Id";
                listPets.DataSource = petTable;
            }
        }

        private void Pets_Click(object sender, EventArgs e)
        {

        }

        private void listpets_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulatePetsTabele();
        }
    }
}
