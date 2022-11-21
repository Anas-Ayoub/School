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



namespace GestionEcole
{
    public partial class Etudiants : Form
    {
 
        
        public Etudiants()
        {
            InitializeComponent();
        }

        private void Etudiants_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = @"server=sql9.freesqldatabase.com;userid=sql9579093;password=JbXrp8MpGs;database=sql9579093;PORT=3306";
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = cs;
            try
            {
                conn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            //MySqlCommand cmd = new MySqlCommand("Select * from Utilisateurs");

        }
    }
}
