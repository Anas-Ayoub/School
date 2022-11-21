using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEcole
{
    public partial class InfoEcole : Form
    {
        public InfoEcole()
        {
            InitializeComponent();
        }

        private void InfoEcole_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
        }
    }
}
