using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestionEcole
{
    public partial class Others : Form
    {
        public Others()
        {
            InitializeComponent();
        }

        private void Utilisateurs_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
           
            if(Connection.connect()) {

                MessageBox.Show("you are connected");
            }
        }
    }
}
